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
            tabPage2 = new TabPage();
            panel1 = new Panel();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioAtivoNao = new RadioButton();
            radioAtivoSim = new RadioButton();
            btnBuscaMunici = new Button();
            textCodFormaPag = new TextBox();
            label7 = new Label();
            textFormaPagamento = new TextBox();
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
            tabPage1 = new TabPage();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            groupBox3 = new GroupBox();
            checkBoxTodos = new CheckBox();
            textDadosPesquisa = new TextBox();
            btnPesquisar = new Button();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label9 = new Label();
            comboFiltros = new ComboBox();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            NumeroParcela = new DataGridViewTextBoxColumn();
            IntervaloParcela = new DataGridViewTextBoxColumn();
            PercentualJuro = new DataGridViewTextBoxColumn();
            Desconto = new DataGridViewTextBoxColumn();
            FormaPagamento = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textIntervalo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textParcela).BeginInit();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnCancelar);
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
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(191, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 40);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar F6";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnBuscaMunici);
            groupBox1.Controls.Add(textCodFormaPag);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textFormaPagamento);
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
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(radioAtivoNao);
            groupBox2.Controls.Add(radioAtivoSim);
            groupBox2.Font = new Font("Arial", 9.75F);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(648, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 52);
            groupBox2.TabIndex = 69;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ativo ?";
            // 
            // radioAtivoNao
            // 
            radioAtivoNao.Enabled = false;
            radioAtivoNao.Location = new Point(66, 19);
            radioAtivoNao.Name = "radioAtivoNao";
            radioAtivoNao.Size = new Size(53, 22);
            radioAtivoNao.TabIndex = 4;
            radioAtivoNao.TabStop = true;
            radioAtivoNao.Text = "Não";
            radioAtivoNao.UseVisualStyleBackColor = true;
            // 
            // radioAtivoSim
            // 
            radioAtivoSim.Enabled = false;
            radioAtivoSim.Location = new Point(6, 18);
            radioAtivoSim.Name = "radioAtivoSim";
            radioAtivoSim.Size = new Size(54, 24);
            radioAtivoSim.TabIndex = 3;
            radioAtivoSim.TabStop = true;
            radioAtivoSim.Text = "Sim";
            radioAtivoSim.UseVisualStyleBackColor = true;
            // 
            // btnBuscaMunici
            // 
            btnBuscaMunici.BackColor = Color.Transparent;
            btnBuscaMunici.Enabled = false;
            btnBuscaMunici.FlatAppearance.BorderSize = 0;
            btnBuscaMunici.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaMunici.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaMunici.FlatStyle = FlatStyle.Flat;
            btnBuscaMunici.Image = Properties.Resources.lupa;
            btnBuscaMunici.Location = new Point(615, 87);
            btnBuscaMunici.Name = "btnBuscaMunici";
            btnBuscaMunici.Size = new Size(27, 23);
            btnBuscaMunici.TabIndex = 68;
            btnBuscaMunici.UseVisualStyleBackColor = false;
            // 
            // textCodFormaPag
            // 
            textCodFormaPag.Location = new Point(285, 88);
            textCodFormaPag.Name = "textCodFormaPag";
            textCodFormaPag.ReadOnly = true;
            textCodFormaPag.Size = new Size(64, 23);
            textCodFormaPag.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(285, 68);
            label7.Name = "label7";
            label7.Size = new Size(47, 16);
            label7.TabIndex = 66;
            label7.Text = "Codigo";
            // 
            // textFormaPagamento
            // 
            textFormaPagamento.Location = new Point(355, 88);
            textFormaPagamento.Name = "textFormaPagamento";
            textFormaPagamento.ReadOnly = true;
            textFormaPagamento.Size = new Size(257, 23);
            textFormaPagamento.TabIndex = 65;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(355, 68);
            label8.Name = "label8";
            label8.Size = new Size(196, 16);
            label8.TabIndex = 64;
            label8.Text = "Forma de Pagamento Associada";
            // 
            // textDesconto
            // 
            textDesconto.Location = new Point(144, 88);
            textDesconto.Name = "textDesconto";
            textDesconto.ReadOnly = true;
            textDesconto.Size = new Size(135, 23);
            textDesconto.TabIndex = 63;
            textDesconto.Text = "0,00";
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
            textJuro.ReadOnly = true;
            textJuro.Size = new Size(135, 23);
            textJuro.TabIndex = 61;
            textJuro.Text = "0,00";
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
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Consultas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 257);
            panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, NumeroParcela, IntervaloParcela, PercentualJuro, Desconto, FormaPagamento, Ativo });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(786, 264);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnExcluir);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 363);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 56);
            panel3.TabIndex = 6;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.novo;
            btnEditar.Location = new Point(139, 11);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.lixeira;
            btnExcluir.Location = new Point(4, 11);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxTodos);
            groupBox3.Controls.Add(textDadosPesquisa);
            groupBox3.Controls.Add(btnPesquisar);
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
            groupBox3.Resize += groupBox3_Resize;
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(713, 10);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(374, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(397, 23);
            textDadosPesquisa.TabIndex = 24;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(658, 64);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(113, 29);
            btnPesquisar.TabIndex = 26;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
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
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 300;
            // 
            // NumeroParcela
            // 
            NumeroParcela.HeaderText = "N. Pacelas";
            NumeroParcela.Name = "NumeroParcela";
            NumeroParcela.ReadOnly = true;
            NumeroParcela.Width = 200;
            // 
            // IntervaloParcela
            // 
            IntervaloParcela.HeaderText = "Intervalo Parcela";
            IntervaloParcela.Name = "IntervaloParcela";
            IntervaloParcela.ReadOnly = true;
            IntervaloParcela.Width = 200;
            // 
            // PercentualJuro
            // 
            PercentualJuro.HeaderText = "Percentual Juros";
            PercentualJuro.Name = "PercentualJuro";
            PercentualJuro.ReadOnly = true;
            PercentualJuro.Width = 200;
            // 
            // Desconto
            // 
            Desconto.HeaderText = "Desconto";
            Desconto.Name = "Desconto";
            Desconto.ReadOnly = true;
            Desconto.Width = 200;
            // 
            // FormaPagamento
            // 
            FormaPagamento.HeaderText = "FormaPagamento";
            FormaPagamento.Name = "FormaPagamento";
            FormaPagamento.ReadOnly = true;
            FormaPagamento.Width = 300;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo ?";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            // 
            // CadastrarCondicaoPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarCondicaoPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Condição Pagamento";
            KeyDown += CadastrarCondicaoPagamento_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textIntervalo).EndInit();
            ((System.ComponentModel.ISupportInitialize)textParcela).EndInit();
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
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
        private TextBox textCodFormaPag;
        private Label label7;
        private TextBox textFormaPagamento;
        private Label label8;
        private Button btnBuscaMunici;
        private GroupBox groupBox2;
        private RadioButton radioAtivoNao;
        private RadioButton radioAtivoSim;
        private Panel panel1;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnGravar;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private CheckBox checkBoxTodos;
        private TextBox textDadosPesquisa;
        private Button btnPesquisar;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label9;
        private ComboBox comboFiltros;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn NumeroParcela;
        private DataGridViewTextBoxColumn IntervaloParcela;
        private DataGridViewTextBoxColumn PercentualJuro;
        private DataGridViewTextBoxColumn Desconto;
        private DataGridViewTextBoxColumn FormaPagamento;
        private DataGridViewCheckBoxColumn Ativo;
    }
}