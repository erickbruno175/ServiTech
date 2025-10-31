namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarCondicaoPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCondicaoPagamento));
            tabControl1 = new TabControl();
            tabCadastros = new TabPage();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            comboFormasPagamento = new ComboBox();
            groupBox2 = new GroupBox();
            checkAtivo = new CheckBox();
            label8 = new Label();
            textDesconto = new TextBox();
            label6 = new Label();
            textJuro = new TextBox();
            label5 = new Label();
            label3 = new Label();
            textIntervalo = new NumericUpDown();
            label1 = new Label();
            textParcela = new NumericUpDown();
            textCod = new TextBox();
            label4 = new Label();
            textNome = new TextBox();
            label2 = new Label();
            tabConsultas = new TabPage();
            panel2 = new Panel();
            dataCondicoesPagamento = new DataGridView();
            panel3 = new Panel();
            bntNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            groupBox3 = new GroupBox();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label9 = new Label();
            comboFiltros = new ComboBox();
            label45 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabCadastros.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textIntervalo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textParcela).BeginInit();
            tabConsultas.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCondicoesPagamento).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCadastros);
            tabControl1.Controls.Add(tabConsultas);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabCadastros
            // 
            tabCadastros.Controls.Add(panel1);
            tabCadastros.Controls.Add(groupBox1);
            tabCadastros.Location = new Point(4, 24);
            tabCadastros.Name = "tabCadastros";
            tabCadastros.Padding = new Padding(3);
            tabCadastros.Size = new Size(792, 422);
            tabCadastros.TabIndex = 1;
            tabCadastros.Text = "Cadastro";
            tabCadastros.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 58);
            panel1.TabIndex = 2;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(3, 8);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 40);
            btnNovo.TabIndex = 18;
            btnNovo.Text = "Incluir F4";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGravar
            // 
            btnGravar.Image = Properties.Resources.salvar;
            btnGravar.Location = new Point(97, 8);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 40);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label45);
            groupBox1.Controls.Add(comboFormasPagamento);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textDesconto);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textJuro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textIntervalo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textParcela);
            groupBox1.Controls.Add(textCod);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // comboFormasPagamento
            // 
            comboFormasPagamento.Enabled = false;
            comboFormasPagamento.FormattingEnabled = true;
            comboFormasPagamento.Location = new Point(285, 87);
            comboFormasPagamento.Name = "comboFormasPagamento";
            comboFormasPagamento.Size = new Size(289, 23);
            comboFormasPagamento.TabIndex = 70;
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(checkAtivo);
            groupBox2.Font = new Font("Arial", 9.75F);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(580, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(89, 52);
            groupBox2.TabIndex = 69;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ativo ?";
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Location = new Point(6, 21);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(54, 20);
            checkAtivo.TabIndex = 0;
            checkAtivo.Text = "Ativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(285, 68);
            label8.Name = "label8";
            label8.Size = new Size(196, 16);
            label8.TabIndex = 64;
            label8.Text = "Forma de Pagamento Associada";
            // 
            // textDesconto
            // 
            textDesconto.Location = new Point(144, 88);
            textDesconto.Name = "textDesconto";
            textDesconto.PlaceholderText = "0,00";
            textDesconto.ReadOnly = true;
            textDesconto.Size = new Size(135, 23);
            textDesconto.TabIndex = 63;
            textDesconto.TextChanged += textJuro_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(144, 68);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 62;
            label6.Text = "Desconto";
            // 
            // textJuro
            // 
            textJuro.Location = new Point(3, 88);
            textJuro.Name = "textJuro";
            textJuro.PlaceholderText = "0,00";
            textJuro.ReadOnly = true;
            textJuro.Size = new Size(135, 23);
            textJuro.TabIndex = 61;
            textJuro.TextChanged += textJuro_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(3, 68);
            label5.Name = "label5";
            label5.Size = new Size(122, 16);
            label5.TabIndex = 60;
            label5.Text = "Percentual de Juros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(500, 17);
            label3.Name = "label3";
            label3.Size = new Size(142, 16);
            label3.TabIndex = 59;
            label3.Text = "Intervalo entre Parcelas";
            // 
            // textIntervalo
            // 
            textIntervalo.Enabled = false;
            textIntervalo.Location = new Point(500, 37);
            textIntervalo.Name = "textIntervalo";
            textIntervalo.Size = new Size(158, 23);
            textIntervalo.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(336, 16);
            label1.Name = "label1";
            label1.Size = new Size(125, 16);
            label1.TabIndex = 57;
            label1.Text = "Número de Parcelas";
            // 
            // textParcela
            // 
            textParcela.Enabled = false;
            textParcela.Location = new Point(336, 36);
            textParcela.Name = "textParcela";
            textParcela.Size = new Size(158, 23);
            textParcela.TabIndex = 56;
            // 
            // textCod
            // 
            textCod.Location = new Point(3, 36);
            textCod.Name = "textCod";
            textCod.ReadOnly = true;
            textCod.Size = new Size(64, 23);
            textCod.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 54;
            label4.Text = "Codigo";
            // 
            // textNome
            // 
            textNome.Location = new Point(73, 36);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(257, 23);
            textNome.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(73, 16);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 52;
            label2.Text = "Nome";
            // 
            // tabConsultas
            // 
            tabConsultas.Controls.Add(panel2);
            tabConsultas.Controls.Add(panel3);
            tabConsultas.Controls.Add(groupBox3);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3);
            tabConsultas.Size = new Size(792, 422);
            tabConsultas.TabIndex = 2;
            tabConsultas.Text = "Consultas";
            tabConsultas.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataCondicoesPagamento);
            panel2.Location = new Point(3, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 240);
            panel2.TabIndex = 7;
            // 
            // dataCondicoesPagamento
            // 
            dataCondicoesPagamento.BackgroundColor = Color.White;
            dataCondicoesPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCondicoesPagamento.Dock = DockStyle.Fill;
            dataCondicoesPagamento.Location = new Point(0, 0);
            dataCondicoesPagamento.Name = "dataCondicoesPagamento";
            dataCondicoesPagamento.Size = new Size(786, 240);
            dataCondicoesPagamento.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(bntNovo);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnExcluir);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 363);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 56);
            panel3.TabIndex = 6;
            // 
            // bntNovo
            // 
            bntNovo.Image = Properties.Resources.plus;
            bntNovo.Location = new Point(267, 9);
            bntNovo.Name = "bntNovo";
            bntNovo.Size = new Size(101, 40);
            bntNovo.TabIndex = 27;
            bntNovo.Text = " Novo";
            bntNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntNovo.UseVisualStyleBackColor = true;
            bntNovo.Click += bntNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.marca_de_verificacao;
            btnEditar.Location = new Point(141, 9);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Selecionar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.lixeira;
            btnExcluir.Location = new Point(6, 9);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textDadosPesquisa);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(comboModelo);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(comboFiltros);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(786, 103);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Campos de Pesquisa";
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(374, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(397, 23);
            textDadosPesquisa.TabIndex = 24;
            textDadosPesquisa.TextChanged += textDadosPesquisa_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F);
            label16.ForeColor = Color.FromArgb(44, 62, 80);
            label16.Location = new Point(374, 19);
            label16.Name = "label16";
            label16.Size = new Size(117, 16);
            label16.TabIndex = 23;
            label16.Text = "Dados a Pesquisar";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F);
            label17.ForeColor = Color.FromArgb(44, 62, 80);
            label17.Location = new Point(190, 16);
            label17.Name = "label17";
            label17.Size = new Size(122, 16);
            label17.TabIndex = 22;
            label17.Text = "Modelo de Consulta";
            // 
            // comboModelo
            // 
            comboModelo.FormattingEnabled = true;
            comboModelo.Location = new Point(190, 35);
            comboModelo.Name = "comboModelo";
            comboModelo.Size = new Size(178, 23);
            comboModelo.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F);
            label9.ForeColor = Color.FromArgb(44, 62, 80);
            label9.Location = new Point(6, 16);
            label9.Name = "label9";
            label9.Size = new Size(43, 16);
            label9.TabIndex = 20;
            label9.Text = "Filtros";
            // 
            // comboFiltros
            // 
            comboFiltros.FormattingEnabled = true;
            comboFiltros.Location = new Point(6, 35);
            comboFiltros.Name = "comboFiltros";
            comboFiltros.Size = new Size(178, 23);
            comboFiltros.TabIndex = 19;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.ForeColor = Color.FromArgb(192, 0, 0);
            label45.Location = new Point(113, 20);
            label45.Name = "label45";
            label45.Size = new Size(74, 13);
            label45.TabIndex = 276;
            label45.Text = "[Obrigatorio]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(487, 71);
            label7.Name = "label7";
            label7.Size = new Size(74, 13);
            label7.TabIndex = 277;
            label7.Text = "[Obrigatorio]";
            // 
            // CadastrarCondicaoPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "CadastrarCondicaoPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Condição de Pagamento";
            Load += CadastrarCondicaoPagamento_Load;
            KeyDown += CadastrarCondicaoPagamento_KeyDown;
            tabControl1.ResumeLayout(false);
            tabCadastros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textIntervalo).EndInit();
            ((System.ComponentModel.ISupportInitialize)textParcela).EndInit();
            tabConsultas.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataCondicoesPagamento).EndInit();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCadastros;
        private GroupBox groupBox1;
        private TextBox textCod;
        private Label label4;
        private TextBox textNome;
        private Label label2;
        private Label label1;
        private NumericUpDown textParcela;
        private TextBox textDesconto;
        private Label label6;
        private TextBox textJuro;
        private Label label5;
        private Label label3;
        private NumericUpDown textIntervalo;
        private Label label8;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button btnNovo;
        private Button btnGravar;
        private TabPage tabConsultas;
        private GroupBox groupBox3;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label9;
        private ComboBox comboFiltros;
        private Panel panel2;
        private Panel panel3;
        private Button btnExcluir;
        private ComboBox comboFormasPagamento;
        private DataGridView dataCondicoesPagamento;
        private CheckBox checkAtivo;
        private Button btnEditar;
        private Button bntNovo;
        private Label label7;
        private Label label45;
    }
}