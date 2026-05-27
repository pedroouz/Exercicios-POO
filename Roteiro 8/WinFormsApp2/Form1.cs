using System.Runtime.InteropServices;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maximizar.Visible = false; // Adicione esta linha para esconder o botão maximizar quando a tela estiver cheia
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }
        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3>();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form5>();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
