using System.Data.SQLite;
using System.Drawing;

namespace SinavCalisma1
{
    public partial class Form1 : Form
    {
        string dbFileName = "vp.db";
        public Form1()
        {
            InitializeComponent(); // Bileşenleri başlatır
            getNumbersFromDatabase(); // Veritabanından verileri alır ve ListBox'a ekler
        }

        private void createDatabase()
        {
            if (!File.Exists(dbFileName)) // Eğer veritabanı dosyası yoksa
            {
                try
                {
                    
                    SQLiteConnection.CreateFile(dbFileName); // Veritabanı dosyası yoksa sıfırdan oluştur
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + dbFileName))
                    {
                        connection.Open(); // Veritabanı bağlantısını aç
                        string queryText = "CREATE TABLE IF NOT EXISTS first_table(number1 INTEGER NOT NULL)";
                        SQLiteCommand cmd = new SQLiteCommand(queryText, connection);
                        cmd.ExecuteNonQuery(); // Sorgunun çalıştırılmasını sağlar
                        connection.Close(); // Bağlantıyı kapat
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show("Hata Meydana Geldi: " + exc.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createDatabase(); // Form yüklendiğinde veritabanını oluştur
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myNumber;
            //Kullanıcının girdiği değeri txtNumber TextBox'tan alır ve int türüne dönüştürür.
            //Dönüştürülemezse uyarı gösterir.
            myNumber = txtNumber.Text;
            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFileName))
            {
                try
                {
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = $"INSERT INTO first_table(number1) values({myNumber})";  // Veriyi ekler
                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    con.Close();        
                    txtNumber.Clear();     // TextBox'ı temizler
                    txtNumber.Focus();     // TextBox'a odaklar
                    MessageBox.Show("Inserted!!"); 
                    getNumbersFromDatabase();    // Veritabanından verileri tekrar alır
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error : " + exc.Message);
                }
            }
        }
        private void getNumbersFromDatabase()
        {
            lstNumbers.Items.Clear(); //Listbox'ta var olan sayıları temizliyoruz.
            using (SQLiteConnection con = new SQLiteConnection($"Data Source = {dbFileName}"))
            {
                try
                {
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = "SELECT * FROM first_table";   // Verileri seç
                    cmd.Connection = con;
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    if (!dataReader.HasRows)
                    {
                        MessageBox.Show("We don't have any numbers");
                        dataReader.Close();//önce datareader'ı kapatırız. Sonra sqliteConnection nesnesini
                        con.Close();
                        return;
                    }
                    while (dataReader.Read())
                    {
                        int number1 = dataReader.GetInt32(0);//0. sütunu int tipinden bir veri olarak getir.
                        lstNumbers.Items.Add(number1); // ListBox'a ekler
                    }
                    con.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedItem == null) //Listbox'ta seçilen bir eleman yoksa bir şey yapmadan dön.
                return;

            int selectedNumber;//ListBox'ta seçilen sayıyı buraya atacağız.
            if (!int.TryParse(lstNumbers.SelectedItem.ToString(), out selectedNumber))
            {
                MessageBox.Show("Invalid Selected Item");
                return;
            }
            try
            {
                using (SQLiteConnection con = new SQLiteConnection($"Data Source = {dbFileName}"))
                {

                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "delete from first_table where number1=@number1";
                    cmd.Parameters.AddWithValue("number1", selectedNumber);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                //Listbox'tan silindiğine emin olduğumuz bu sayıyı kaldıralım. Tüm verileri çekip göstermek efektif bir yöntem değildir. 
                //Çünkü her seferinde database'e bağlantı oluşturup tüm satırları çekmek gereksiz yük bindirir sistemlere. Bunun yerine zaten silindiğini bildiğimiz veriyi listbox'tan silelim. Böylece tüm güncel verileri çekmemize gerek kalmaz.
                lstNumbers.Items.Remove(lstNumbers.SelectedItem);

                //eğer buraya kadar gelindiyse seçilen sayı veritabanından silinmiştir.
                MessageBox.Show(selectedNumber + " is removed from db");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedItem == null) // ListBox'ta seçili bir eleman yoksa bir şey yapmadan dön
            {
                MessageBox.Show("Lütfen güncellemek için bir sayı seçin!");
                return;
            }

            int selectedNumber; // ListBox'ta seçilen sayıyı buraya atayacağız
            if (!int.TryParse(lstNumbers.SelectedItem.ToString(), out selectedNumber))
            {
                MessageBox.Show("Geçersiz bir öğe seçildi!");
                return;
            }

            string newNumberText = txtNumber.Text; // Yeni sayı TextBox'tan alınır
            int newNumber;
            if (!int.TryParse(newNumberText, out newNumber)) // Yeni girilen değerin sayı olup olmadığını kontrol et
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
                return;
            }
            try
            {
                using (SQLiteConnection con = new SQLiteConnection($"Data Source={dbFileName}"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "UPDATE first_table SET number1=@newNumber WHERE number1=@selectedNumber";
                    cmd.Parameters.AddWithValue("@newNumber", newNumber);
                    cmd.Parameters.AddWithValue("@selectedNumber", selectedNumber);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                // Güncellemeden sonra ListBox'ta eski değeri yeni değerle değiştir
                int selectedIndex = lstNumbers.SelectedIndex;
                lstNumbers.Items[selectedIndex] = newNumber;

                MessageBox.Show($"{selectedNumber} değeri {newNumber} olarak güncellendi!");
                txtNumber.Clear();
                txtNumber.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Hata: " + exc.Message);
            }

        }
    }
}
    