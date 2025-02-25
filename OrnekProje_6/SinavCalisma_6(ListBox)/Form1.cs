namespace SinavCalisma_6_ListBox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            int age = int.Parse(textBox3.Text.ToString());

            listBox1.Items.Add(firstname + lastname + age);
                
            
        }
    }
}
