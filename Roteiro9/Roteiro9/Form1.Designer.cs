namespace Roteiro9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            progressBar1 = new ProgressBar();
            btnIniciar = new Button();
            tabPage2 = new TabPage();
            textName = new TextBox();
            btnSalvar = new Button();
            btnFoto1 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            picFoto1 = new PictureBox();
            comboCargo = new ComboBox();
            textEmail = new TextBox();
            maskedCPF = new MaskedTextBox();
            tabPage3 = new TabPage();
            btnRemoveTask = new Button();
            btnAddTask = new Button();
            txtNovaTarefa = new TextBox();
            listTarefas = new ListBox();
            dgvProdutos = new DataGridView();
            tabPage4 = new TabPage();
            btnFinalizar = new Button();
            groupBox1 = new GroupBox();
            rbDinheiro = new RadioButton();
            rbCartao = new RadioButton();
            rbPix = new RadioButton();
            chkBackup = new CheckBox();
            chkNotificacao = new CheckBox();
            chkModoEscuro = new CheckBox();
            chkEmail = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            tabPage4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(817, 466);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(btnIniciar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(809, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(356, 244);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(370, 215);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textName);
            tabPage2.Controls.Add(btnSalvar);
            tabPage2.Controls.Add(btnFoto1);
            tabPage2.Controls.Add(maskedTextBox2);
            tabPage2.Controls.Add(picFoto1);
            tabPage2.Controls.Add(comboCargo);
            tabPage2.Controls.Add(textEmail);
            tabPage2.Controls.Add(maskedCPF);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(809, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            textName.Location = new Point(306, 62);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 7;
            textName.Text = "Nome";
            textName.TextChanged += textName_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(331, 173);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar ";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFoto1
            // 
            btnFoto1.Location = new Point(212, 134);
            btnFoto1.Name = "btnFoto1";
            btnFoto1.Size = new Size(75, 23);
            btnFoto1.TabIndex = 5;
            btnFoto1.Text = "Trocar Foto";
            btnFoto1.UseVisualStyleBackColor = true;
            btnFoto1.Click += btnFoto1_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(306, 105);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 4;
            // 
            // picFoto1
            // 
            picFoto1.Location = new Point(200, 62);
            picFoto1.Name = "picFoto1";
            picFoto1.Size = new Size(100, 66);
            picFoto1.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto1.TabIndex = 3;
            picFoto1.TabStop = false;
            // 
            // comboCargo
            // 
            comboCargo.FormattingEnabled = true;
            comboCargo.Location = new Point(200, 173);
            comboCargo.Name = "comboCargo";
            comboCargo.Size = new Size(121, 23);
            comboCargo.TabIndex = 2;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(412, 62);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 1;
            textEmail.Text = "Email";
            // 
            // maskedCPF
            // 
            maskedCPF.Location = new Point(412, 105);
            maskedCPF.Mask = "000.000.000-00";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(100, 23);
            maskedCPF.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnRemoveTask);
            tabPage3.Controls.Add(btnAddTask);
            tabPage3.Controls.Add(txtNovaTarefa);
            tabPage3.Controls.Add(listTarefas);
            tabPage3.Controls.Add(dgvProdutos);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(809, 438);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(595, 83);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(101, 23);
            btnRemoveTask.TabIndex = 4;
            btnRemoveTask.Text = "Remover tarefa";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(595, 54);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(101, 23);
            btnAddTask.TabIndex = 3;
            btnAddTask.Text = "Adicionar tarefa";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // txtNovaTarefa
            // 
            txtNovaTarefa.Location = new Point(428, 55);
            txtNovaTarefa.Name = "txtNovaTarefa";
            txtNovaTarefa.Size = new Size(161, 23);
            txtNovaTarefa.TabIndex = 2;
            // 
            // listTarefas
            // 
            listTarefas.FormattingEnabled = true;
            listTarefas.Location = new Point(410, 21);
            listTarefas.Name = "listTarefas";
            listTarefas.Size = new Size(298, 319);
            listTarefas.TabIndex = 1;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(41, 21);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(324, 319);
            dgvProdutos.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnFinalizar);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Controls.Add(chkBackup);
            tabPage4.Controls.Add(chkNotificacao);
            tabPage4.Controls.Add(chkModoEscuro);
            tabPage4.Controls.Add(chkEmail);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(809, 438);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(334, 230);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 3;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDinheiro);
            groupBox1.Controls.Add(rbCartao);
            groupBox1.Controls.Add(rbPix);
            groupBox1.Location = new Point(208, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 151);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de pagamento padrão";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbDinheiro
            // 
            rbDinheiro.AutoSize = true;
            rbDinheiro.Location = new Point(3, 76);
            rbDinheiro.Name = "rbDinheiro";
            rbDinheiro.Size = new Size(70, 19);
            rbDinheiro.TabIndex = 2;
            rbDinheiro.TabStop = true;
            rbDinheiro.Text = "Dinheiro";
            rbDinheiro.UseVisualStyleBackColor = true;
            rbDinheiro.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rbCartao
            // 
            rbCartao.AutoSize = true;
            rbCartao.Location = new Point(0, 51);
            rbCartao.Name = "rbCartao";
            rbCartao.Size = new Size(60, 19);
            rbCartao.TabIndex = 1;
            rbCartao.TabStop = true;
            rbCartao.Text = "Cartão";
            rbCartao.UseVisualStyleBackColor = true;
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(3, 19);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(40, 19);
            rbPix.TabIndex = 0;
            rbPix.TabStop = true;
            rbPix.Text = "Pix";
            rbPix.UseVisualStyleBackColor = true;
            // 
            // chkBackup
            // 
            chkBackup.AutoSize = true;
            chkBackup.Location = new Point(16, 126);
            chkBackup.Name = "chkBackup";
            chkBackup.Size = new Size(131, 19);
            chkBackup.TabIndex = 3;
            chkBackup.Text = "Backup Automático";
            chkBackup.UseVisualStyleBackColor = true;
            // 
            // chkNotificacao
            // 
            chkNotificacao.AutoSize = true;
            chkNotificacao.Location = new Point(16, 101);
            chkNotificacao.Name = "chkNotificacao";
            chkNotificacao.Size = new Size(126, 19);
            chkNotificacao.TabIndex = 2;
            chkNotificacao.Text = "Ativar Notificações";
            chkNotificacao.UseVisualStyleBackColor = true;
            // 
            // chkModoEscuro
            // 
            chkModoEscuro.AutoSize = true;
            chkModoEscuro.Location = new Point(16, 76);
            chkModoEscuro.Name = "chkModoEscuro";
            chkModoEscuro.Size = new Size(96, 19);
            chkModoEscuro.TabIndex = 1;
            chkModoEscuro.Text = "Modo Escuro";
            chkModoEscuro.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            chkEmail.AutoSize = true;
            chkEmail.Location = new Point(16, 51);
            chkEmail.Name = "chkEmail";
            chkEmail.Size = new Size(110, 19);
            chkEmail.TabIndex = 0;
            chkEmail.Text = "Receber e-mails";
            chkEmail.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 460);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ProgressBar progressBar1;
        private Button btnIniciar;
        private TabPage tabPage2;
        private MaskedTextBox maskedTextBox2;
        private PictureBox picFoto1;
        private ComboBox comboCargo;
        private TextBox textEmail;
        private MaskedTextBox maskedCPF;
        private OpenFileDialog openFileDialog1;
        private Button btnFoto1;
        private TextBox textName;
        private Button btnSalvar;
        private TabPage tabPage3;
        private ListBox listTarefas;
        private DataGridView dgvProdutos;
        private TextBox txtNovaTarefa;
        private Button btnAddTask;
        private Button btnRemoveTask;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private CheckBox chkBackup;
        private CheckBox chkNotificacao;
        private CheckBox chkModoEscuro;
        private CheckBox chkEmail;
        private RadioButton rbDinheiro;
        private RadioButton rbCartao;
        private RadioButton rbPix;
        private Button btnFinalizar;
    }
}
