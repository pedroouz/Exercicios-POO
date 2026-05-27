namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Restaurar = new Button();
            Maximizar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            btnFornecedores = new Button();
            btnProdutos = new Button();
            btnVendas = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(Restaurar);
            panel1.Controls.Add(Maximizar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 141);
            panel1.TabIndex = 0;
            panel1.MouseMove += panel1_MouseDown;
            // 
            // Restaurar
            // 
            Restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Restaurar.FlatAppearance.BorderSize = 0;
            Restaurar.FlatStyle = FlatStyle.Flat;
            Restaurar.Location = new Point(506, 59);
            Restaurar.Name = "Restaurar";
            Restaurar.Size = new Size(75, 23);
            Restaurar.TabIndex = 3;
            Restaurar.Text = "Restaurar";
            Restaurar.UseVisualStyleBackColor = true;
            // 
            // Maximizar
            // 
            Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximizar.FlatAppearance.BorderSize = 0;
            Maximizar.FlatStyle = FlatStyle.Flat;
            Maximizar.Location = new Point(587, 59);
            Maximizar.Name = "Maximizar";
            Maximizar.Size = new Size(75, 23);
            Maximizar.TabIndex = 2;
            Maximizar.Text = "Maximizar";
            Maximizar.UseVisualStyleBackColor = true;
            Maximizar.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateBlue;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(53, 45);
            label1.Name = "label1";
            label1.Size = new Size(320, 56);
            label1.TabIndex = 1;
            label1.Text = "Meu Sistema";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(685, 45);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 0;
            button1.Text = "\"\"";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.Controls.Add(btnVendas);
            panel3.Controls.Add(btnProdutos);
            panel3.Controls.Add(btnFornecedores);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(0, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 306);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkSlateBlue;
            button2.Location = new Point(0, -3);
            button2.Name = "button2";
            button2.Size = new Size(200, 58);
            button2.TabIndex = 0;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnFornecedores
            // 
            btnFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFornecedores.BackColor = SystemColors.Info;
            btnFornecedores.FlatAppearance.BorderSize = 0;
            btnFornecedores.FlatStyle = FlatStyle.Flat;
            btnFornecedores.ForeColor = Color.Black;
            btnFornecedores.Location = new Point(-3, 48);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Size = new Size(203, 49);
            btnFornecedores.TabIndex = 1;
            btnFornecedores.Text = "Fornecedores";
            btnFornecedores.UseVisualStyleBackColor = false;
            btnFornecedores.Click += button3_Click_1;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.SeaGreen;
            btnProdutos.ForeColor = SystemColors.InactiveCaptionText;
            btnProdutos.Location = new Point(0, 93);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(200, 54);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.SeaGreen;
            btnVendas.ForeColor = Color.WhiteSmoke;
            btnVendas.Location = new Point(3, 142);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(194, 57);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 445);
            Controls.Add(panel3);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button Maximizar;
        private Button Restaurar;
        private Button btnFornecedores;
        private Button btnVendas;
        private Button btnProdutos;
    }
}
