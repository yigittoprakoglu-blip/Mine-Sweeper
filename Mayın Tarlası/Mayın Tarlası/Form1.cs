namespace Mayın_Tarlası
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameForm frm = new GameForm(9,9,10,45);
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameForm frm = new GameForm(12, 12, 25,40);
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameForm frm = new GameForm(16, 16, 40,40);
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Oyuncu ilk olarak bir hücreye tıklayarak oyunu başlatır; boş alanlar otomatik olarak açılır.\r\n\r\nAçılan hücrelerdeki sayılar, etrafında kaç mayın olduğunu gösterir ve oyuncu bu sayılara göre mantık yürütür.\r\n\r\nGüvenli olduğunu düşündüğü hücrelere sol tık ile tıklar, mayın olduğunu düşündüğü hücrelere sağ tık ile bayrak koyar.\r\n\r\nTüm mayın olmayan hücreler açıldığında oyun kazanılır.\r\n\r\nEğer oyuncu bir mayına tıklarsa oyun hemen kaybedilir.";
            MessageBox.Show(message);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
