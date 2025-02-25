using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitTrackerLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // girilen değerler değişkenlere atanıyor
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // SQLite bağlantı
            string connectionString = "Data Source=habit_tracker.db;Version=3;";

            // SQLite bağlantı açılıyor
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // SQL sorgusu
                string query = @"
            INSERT INTO users (fullName, email, username, password) 
            VALUES (@fullName, @email, @username, @password);
        ";

                // SQLiteCommand oluşturuluyor
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    // Veritabanına kaydediyoruz
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Kayıt sonrası formu kapat
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Form2'yi kapat
        }
    }
}
