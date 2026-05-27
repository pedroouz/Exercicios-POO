namespace Roteiro9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 10; i++)
            {
                progressBar1.Value += 10;
                System.Threading.Thread.Sleep(50);
            }
            MessageBox.Show("Sistema carregado com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboCargo.Items.Add("Desenvolvedor");
            comboCargo.Items.Add("Designer");
            comboCargo.Items.Add("Suporte");
            comboCargo.Items.Add("Gerente");

            dgvProdutos.Columns.Add("codigo", "Código");
            dgvProdutos.Columns.Add("produto", "Produto");
            dgvProdutos.Columns.Add("preco", "Preço");

            dgvProdutos.Rows.Add("001", "Mouse Gamer", "R$ 150,00");
            dgvProdutos.Rows.Add("002", "Teclado Mecânico", "R$ 350,00");
            dgvProdutos.Rows.Add("003", "Monitor 24'", "R$ 890,00");
        }

        private void btnFoto1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picFoto1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string dados = $"Nome: {textName.Text}\n" + $"CPF: {maskedCPF.Text}\n" + $"Cargo: {comboCargo.Text}";

            MessageBox.Show(dados, "Funcionário Salvo!");
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNovaTarefa.Text))
            {
                listTarefas.Items.Add(txtNovaTarefa.Text);

                txtNovaTarefa.Clear();
                txtNovaTarefa.Focus();
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listTarefas.SelectedItem != null)
            {
                listTarefas.Items.Remove(listTarefas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa da lista para remover!", "Atenção");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            {
                string resumoPref = "--- Preferências Selecionadas ---\n";

                if (chkEmail.Checked) resumoPref += "- Aceitou receber e-mails.\n";
                if (chkModoEscuro.Checked) resumoPref += "- Optou pelo Modo Escuro.\n";
                if (chkNotificacao.Checked) resumoPref += "- Notificações ativas.\n";
                if (chkBackup.Checked) resumoPref += "- Backup em nuvem ativado.\n";

                resumoPref += "\n--- Método de Pagamento Padrão ---\n";

                if (rbPix.Checked)
                {
                    resumoPref += "Método selecionado: PIX\n";
                }
                else if (rbCartao.Checked)
                {
                    resumoPref += "Método selecionado: Cartão de Crédito/Débito\n";
                }
                else if (rbDinheiro.Checked)
                {
                    resumoPref += "Método selecionado: Dinheiro Espécie\n";
                }
                else
                {
                    resumoPref += "Nenhum método selecionado.\n";
                }

                MessageBox.Show(resumoPref, "Configurações do Sistema");
            }
        }
    }
}
