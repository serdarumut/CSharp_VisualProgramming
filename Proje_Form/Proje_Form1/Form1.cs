using System.Diagnostics.Metrics;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Proje_Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1350;

        }

        double duration = 15; // Bu yakalamaca maksimum 15 saniye sürsün istiyoruz.
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            //Interval*counter / 1000 kaç saniye sürdüğünü verir. Eğer duration'a eşitse uygulamayı sonlandırıyoruz.
            double elapsedTime = (timer1.Interval * counter) / 1000;
            if (elapsedTime >= duration)
            {
                timer1.Stop();
                MessageBox.Show("Süre Doldu ve Yakalayamadın Beni");
            }
            else
            {
                Random rnd = new Random();
                //butonun konumunu x ve y ekseninde ayrı ayrı belirliyoruz. X eksenindeki konumunu 0 ve Formun Genişlik
                //değeri arasında rastgele bir değer üreterek belirliyoruz. Aynı şekilde Butonun Y eksenindeki konumunu
                //da yine 0 ve FormunYükseklik değeri arasında rastgele bir değer üretere bulabiliriz
                button1.Location = new Point(rnd.Next(0, ClientSize.Width), rnd.Next(0, ClientSize.Height));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Butona tıklayabilirsek timer'ı durduruyoruz.
            MessageBox.Show("Başarılı! Yakaladın Beni!");
        }
    }
}
