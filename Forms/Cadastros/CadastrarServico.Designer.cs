namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarServico
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label9 = new Label();
            textCodIss = new TextBox();
            label7 = new Label();
            button1 = new Button();
            textIss = new TextBox();
            label8 = new Label();
            radioDescontoNao = new GroupBox();
            radioButton1 = new RadioButton();
            radioDescontoSim = new RadioButton();
            textBox1 = new TextBox();
            label5 = new Label();
            btnBuscaCategoria = new Button();
            groupBox3 = new GroupBox();
            radioButtonAtivoNao = new RadioButton();
            radioButtonAtivoSim = new RadioButton();
            textPrecoServico = new TextBox();
            label6 = new Label();
            textCategoriaServico = new TextBox();
            label4 = new Label();
            textDescricao = new TextBox();
            label3 = new Label();
            textNomeServico = new TextBox();
            label10 = new Label();
            textCodigoServico = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            groupBox2 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisarPais = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label2 = new Label();
            comboFiltros = new ComboBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            NomeServico = new DataGridViewTextBoxColumn();
            DescricaoCargo = new DataGridViewTextBoxColumn();
            PrecoServico = new DataGridViewTextBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            UltimaAtualização = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            radioDescontoNao.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(998, 418);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(701, 357);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnNovo);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGravar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(695, 50);
            panel3.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(3, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 40);
            btnNovo.TabIndex = 18;
            btnNovo.Text = "Incluir F4";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(191, 3);
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
            btnGravar.Location = new Point(97, 3);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 40);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textCodIss);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textIss);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(radioDescontoNao);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnBuscaCategoria);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(textPrecoServico);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textCategoriaServico);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textDescricao);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textNomeServico);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textCodigoServico);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(452, 106);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F);
            label9.ForeColor = Color.FromArgb(44, 62, 80);
            label9.Location = new Point(452, 86);
            label9.Name = "label9";
            label9.Size = new Size(109, 16);
            label9.TabIndex = 48;
            label9.Text = "Valor M. de Obrar";
            // 
            // textCodIss
            // 
            textCodIss.Location = new Point(6, 161);
            textCodIss.Name = "textCodIss";
            textCodIss.ReadOnly = true;
            textCodIss.Size = new Size(47, 23);
            textCodIss.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(6, 140);
            label7.Name = "label7";
            label7.Size = new Size(47, 16);
            label7.TabIndex = 46;
            label7.Text = "Codigo";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.lupa;
            button1.Location = new Point(651, 161);
            button1.Name = "button1";
            button1.Size = new Size(30, 23);
            button1.TabIndex = 45;
            button1.UseVisualStyleBackColor = false;
            // 
            // textIss
            // 
            textIss.Location = new Point(59, 161);
            textIss.Name = "textIss";
            textIss.ReadOnly = true;
            textIss.Size = new Size(586, 23);
            textIss.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(76, 142);
            label8.Name = "label8";
            label8.Size = new Size(28, 16);
            label8.TabIndex = 43;
            label8.Text = "ISS";
            // 
            // radioDescontoNao
            // 
            radioDescontoNao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            radioDescontoNao.Controls.Add(radioButton1);
            radioDescontoNao.Controls.Add(radioDescontoSim);
            radioDescontoNao.Font = new Font("Arial", 9.75F);
            radioDescontoNao.ForeColor = Color.FromArgb(44, 62, 80);
            radioDescontoNao.Location = new Point(149, 201);
            radioDescontoNao.Name = "radioDescontoNao";
            radioDescontoNao.Size = new Size(142, 57);
            radioDescontoNao.TabIndex = 42;
            radioDescontoNao.TabStop = false;
            radioDescontoNao.Text = "Aplicar desconto";
            // 
            // radioButton1
            // 
            radioButton1.Enabled = false;
            radioButton1.Location = new Point(66, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 22);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Não";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioDescontoSim
            // 
            radioDescontoSim.Enabled = false;
            radioDescontoSim.Location = new Point(6, 18);
            radioDescontoSim.Name = "radioDescontoSim";
            radioDescontoSim.Size = new Size(54, 24);
            radioDescontoSim.TabIndex = 3;
            radioDescontoSim.TabStop = true;
            radioDescontoSim.Text = "Sim";
            radioDescontoSim.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 106);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(47, 23);
            textBox1.TabIndex = 41;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(6, 85);
            label5.Name = "label5";
            label5.Size = new Size(47, 16);
            label5.TabIndex = 40;
            label5.Text = "Codigo";
            // 
            // btnBuscaCategoria
            // 
            btnBuscaCategoria.BackColor = Color.Transparent;
            btnBuscaCategoria.Enabled = false;
            btnBuscaCategoria.FlatAppearance.BorderSize = 0;
            btnBuscaCategoria.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaCategoria.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaCategoria.FlatStyle = FlatStyle.Flat;
            btnBuscaCategoria.Image = Properties.Resources.lupa;
            btnBuscaCategoria.Location = new Point(270, 105);
            btnBuscaCategoria.Name = "btnBuscaCategoria";
            btnBuscaCategoria.Size = new Size(30, 23);
            btnBuscaCategoria.TabIndex = 39;
            btnBuscaCategoria.UseVisualStyleBackColor = false;
            btnBuscaCategoria.Click += AbriFormPesquisaCategoria_Click;
            // 
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(radioButtonAtivoNao);
            groupBox3.Controls.Add(radioButtonAtivoSim);
            groupBox3.Font = new Font("Arial", 9.75F);
            groupBox3.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox3.Location = new Point(6, 201);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(137, 57);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ativo";
            // 
            // radioButtonAtivoNao
            // 
            radioButtonAtivoNao.Enabled = false;
            radioButtonAtivoNao.Location = new Point(66, 19);
            radioButtonAtivoNao.Name = "radioButtonAtivoNao";
            radioButtonAtivoNao.Size = new Size(63, 22);
            radioButtonAtivoNao.TabIndex = 4;
            radioButtonAtivoNao.TabStop = true;
            radioButtonAtivoNao.Text = "Não";
            radioButtonAtivoNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtivoSim
            // 
            radioButtonAtivoSim.Enabled = false;
            radioButtonAtivoSim.Location = new Point(6, 18);
            radioButtonAtivoSim.Name = "radioButtonAtivoSim";
            radioButtonAtivoSim.Size = new Size(54, 24);
            radioButtonAtivoSim.TabIndex = 3;
            radioButtonAtivoSim.TabStop = true;
            radioButtonAtivoSim.Text = "Sim";
            radioButtonAtivoSim.UseVisualStyleBackColor = true;
            // 
            // textPrecoServico
            // 
            textPrecoServico.Location = new Point(303, 106);
            textPrecoServico.Name = "textPrecoServico";
            textPrecoServico.ReadOnly = true;
            textPrecoServico.Size = new Size(143, 23);
            textPrecoServico.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(303, 87);
            label6.Name = "label6";
            label6.Size = new Size(36, 16);
            label6.TabIndex = 26;
            label6.Text = "Valor";
            // 
            // textCategoriaServico
            // 
            textCategoriaServico.Location = new Point(59, 106);
            textCategoriaServico.Name = "textCategoriaServico";
            textCategoriaServico.ReadOnly = true;
            textCategoriaServico.Size = new Size(215, 23);
            textCategoriaServico.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(76, 87);
            label4.Name = "label4";
            label4.Size = new Size(89, 16);
            label4.TabIndex = 24;
            label4.Text = "Categoria - F1";
            // 
            // textDescricao
            // 
            textDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDescricao.Location = new Point(280, 45);
            textDescricao.Name = "textDescricao";
            textDescricao.ReadOnly = true;
            textDescricao.Size = new Size(401, 23);
            textDescricao.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(280, 26);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 24;
            label3.Text = "Descrição";
            // 
            // textNomeServico
            // 
            textNomeServico.Location = new Point(76, 45);
            textNomeServico.Name = "textNomeServico";
            textNomeServico.ReadOnly = true;
            textNomeServico.Size = new Size(198, 23);
            textNomeServico.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(76, 25);
            label10.Name = "label10";
            label10.Size = new Size(105, 16);
            label10.TabIndex = 22;
            label10.Text = "Nome do Serviço";
            // 
            // textCodigoServico
            // 
            textCodigoServico.Location = new Point(6, 45);
            textCodigoServico.Name = "textCodigoServico";
            textCodigoServico.ReadOnly = true;
            textCodigoServico.Size = new Size(64, 23);
            textCodigoServico.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 2;
            label1.Text = "Codigo";
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(990, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnExcluir);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 56);
            panel1.TabIndex = 2;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.novo;
            btnEditar.Location = new Point(141, 7);
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
            btnExcluir.Location = new Point(6, 7);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxTodos);
            groupBox2.Controls.Add(btnPesquisarPais);
            groupBox2.Controls.Add(textDadosPesquisa);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboModelo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboFiltros);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(980, 97);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            groupBox2.Resize += groupBox2_Resize;
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(876, 16);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarPais
            // 
            btnPesquisarPais.Image = Properties.Resources.lupa;
            btnPesquisarPais.Location = new Point(858, 64);
            btnPesquisarPais.Name = "btnPesquisarPais";
            btnPesquisarPais.Size = new Size(113, 29);
            btnPesquisarPais.TabIndex = 26;
            btnPesquisarPais.Text = "Pesquisar";
            btnPesquisarPais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarPais.UseVisualStyleBackColor = true;
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(374, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(597, 23);
            textDadosPesquisa.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F);
            label16.ForeColor = Color.FromArgb(44, 62, 80);
            label16.Location = new Point(374, 14);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(6, 16);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 20;
            label2.Text = "Filtros";
            // 
            // comboFiltros
            // 
            comboFiltros.FormattingEnabled = true;
            comboFiltros.Location = new Point(6, 35);
            comboFiltros.Name = "comboFiltros";
            comboFiltros.Size = new Size(178, 23);
            comboFiltros.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 219);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, NomeServico, DescricaoCargo, PrecoServico, DataCadastro, UltimaAtualização });
            dataGridView1.Location = new Point(-2, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(980, 219);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // NomeServico
            // 
            NomeServico.HeaderText = "Nome do Serviço";
            NomeServico.Name = "NomeServico";
            NomeServico.Width = 450;
            // 
            // DescricaoCargo
            // 
            DescricaoCargo.HeaderText = "Descrição ";
            DescricaoCargo.Name = "DescricaoCargo";
            DescricaoCargo.Width = 300;
            // 
            // PrecoServico
            // 
            PrecoServico.HeaderText = "Preço do Serviço";
            PrecoServico.Name = "PrecoServico";
            PrecoServico.ReadOnly = true;
            PrecoServico.Width = 200;
            // 
            // DataCadastro
            // 
            DataCadastro.HeaderText = "Data de Cadastro";
            DataCadastro.Name = "DataCadastro";
            DataCadastro.Width = 250;
            // 
            // UltimaAtualização
            // 
            UltimaAtualização.HeaderText = "Ultima Atualização";
            UltimaAtualização.Name = "UltimaAtualização";
            UltimaAtualização.Width = 250;
            // 
            // CadastrarServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 418);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "CadastrarServico";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Serviços";
            Load += CadastrarPais_Load;
            KeyDown += LiberarCamposParaNovoCadastro_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            radioDescontoNao.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox textCodigoServico;
        private Label label1;
        private TextBox textNomeServico;
        private Label label10;
        private GroupBox groupBox2;
        private Label label17;
        private ComboBox comboModelo;
        private Label label2;
        private ComboBox comboFiltros;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Button btnPesquisarPais;
        private CheckBox checkBoxTodos;
        private Panel panel3;
        private Panel panel1;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox textDescricao;
        private Label label3;
        private TextBox textCategoriaServico;
        private Label label4;
        private TextBox textPrecoServico;
        private Label label6;
        private GroupBox groupBox3;
        private RadioButton radioButtonAtivoNao;
        private RadioButton radioButtonAtivoSim;
        private Button btnBuscaCategoria;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox textBox1;
        private Label label5;
        private GroupBox radioDescontoNao;
        private RadioButton radioButton1;
        private RadioButton radioDescontoSim;
        private TextBox textCodIss;
        private Label label7;
        private Button button1;
        private TextBox textIss;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NomeServico;
        private DataGridViewTextBoxColumn DescricaoCargo;
        private DataGridViewTextBoxColumn PrecoServico;
        private DataGridViewTextBoxColumn DataCadastro;
        private DataGridViewTextBoxColumn UltimaAtualização;
    }
}