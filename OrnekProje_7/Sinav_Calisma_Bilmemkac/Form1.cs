namespace Sinav_Calisma_Bilmemkac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ocak");
            comboBox1.Items.Add("Şubat");
            comboBox1.Items.Add("MArt");
            comboBox1.Items.Add("Nisan");
            comboBox1.Items.Add("Mayis");
            comboBox1.Items.Add("Haziran");
            comboBox1.Items.Add("Temmuz");
            comboBox1.Items.Add("Agustos");
            comboBox1.Items.Add("Eylul");
            comboBox1.Items.Add("Ekim");
            comboBox1.Items.Add("Kasim");
            comboBox1.Items.Add("Aralik");
        }
    }
}
