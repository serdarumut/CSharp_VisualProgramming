using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HabitTrackerLogin
{
    public partial class Form3 : Form
    {
        string currentUser = Form1.loggedInUsername; // Giriş yapan kullanıcı adı

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // form yüklendiğide tabloyu ve grafiği doldurur
            LoadFatPercentageChart();
            LoadFatPercentageData(); 
        }
        

        private void cmbWorkoutType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstExercises.Items.Clear();
            lstExercises2.Items.Clear();

            if (cmbWorkoutType.SelectedIndex == 0)
            {
                lstExercises.Items.Add("Push Up");
                lstExercises.Items.Add("Bench Press");
                lstExercises.Items.Add("Cable Crossover");
                lstExercises.Items.Add("Shoulder Mediterranean Press");
                lstExercises.Items.Add("Lateral Raises");
                lstExercises.Items.Add("Dips");
            }
            else if (cmbWorkoutType.SelectedIndex == 1)
            {
                lstExercises.Items.Add("Pull Up");
                lstExercises.Items.Add("Deadlift");
                lstExercises.Items.Add("Barbell Rows");
                lstExercises.Items.Add("Cable Crossover");
                lstExercises.Items.Add("Lat Pull-Downs");
                lstExercises.Items.Add("Bent-Over Dumbbell Flyes");
            }
            else if (cmbWorkoutType.SelectedIndex == 2)
            {
                lstExercises.Items.Add("Squats");
                lstExercises.Items.Add("Leg Press");
                lstExercises.Items.Add("Leg Extension");
                lstExercises.Items.Add("Leg Curl");
                lstExercises.Items.Add("!! Bonus !! Legs Up Crunch");
            }
        }

        private void cmbWorkoutType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstExercises.Items.Clear();
            lstExercises2.Items.Clear();

            if (cmbWorkoutType2.SelectedIndex == 0)
            {
                lstExercises2.Items.Add("Squats");
                lstExercises2.Items.Add("Leg Press");
                lstExercises2.Items.Add("Leg Extension");
                lstExercises2.Items.Add("Leg Curl");
                lstExercises2.Items.Add("Duck Walking");
            }
            else if (cmbWorkoutType2.SelectedIndex == 1)
            {
                lstExercises2.Items.Add("Push Up");
                lstExercises2.Items.Add("Bench Press");
                lstExercises2.Items.Add("Cable Crossover");
                lstExercises2.Items.Add("Shoulder Mediterranean Press");
                lstExercises2.Items.Add("Lateral Raises");
                lstExercises2.Items.Add("Dips");
            }
            else if (cmbWorkoutType2.SelectedIndex == 2)
            {
                lstExercises2.Items.Add("Pull Up");
                lstExercises2.Items.Add("Deadlift");
                lstExercises2.Items.Add("Barbell Rows");
                lstExercises2.Items.Add("Cable Crossover");
                lstExercises2.Items.Add("Lat Pull-Downs");
                lstExercises2.Items.Add("Bent-Over Dumbbell Flyes");
            }
            else if (cmbWorkoutType2.SelectedIndex == 3)
            {
                lstExercises2.Items.Add("Overhead Press");
                lstExercises2.Items.Add("Lateral Raise");
                lstExercises2.Items.Add("Front Raise");
                lstExercises2.Items.Add("Arnold Press");
                lstExercises2.Items.Add("Reverse Fly");
            }
            else if (cmbWorkoutType2.SelectedIndex == 4)
            {
                lstExercises2.Items.Add("Bicep Curl");
                lstExercises2.Items.Add("Tricep Dips");
                lstExercises2.Items.Add("Hammer Curl");
                lstExercises2.Items.Add("Tricep Kickbacks");
                lstExercises2.Items.Add("Barbell Curl");
            }
            else if (cmbWorkoutType2.SelectedIndex == 5)
            {
                lstExercises2.Items.Add("Plank");
                lstExercises2.Items.Add("Crunch");
                lstExercises2.Items.Add("Leg Raises");
                lstExercises2.Items.Add("Russian Twist");
                lstExercises2.Items.Add("Mountain Climbers");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yagOrani = 0;

            try
            {
                bool kadin = rbKadin.Checked;
                bool erkek = rbErkek.Checked;

                double bel = Convert.ToDouble(txtBel.Text);
                double boyun = Convert.ToDouble(txtBoyun.Text);
                double boy = Convert.ToDouble(txtBoy.Text);
                double kalca = kadin ? Convert.ToDouble(txtKalca.Text) : 0;

                if (erkek)
                {
                    yagOrani = 495 / (1.0324 - 0.19077 * Math.Log10(bel - boyun) + 0.15456 * Math.Log10(boy)) - 450;
                }
                else if (kadin)
                {
                    yagOrani = 495 / (1.29579 - 0.35004 * Math.Log10(bel + kalca - boyun) + 0.22100 * Math.Log10(boy)) - 450;
                }
                else
                {
                    MessageBox.Show("Lütfen cinsiyet seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                yagOrani = Math.Round(yagOrani, 1);  // bir ondaklıklı olarak ayarlama (Tablo çok karışıyor diye böyle yaptım.)
                txtYagOrani.Text = yagOrani.ToString("F1");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Veritabanı kaydı
            string connectionString = "Data Source=habit_tracker.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"INSERT INTO FatPercentage (username, date, fat_percentage) VALUES (@username, @date, @fat_percentage);";

                SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@username", currentUser);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@fat_percentage", yagOrani);

                command.ExecuteNonQuery();
                MessageBox.Show("Yağ oranı başarıyla kaydedildi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Tablo ve chartı Güncelle
            LoadFatPercentageData(); 
            LoadFatPercentageChart();
        }

        private void LoadFatPercentageData()
        {
            string connectionString = "Data Source=habit_tracker.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM FatPercentage WHERE username = @username";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@username", currentUser);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }
        private void LoadFatPercentageChart()
        {
            string connectionString = "Data Source=habit_tracker.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, fat_percentage FROM FatPercentage WHERE username = @username";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@username", currentUser);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
             
                chartFatPercentage.Series.Clear();

                Series series = new Series("Yağ Oranı");
                series.ChartType = SeriesChartType.Line; 
                series.XValueType = ChartValueType.Int32; 

               
                foreach (DataRow row in dataTable.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    double fatPercentage = Convert.ToDouble(row["fat_percentage"]);

                    series.Points.AddXY(id, fatPercentage);
                }

                chartFatPercentage.Series.Add(series);

                // X ekseni
                chartFatPercentage.ChartAreas[0].AxisX.Title = "ID";
                chartFatPercentage.ChartAreas[0].AxisY.Title = "Yağ Oranı (%)";
                chartFatPercentage.ChartAreas[0].AxisX.Interval = 1;        // her id için etiket göster
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=habit_tracker.db;Version=3;";

            // Veritabanındaki kayıtları sil
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM FatPercentage WHERE username = @username;";
                    SQLiteCommand command = new SQLiteCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@username", currentUser);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // id'yi sıfırla
                        string resetIdQuery = "DELETE FROM sqlite_sequence WHERE name='FatPercentage';";
                        SQLiteCommand resetIdCommand = new SQLiteCommand(resetIdQuery, connection);
                        resetIdCommand.ExecuteNonQuery();

                        MessageBox.Show("Tüm veriler başarıyla silindi ve ID sıfırlandı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silinecek veri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // tablo ve chartı temizle
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            chartFatPercentage.Series.Clear();

            // Kullanıcıya işlem tamamlandığını bildiren bir mesaj göster
            MessageBox.Show("DataGridView ve Chart başarıyla sıfırlandı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

