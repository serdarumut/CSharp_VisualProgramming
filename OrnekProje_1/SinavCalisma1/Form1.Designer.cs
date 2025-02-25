namespace SinavCalisma1
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
            txtNumber = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lstNumbers = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(80, 75);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(140, 23);
            txtNumber.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(266, 69);
            button1.Name = "button1";
            button1.Size = new Size(95, 31);
            button1.TabIndex = 1;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(266, 106);
            button2.Name = "button2";
            button2.Size = new Size(95, 31);
            button2.TabIndex = 2;
            button2.Text = "remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lstNumbers
            // 
            lstNumbers.FormattingEnabled = true;
            lstNumbers.ItemHeight = 15;
            lstNumbers.Location = new Point(80, 124);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new Size(140, 169);
            lstNumbers.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(266, 143);
            button3.Name = "button3";
            button3.Size = new Size(95, 31);
            button3.TabIndex = 4;
            button3.Text = "update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(lstNumbers);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNumber);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button button1;
        private Button button2;
        private ListBox lstNumbers;
        private Button button3;
    }
}
