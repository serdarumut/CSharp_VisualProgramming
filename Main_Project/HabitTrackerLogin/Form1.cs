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
    public partial class Form1 : Form
    {
        public static string loggedInUsername;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeDatabase()                 // SQLite başlatıp tabloları oluşturduğumuz kısım
        {
            string connectionString = "Data Source=habit_tracker.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // KULLANICILAR TABLOSU
                    string createUsersTableQuery = @"
            CREATE TABLE IF NOT EXISTS users (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                fullName TEXT NOT NULL,
                email TEXT NOT NULL,
                username TEXT NOT NULL UNIQUE,
                password TEXT NOT NULL
            );
            ";

                SQLiteCommand usersCommand = new SQLiteCommand(createUsersTableQuery, connection);
                usersCommand.ExecuteNonQuery();

                // YAĞ ORANI TABLOSU
                    string createFatPercentageTableQuery = @"
            CREATE TABLE IF NOT EXISTS FatPercentage (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                username TEXT NOT NULL,
                date TEXT NOT NULL,
                fat_percentage REAL NOT NULL
            );
            ";

                SQLiteCommand fatPercentageCommand = new SQLiteCommand(createFatPercentageTableQuery, connection);
                fatPercentageCommand.ExecuteNonQuery();
            }
        }

        
        private void btnRegister_Click(object sender, EventArgs e)       // Kayıt OL
        {
            Form2 registerForm = new Form2();
            registerForm.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)           // Giriş YAP
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // girdi kontrol
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=habit_tracker.db;Version=3;";


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                // veritabanında kullanıcı arama
                string query = "SELECT COUNT(1) FROM users WHERE username = @username";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                int userExists = Convert.ToInt32(command.ExecuteScalar());

                if (userExists == 0)
                {
                    MessageBox.Show("Kullanıcı bulunamadı. Lütfen bilgilerinizi kontrol edin veya kaydolun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // tablodan şifreyi alıp giriş ekranındaki şifreyle karşılaştırmaca
                query = "SELECT password FROM users WHERE username = @username";
                command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                string storedPassword = command.ExecuteScalar() as string;
                
                if (storedPassword == null)
                {
                    // Şifre bulunamadı
                    MessageBox.Show("Şifre hatalı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (storedPassword == password)
                {
                    MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    loggedInUsername = username;          // bu atama sayesinde form3de username'i kullanacağız

                    Form3 mainForm = new Form3();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre yanlış. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}
