namespace SinavCalisma_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
//            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 59);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "Equlation Format";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(124, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 29);
            textBox1.TabIndex = 2;
            textBox1.Text = "ax^2 + bx + c";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(51, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(51, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(256, 196);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(51, 23);
            textBox4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(111, 161);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 6;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(193, 161);
            label3.Name = "label3";
            label3.Size = new Size(19, 21);
            label3.TabIndex = 7;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(273, 161);
            label4.Name = "label4";
            label4.Size = new Size(14, 13);
            label4.TabIndex = 8;
            label4.Text = "C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(82, 253);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 9;
            label5.Text = "x =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(111, 253);
            label6.Name = "label6";
            label6.Size = new Size(15, 21);
            label6.TabIndex = 10;
            label6.Text = "[";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(273, 253);
            label7.Name = "label7";
            label7.Size = new Size(15, 21);
            label7.TabIndex = 11;
            label7.Text = "]";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(132, 255);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(51, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(204, 255);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(51, 23);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(185, 257);
            label8.Name = "label8";
            label8.Size = new Size(13, 21);
            label8.TabIndex = 14;
            label8.Text = ",";
            // 
            // button1
            // 
            button1.Location = new Point(98, 301);
            button1.Name = "button1";
            button1.Size = new Size(199, 31);
            button1.TabIndex = 15;
            button1.Text = "DRAW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(403, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(301, 262);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label8;
        private Button button1;
        private PictureBox pictureBox2;
    }
}
