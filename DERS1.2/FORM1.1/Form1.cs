namespace FORM1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtDimension.Text.Contains("x"))
                {
                    //120x144
                    string strDimension = txtDimension.Text;
                    int width = int.Parse(strDimension.Substring(0, strDimension.IndexOf("x")));
                    int height = int.Parse(strDimension.Substring(strDimension.IndexOf("x") + 1));
                    Debug.WriteLine("Width:" + width);
                    Debug.WriteLine("Height:" + height);
                    ClientSize = new Size(width, height);
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Wrong Format";
                }
            }
            catch (Exception exc)
            {
                lblError.Text = exc.Message;
            }

            Debug.WriteLine(txtDimension.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
