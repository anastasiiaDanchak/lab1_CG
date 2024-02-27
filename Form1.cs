using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_CG
{
    public partial class Form1 : Form
    {
        Bitmap image;
        PointF[] points;
     

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(500, 500);
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics.FromImage(image).Clear(Color.White);
            pictureBox1.Image = image;

            textBox_A_X.Text = "50";
            textBox_A_Y.Text = "50";
            textBox_B_X.Text = "250";
            textBox_B_Y.Text = "50";
            textBox_lengthHeight.Text = "150";
            textBox_scale.Text = "50";

        }
        private List<PointF[]> triangles = new List<PointF[]>();
        bool isTriangleBuilt = false;
        private void btn_createTriangle_Click(object sender, EventArgs e)
        {

            float w = pictureBox1.Width / 2;
            float h = pictureBox1.Height / 2;
            int scale = Convert.ToInt32(textBox_scale.Text);
            Graphics.FromImage(image).Clear(Color.White);
            CoordinateSystem.FillArea(image, pictureBox1, scale);
            pictureBox1.Image = image;

            float baseA_X = Convert.ToSingle(textBox_A_X.Text) * scale / 100 + w;
            float baseA_Y = -Convert.ToSingle(textBox_A_Y.Text) * scale / 100 + h;

            float baseB_X = Convert.ToSingle(textBox_B_X.Text) * scale / 100 + w;
            float baseB_Y = -Convert.ToSingle(textBox_B_Y.Text) * scale / 100 + h;


            float averageX = (baseA_X + baseB_X) / 2;
            float averageY = (baseA_Y + baseB_Y) / 2;

            float lengthHeight = -Convert.ToSingle(textBox_lengthHeight.Text) * scale / 100;

            points = new PointF[]
            {
                new PointF(baseA_X, baseA_Y), 
                new PointF(baseB_X, baseB_Y), 
                 new PointF(averageX, averageY + lengthHeight)
            };

            triangles.Add(points);
            DrawAllTriangles();
        }

        private void DrawAllTriangles()
        {
            foreach (var points in triangles)
            {
                isTriangleBuilt = Triangle.DrawTriangle(image, colorDialog1, points);
            }
            pictureBox1.Image = image;
        }
        private void btn_createRectangle_Click(object sender, EventArgs e)
        {
            if (isTriangleBuilt == true)
            {
                foreach (var triangle in triangles)
                {
                    Triangle.DrawRectangleAroundTriangle(triangle, image);
                }

                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("You didn't build a triangle!");
            }
        }

        private void btn_changeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = image;

               
                foreach (var triangle in triangles)
                {
                    
                    Pen trianglePen = new Pen(Color.Black, 3);  
                    Graphics.FromImage(image).DrawPolygon(trianglePen, triangle);
                 
                    SolidBrush triangleBrush = new SolidBrush(colorDialog1.Color);
                    Graphics.FromImage(image).FillPolygon(triangleBrush, triangle);
                }
            }
        }

        private void textBox_A_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_A_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_B_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_B_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }
        private void textBox_lengthHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }
        private void textBox_scale_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }



        }
    }
}

