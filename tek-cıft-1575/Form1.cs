namespace tek_cıft_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
                MessageBox.Show("Girilen Sayı Çift Sayıdır");
            else
                MessageBox.Show("Girilen Sayı Tek Sayıdır");
        }
    }
}