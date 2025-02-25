namespace FORM1._1
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

      
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
            txtDimension = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtDimension
            // 
            txtDimension.AutoSize = true;
            txtDimension.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDimension.Location = new Point(67, 58);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(87, 20);
            txtDimension.TabIndex = 0;
            txtDimension.Text = "Dimension :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 534);
            Controls.Add(textBox1);
            Controls.Add(txtDimension);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtDimension;
        private TextBox textBox1;
    }
}
