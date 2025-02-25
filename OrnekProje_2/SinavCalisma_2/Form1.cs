using System.Data.SQLite;

namespace SinavCalisma_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createDatabase();
            startListView();
            fillListView();
        }

        public class User
        {
            public int id;
            public string first_name;
            public string last_name;

            public User(int id, string first_name, string last_name)
            {
                this.id = id;
                this.first_name = first_name;
                this.last_name = last_name;
            }



            public User(SQLiteDataReader dataReader)
            {
                try
                {
                    id = dataReader.GetInt32(0);
                    first_name = dataReader.GetString(1);
                    last_name = dataReader.GetString(2);

                }
                catch (Exception exc)
                {
                    System.Windows.Forms.MessageBox.Show("Invalid DataReader");
                }
            }

            public ListViewItem convertToListViewItem()
            {
                ListViewItem item = new ListViewItem(id.ToString());
                item.SubItems.Add(first_name);
                item.SubItems.Add(last_name);
                return item;
            }

        }

        Func<SQLiteConnection> getConnection = () => new SQLiteConnection("Data Source = user.db");
        string dbFileName = "user.db";
        string tableName = "users";
        public void createDatabase()
        {
            if (!File.Exists(dbFileName))
            {
                try
                {
                    SQLiteConnection.CreateFile(dbFileName);
                    using (SQLiteConnection con = getConnection())
                    {

                        con.Open();
                        string sqlCreateTable = $"create table if not exists {tableName}(id integer primary key, first_name text, last_name text)";
                        SQLiteCommand cmd = new SQLiteCommand(sqlCreateTable, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
        public void startListView()
        {

            //sütunları listView'e ekle
            string[] columns = { "ID", "First Name", "Last Name" };
            Array.ForEach(columns, c => listView1.Columns.Add(c));

            //Sütunların gösterilmesini sağla
            listView1.View = View.Details;

            //Her sütunun genişliğini 100 yap.
            foreach (ColumnHeader c in listView1.Columns)
                c.Width = 100;
        }
        public void fillListView()
        {
            listView1.Items.Clear();
            using (SQLiteConnection con = getConnection())
            {

                con.Open();


                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = $"select * from {tableName}";
                cmd.Connection = con;
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("No record of any user.");
                    dataReader.Close();
                    con.Close();
                    return;
                }

                while (dataReader.Read())
                {
                    User user = new User(dataReader);
                    ListViewItem item = user.convertToListViewItem();
                    listView1.Items.Add(item);
                }

                dataReader.Close();
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
                return;


            using (SQLiteConnection con = getConnection())
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                cmd.CommandText = $"insert into {tableName}(first_name,last_name) values(@firstName,@lastName)";
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                fillListView();
                MessageBox.Show("User Successfully Saved.");
                txtFirstName.Clear();
                txtLastName.Clear();
                txtFirstName.Focus();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
                return;
            using (SQLiteConnection con = getConnection())
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from {tableName} where first_name='{txtFirstName.Text}'";

                SQLiteDataReader dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    MessageBox.Show("There are no users with such a name");
                    dataReader.Close();
                    con.Close();
                    return;
                }

                dataReader.Read();//Önce İmleci o satırın üzerine getiriyoruz.
                User user = new User(dataReader);
                txtLastName.Text = user.last_name;

                dataReader.Close();
                con.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
                return;

            int selectedId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);//
            using (SQLiteConnection con = getConnection())
            {

                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = $"delete from {tableName} where id=@id";
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User is removed");
                fillListView();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0 ||
        string.IsNullOrEmpty(txtFirstName.Text) ||
        string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please select a user and fill in the necessary fields.");
                return;
            }

            int selectedId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); // Seçilen kullanıcının ID'si
            using (SQLiteConnection con = getConnection())
            {
                try
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = $"update {tableName} set first_name = @firstName, last_name = @lastName where id = @id";
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully updated.");
                    fillListView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error while updating user: " + exc.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }
    }
}
