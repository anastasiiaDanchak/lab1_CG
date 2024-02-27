using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace lab1_CG

{
    class Triangle
    {
        // Draws an isosceles triangle and its base if sides or angles are equal
        public static bool DrawTriangle(Bitmap image, ColorDialog colorDialog, PointF[] points)
        {
            float sideAB = Distance(points[0], points[1]);
            float sideBC = Distance(points[1], points[2]);
            float sideCA = Distance(points[2], points[0]);

          
            if (sideAB == sideBC || sideBC == sideCA || sideCA == sideAB)
            {
             
                float angleA = GetAngle(points[1], points[0], points[2]);
                float angleB = GetAngle(points[0], points[1], points[2]);
                float angleC = GetAngle(points[0], points[2], points[1]);

                if (Math.Round(angleA) == Math.Round(angleB) || Math.Round(angleB) == Math.Round(angleC) || Math.Round(angleC) == Math.Round(angleA))
                {
                
                    Pen pen = new Pen(Color.Black, 2);
                    Graphics.FromImage(image).DrawPolygon(pen, points);
                   
                    float baseMidpointX = (points[0].X + points[1].X) / 2;
                    float baseMidpointY = (points[0].Y + points[1].Y) / 2;
                    Graphics.FromImage(image).DrawLine(pen, points[2], new PointF(baseMidpointX, baseMidpointY));

                    return true;
                }
            }
            MessageBox.Show("The triangle is not isosceles");
            return false; 
        }

        // Computes the distance between two points
        private static float Distance(PointF A, PointF B)
        {
            return (float)Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        // Computes the angle between vectors AB and BC from point B
        private static float GetAngle(PointF A, PointF B, PointF C)
        {
            float angleA = (float)Math.Atan2(C.Y - B.Y, C.X - B.X) - (float)Math.Atan2(A.Y - B.Y, A.X - B.X);
            angleA = (angleA < 0) ? angleA + 2 * (float)Math.PI : angleA;
            return angleA;
        }

        // Draws a green rectangle around the triangle in the image
        public static void DrawRectangleAroundTriangle(PointF[] triangle, Bitmap image)
        {
            if (triangle.Length == 0)
                return;

            float minX = float.MaxValue;
            float minY = float.MaxValue;
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            foreach (var point in triangle)
            {
                minX = Math.Min(minX, point.X);
                minY = Math.Min(minY, point.Y);
                maxX = Math.Max(maxX, point.X);
                maxY = Math.Max(maxY, point.Y);
            }

            Rectangle boundingRect = new Rectangle((int)minX, (int)minY, (int)(maxX - minX), (int)(maxY - minY));

            Pen rectPen = new Pen(Color.Green, 2);
            Graphics.FromImage(image).DrawRectangle(rectPen, boundingRect);
        }

    }


    
}