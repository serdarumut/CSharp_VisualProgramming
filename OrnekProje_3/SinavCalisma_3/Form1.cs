namespace SinavCalisma_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float d1, d2, d3, toplam;

            d1 = int.Parse(textBox1.Text);
            d2 = int.Parse(textBox2.Text);
            d3 = int.Parse(textBox3.Text);

            toplam = d1 + d2 + d3;

            float pd1, pd2, pd3;

            pd1 = (d1 / toplam * 360);
            pd2 = (d2 / toplam * 360);
            pd3 = (d3 / toplam * 360);

            Pen p = new Pen(Color.White, 4);

            Graphics g = this.CreateGraphics();

            Rectangle rec = new Rectangle (textBox1.Location.X + textBox1.Size.Width+10,10,250,260);

            Brush b1 = new SolidBrush(Color.Orange);
            Brush b2 = new SolidBrush (Color.Blue);
            Brush b3 = new SolidBrush (Color.Red);

            g.Clear(Form1.DefaultBackColor);
            g.DrawPie(p, rec, 0, pd1);
            g.FillPie(b1, rec, 0, pd1);

            g.DrawPie(p, rec, pd1, pd2);
            g.FillPie(b2, rec, pd1, pd2);

            g.DrawPie (p, rec, pd1 + pd2, pd3);
            g.FillPie (b3, rec, pd1 +pd2, pd3);
        
        }
    }
}
