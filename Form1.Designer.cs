namespace lab1_CG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_scale = new System.Windows.Forms.TextBox();
            this.btn_changeColor = new System.Windows.Forms.Button();
            this.btn_createRectangle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_B_Y = new System.Windows.Forms.TextBox();
            this.textBox_B_X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_createTriangle = new System.Windows.Forms.Button();
            this.textBox_A_Y = new System.Windows.Forms.TextBox();
            this.textBox_lengthHeight = new System.Windows.Forms.TextBox();
            this.textBox_A_X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1466, 800);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_scale);
            this.groupBox1.Controls.Add(this.btn_changeColor);
            this.groupBox1.Controls.Add(this.btn_createRectangle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_B_Y);
            this.groupBox1.Controls.Add(this.textBox_B_X);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_createTriangle);
            this.groupBox1.Controls.Add(this.textBox_A_Y);
            this.groupBox1.Controls.Add(this.textBox_lengthHeight);
            this.groupBox1.Controls.Add(this.textBox_A_X);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(566, 648);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Scale:";
            // 
            // textBox_scale
            // 
            this.textBox_scale.Location = new System.Drawing.Point(178, 353);
            this.textBox_scale.Name = "textBox_scale";
            this.textBox_scale.Size = new System.Drawing.Size(149, 30);
            this.textBox_scale.TabIndex = 19;
            this.textBox_scale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_scale_KeyPress);
            // 
            // btn_changeColor
            // 
            this.btn_changeColor.Location = new System.Drawing.Point(300, 577);
            this.btn_changeColor.Name = "btn_changeColor";
            this.btn_changeColor.Size = new System.Drawing.Size(241, 64);
            this.btn_changeColor.TabIndex = 18;
            this.btn_changeColor.Text = "Change color";
            this.btn_changeColor.UseVisualStyleBackColor = true;
            this.btn_changeColor.Click += new System.EventHandler(this.btn_changeColor_Click);
            // 
            // btn_createRectangle
            // 
            this.btn_createRectangle.Location = new System.Drawing.Point(20, 577);
            this.btn_createRectangle.Name = "btn_createRectangle";
            this.btn_createRectangle.Size = new System.Drawing.Size(241, 64);
            this.btn_createRectangle.TabIndex = 17;
            this.btn_createRectangle.Text = "Construct a rectangle";
            this.btn_createRectangle.UseVisualStyleBackColor = true;
            this.btn_createRectangle.Click += new System.EventHandler(this.btn_createRectangle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-6, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(570, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Do you want to build a rectangle around a triangle or change the color?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "X";
            // 
            // textBox_B_Y
            // 
            this.textBox_B_Y.Location = new System.Drawing.Point(243, 197);
            this.textBox_B_Y.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_B_Y.Name = "textBox_B_Y";
            this.textBox_B_Y.Size = new System.Drawing.Size(86, 30);
            this.textBox_B_Y.TabIndex = 13;
            this.textBox_B_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_B_Y_KeyPress);
            // 
            // textBox_B_X
            // 
            this.textBox_B_X.Location = new System.Drawing.Point(58, 197);
            this.textBox_B_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_B_X.Name = "textBox_B_X";
            this.textBox_B_X.Size = new System.Drawing.Size(89, 30);
            this.textBox_B_X.TabIndex = 12;
            this.textBox_B_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_B_X_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // btn_createTriangle
            // 
            this.btn_createTriangle.Location = new System.Drawing.Point(151, 432);
            this.btn_createTriangle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_createTriangle.Name = "btn_createTriangle";
            this.btn_createTriangle.Size = new System.Drawing.Size(177, 56);
            this.btn_createTriangle.TabIndex = 9;
            this.btn_createTriangle.Text = "Create";
            this.btn_createTriangle.UseVisualStyleBackColor = true;
            this.btn_createTriangle.Click += new System.EventHandler(this.btn_createTriangle_Click);
            // 
            // textBox_A_Y
            // 
            this.textBox_A_Y.Location = new System.Drawing.Point(241, 91);
            this.textBox_A_Y.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_A_Y.Name = "textBox_A_Y";
            this.textBox_A_Y.Size = new System.Drawing.Size(86, 30);
            this.textBox_A_Y.TabIndex = 6;
            this.textBox_A_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_A_Y_KeyPress);
            // 
            // textBox_lengthHeight
            // 
            this.textBox_lengthHeight.Location = new System.Drawing.Point(178, 281);
            this.textBox_lengthHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_lengthHeight.Name = "textBox_lengthHeight";
            this.textBox_lengthHeight.Size = new System.Drawing.Size(149, 30);
            this.textBox_lengthHeight.TabIndex = 5;
            this.textBox_lengthHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lengthHeight_KeyPress);
            // 
            // textBox_A_X
            // 
            this.textBox_A_X.Location = new System.Drawing.Point(58, 87);
            this.textBox_A_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_A_X.Name = "textBox_A_X";
            this.textBox_A_X.Size = new System.Drawing.Size(89, 30);
            this.textBox_A_X.TabIndex = 4;
            this.textBox_A_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_A_X_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length height: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point A:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(575, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 1000);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 694);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_createTriangle;
        private System.Windows.Forms.TextBox textBox_A_Y;
        private System.Windows.Forms.TextBox textBox_lengthHeight;
        private System.Windows.Forms.TextBox textBox_A_X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_B_Y;
        private System.Windows.Forms.TextBox textBox_B_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_changeColor;
        private System.Windows.Forms.Button btn_createRectangle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_scale;
    }
}

