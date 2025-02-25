namespace HabitTrackerLogin
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbWorkoutType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstExercises = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstExercises2 = new System.Windows.Forms.ListBox();
            this.cmbWorkoutType2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbKadin = new System.Windows.Forms.CheckBox();
            this.rbErkek = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKalca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoyun = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYagOrani = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartFatPercentage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFatPercentage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbWorkoutType
            // 
            this.cmbWorkoutType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkoutType.FormattingEnabled = true;
            this.cmbWorkoutType.Items.AddRange(new object[] {
            "Push",
            "Pull",
            "Leg"});
            this.cmbWorkoutType.Location = new System.Drawing.Point(93, 105);
            this.cmbWorkoutType.Name = "cmbWorkoutType";
            this.cmbWorkoutType.Size = new System.Drawing.Size(121, 24);
            this.cmbWorkoutType.TabIndex = 0;
            this.cmbWorkoutType.SelectedIndexChanged += new System.EventHandler(this.cmbWorkoutType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçim Yapınız :";
            // 
            // lstExercises
            // 
            this.lstExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstExercises.FormattingEnabled = true;
            this.lstExercises.ItemHeight = 18;
            this.lstExercises.Location = new System.Drawing.Point(320, 68);
            this.lstExercises.Name = "lstExercises";
            this.lstExercises.Size = new System.Drawing.Size(267, 112);
            this.lstExercises.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(60, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "İtiş Çekiş Bacak Seçim ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(682, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bölgesel Seçim ";
            // 
            // lstExercises2
            // 
            this.lstExercises2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstExercises2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstExercises2.FormattingEnabled = true;
            this.lstExercises2.ItemHeight = 18;
            this.lstExercises2.Location = new System.Drawing.Point(893, 68);
            this.lstExercises2.Name = "lstExercises2";
            this.lstExercises2.Size = new System.Drawing.Size(267, 112);
            this.lstExercises2.TabIndex = 8;
            // 
            // cmbWorkoutType2
            // 
            this.cmbWorkoutType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkoutType2.FormattingEnabled = true;
            this.cmbWorkoutType2.Items.AddRange(new object[] {
            "Leg",
            "Chest",
            "Back",
            "Shoulder",
            "Arm",
            "Abdominal"});
            this.cmbWorkoutType2.Location = new System.Drawing.Point(687, 105);
            this.cmbWorkoutType2.Name = "cmbWorkoutType2";
            this.cmbWorkoutType2.Size = new System.Drawing.Size(121, 24);
            this.cmbWorkoutType2.TabIndex = 6;
            this.cmbWorkoutType2.SelectedIndexChanged += new System.EventHandler(this.cmbWorkoutType2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(98, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yağ Oranı Hesaplama :";
            // 
            // txtBel
            // 
            this.txtBel.Location = new System.Drawing.Point(167, 100);
            this.txtBel.Name = "txtBel";
            this.txtBel.Size = new System.Drawing.Size(100, 20);
            this.txtBel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bel Ölçüsü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Boy Ölçüsü:";
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(167, 137);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 20);
            this.txtBoy.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cinsiyet :";
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(160, 63);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(53, 17);
            this.rbKadin.TabIndex = 18;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(219, 63);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(54, 17);
            this.rbErkek.TabIndex = 19;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Kalça Ölçüsü :";
            // 
            // txtKalca
            // 
            this.txtKalca.Location = new System.Drawing.Point(392, 96);
            this.txtKalca.Name = "txtKalca";
            this.txtKalca.Size = new System.Drawing.Size(100, 20);
            this.txtKalca.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Boyun Çevresi :";
            // 
            // txtBoyun
            // 
            this.txtBoyun.Location = new System.Drawing.Point(392, 59);
            this.txtBoyun.Name = "txtBoyun";
            this.txtBoyun.Size = new System.Drawing.Size(100, 20);
            this.txtBoyun.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(113, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Yağ Oranı :";
            // 
            // txtYagOrani
            // 
            this.txtYagOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYagOrani.Location = new System.Drawing.Point(356, 205);
            this.txtYagOrani.Name = "txtYagOrani";
            this.txtYagOrani.Size = new System.Drawing.Size(100, 26);
            this.txtYagOrani.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(620, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(318, 204);
            this.dataGridView1.TabIndex = 27;
            // 
            // chartFatPercentage
            // 
            this.chartFatPercentage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chartFatPercentage.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartFatPercentage.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.HorizontalBrick;
            this.chartFatPercentage.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartFatPercentage.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFatPercentage.Legends.Add(legend1);
            this.chartFatPercentage.Location = new System.Drawing.Point(981, 308);
            this.chartFatPercentage.Name = "chartFatPercentage";
            this.chartFatPercentage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFatPercentage.Series.Add(series1);
            this.chartFatPercentage.Size = new System.Drawing.Size(337, 300);
            this.chartFatPercentage.TabIndex = 28;
            this.chartFatPercentage.Text = "chart1";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(219, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 41);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Verileri Sıfırla";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbWorkoutType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstExercises);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbWorkoutType2);
            this.groupBox1.Controls.Add(this.lstExercises2);
            this.groupBox1.Location = new System.Drawing.Point(35, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1256, 240);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workout";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(684, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Seçim Yapınız :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBel);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBoy);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtYagOrani);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rbKadin);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rbErkek);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtBoyun);
            this.groupBox2.Controls.Add(this.txtKalca);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(49, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 321);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1340, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartFatPercentage);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFatPercentage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbWorkoutType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstExercises;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstExercises2;
        private System.Windows.Forms.ComboBox cmbWorkoutType2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox rbKadin;
        private System.Windows.Forms.CheckBox rbErkek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKalca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoyun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtYagOrani;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFatPercentage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
    }
}