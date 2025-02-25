using System.Data.SQLite;

namespace SinavCalisma_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string db_name2 = "users.db";

        public void createDatabase()
        {
            if (!File.Exists(db_name2))
            {
                SQLiteConnection.CreateFile(db_name2);
            }

            SQLiteConnection con = new SQLiteConnection("Data Source=" + db_name2);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS users(first_name TEXT NOT NULL, last_name TEXT NOT NULL)";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createDatabase();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            SQLiteConnection con = new SQLiteConnection("Data Source=" + db_name2);
            con.Open();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO users(first_name, last_name) VALUES (@first_name, @last_name)";
                cmd.Parameters.AddWithValue("@first_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a first name.");
                return;
            }

            SQLiteConnection con = new SQLiteConnection("Data Source=" + db_name2);
            con.Open();
            SQLiteDataReader dataReader = null;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT * From users WHERE first_name = @first_name";
                cmd.Parameters.AddWithValue("@first_name", textBox1.Text);
                dataReader = cmd.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("Not Found");
                    return;
                }

                dataReader.Read();
                string lastName = dataReader.GetString(1);
                MessageBox.Show("LastName: " + lastName);

                dataReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
