namespace SinavCalisma_2
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
            txtFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnFind = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(151, 57);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(64, 59);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(64, 88);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(151, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(64, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 28);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(169, 131);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 28);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(64, 176);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(82, 28);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(169, 176);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(82, 28);
            btnFind.TabIndex = 7;
            btnFind.Text = "find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(64, 230);
            listView1.Name = "listView1";
            listView1.Size = new Size(568, 165);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(listView1);
            Controls.Add(btnFind);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Label label1;
        private Label label2;
        private TextBox txtLastName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnFind;
        private ListView listView1;
    }
}
