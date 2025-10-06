namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox6 = new GroupBox();
            textBox4 = new TextBox();
            label21 = new Label();
            label30 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            label20 = new Label();
            button1 = new Button();
            textFormaPagamento = new TextBox();
            label18 = new Label();
            label14 = new Label();
            comboBoxCondicaoPagamento = new ComboBox();
            textLimiteCredito = new TextBox();
            label27 = new Label();
            panel1 = new Panel();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox4 = new GroupBox();
            textMotivo = new TextBox();
            label31 = new Label();
            groupBox7 = new GroupBox();
            radioBloqueadoNao = new RadioButton();
            radioBloqueadoSim = new RadioButton();
            label26 = new Label();
            comboBoxGralParentesco = new ComboBox();
            textNomeContato = new TextBox();
            textEmailContato = new TextBox();
            label22 = new Label();
            label23 = new Label();
            textWhatsAppContato = new MaskedTextBox();
            label24 = new Label();
            textTelFixoContato = new MaskedTextBox();
            label25 = new Label();
            label28 = new Label();
            textRgContato = new MaskedTextBox();
            label29 = new Label();
            textCpfContato = new MaskedTextBox();
            groupBox1 = new GroupBox();
            comboBoxUf = new ComboBox();
            label19 = new Label();
            btnBuscarPais = new Button();
            btnBuscaBairro = new Button();
            textDataCadastro = new MaskedTextBox();
            btnBuscaCidade = new Button();
            textNumero = new TextBox();
            label15 = new Label();
            textBairro = new TextBox();
            label13 = new Label();
            label12 = new Label();
            textCidade = new TextBox();
            label11 = new Label();
            textPais = new TextBox();
            label10 = new Label();
            textEmail = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textWhatsApp = new MaskedTextBox();
            label7 = new Label();
            textTelefoneFixo = new MaskedTextBox();
            textNomeCliente = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            radioButtonAtivoNao = new RadioButton();
            radioButtonAtivoSim = new RadioButton();
            label5 = new Label();
            comboBoxSexo = new ComboBox();
            label4 = new Label();
            textDataNascimento = new MaskedTextBox();
            label3 = new Label();
            textRg = new MaskedTextBox();
            labelCpfCnpj = new Label();
            textCpfCnpj = new MaskedTextBox();
            groupBox2 = new GroupBox();
            radioButtonPessaoJuridica = new RadioButton();
            radioButtonPessoaFisica = new RadioButton();
            textCod = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            tabelaCliente = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CpfCnpj = new DataGridViewTextBoxColumn();
            TelCliente = new DataGridViewTextBoxColumn();
            Whatsapp = new DataGridViewTextBoxColumn();
            Uf = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            DataCriacao = new DataGridViewTextBoxColumn();
            UltimaAtualizacao = new DataGridViewTextBoxColumn();
            NomeFantasia = new DataGridViewTextBoxColumn();
            LimiteCredito = new DataGridViewTextBoxColumn();
            ContatoComercial = new DataGridViewTextBoxColumn();
            ObservacaoGeral = new DataGridViewTextBoxColumn();
            Bloqueado = new DataGridViewCheckBoxColumn();
            groupBox5 = new GroupBox();
            btnPesquisar = new Button();
            label17 = new Label();
            comboModelo = new ComboBox();
            checkBoxCarregarTodos = new CheckBox();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label2 = new Label();
            comboFiltros = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaCliente).BeginInit();
            groupBox5.SuspendLayout();
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
            tabControl1.Size = new Size(1192, 767);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1184, 739);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(textBox4);
            groupBox6.Controls.Add(label21);
            groupBox6.Controls.Add(label30);
            groupBox6.Controls.Add(maskedTextBox1);
            groupBox6.Controls.Add(textBox3);
            groupBox6.Controls.Add(label20);
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(textFormaPagamento);
            groupBox6.Controls.Add(label18);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(comboBoxCondicaoPagamento);
            groupBox6.Controls.Add(textLimiteCredito);
            groupBox6.Controls.Add(label27);
            groupBox6.Location = new Point(6, 382);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1168, 255);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Dados Fiscais";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(191, 91);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(311, 23);
            textBox4.TabIndex = 46;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9.75F);
            label21.ForeColor = Color.FromArgb(44, 62, 80);
            label21.Location = new Point(191, 72);
            label21.Name = "label21";
            label21.Size = new Size(90, 16);
            label21.TabIndex = 45;
            label21.Text = "Nome fantasia";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 9.75F);
            label30.ForeColor = Color.FromArgb(44, 62, 80);
            label30.Location = new Point(7, 71);
            label30.Name = "label30";
            label30.Size = new Size(112, 16);
            label30.TabIndex = 44;
            label30.Text = "Contato comercial";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(7, 91);
            maskedTextBox1.Mask = "(00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.ReadOnly = true;
            maskedTextBox1.Size = new Size(176, 23);
            maskedTextBox1.TabIndex = 43;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(7, 146);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(518, 103);
            textBox3.TabIndex = 42;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 9.75F);
            label20.ForeColor = Color.FromArgb(44, 62, 80);
            label20.Location = new Point(6, 127);
            label20.Name = "label20";
            label20.Size = new Size(121, 16);
            label20.TabIndex = 41;
            label20.Text = "Observações gerais";
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
            button1.Location = new Point(829, 34);
            button1.Name = "button1";
            button1.Size = new Size(28, 23);
            button1.TabIndex = 38;
            button1.UseVisualStyleBackColor = false;
            // 
            // textFormaPagamento
            // 
            textFormaPagamento.Location = new Point(390, 35);
            textFormaPagamento.Name = "textFormaPagamento";
            textFormaPagamento.ReadOnly = true;
            textFormaPagamento.Size = new Size(433, 23);
            textFormaPagamento.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F);
            label18.ForeColor = Color.FromArgb(44, 62, 80);
            label18.Location = new Point(390, 15);
            label18.Name = "label18";
            label18.Size = new Size(200, 16);
            label18.TabIndex = 39;
            label18.Text = "Forma de pagamento preferencial";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F);
            label14.ForeColor = Color.FromArgb(44, 62, 80);
            label14.Location = new Point(191, 15);
            label14.Name = "label14";
            label14.Size = new Size(190, 16);
            label14.TabIndex = 37;
            label14.Text = "Condição de pagamento padrão";
            // 
            // comboBoxCondicaoPagamento
            // 
            comboBoxCondicaoPagamento.Enabled = false;
            comboBoxCondicaoPagamento.FormattingEnabled = true;
            comboBoxCondicaoPagamento.Items.AddRange(new object[] { "À Vista", "7 Dias", "15 Dias", "30 Dias", "45 Dias", "60 Dias", "90 Dias", "30/60", "30/60/90", "Entrada + 30 Dias", "Entrada + 30/60", "Cartão de Crédito - 1x", "Cartão de Crédito - 2x", "Cartão de Crédito - 3x", "Cartão de Crédito - 6x", "Cartão de Crédito - 12x", "Boleto Bancário - Vencimento Fixo (dia 10)", "Boleto Bancário - Vencimento Fixo (dia 15)", "Débito Automático", "Cheque Pré-Datado - 30 Dias", "Cheque Pré-Datado - 30/60" });
            comboBoxCondicaoPagamento.Location = new Point(191, 35);
            comboBoxCondicaoPagamento.Name = "comboBoxCondicaoPagamento";
            comboBoxCondicaoPagamento.Size = new Size(190, 23);
            comboBoxCondicaoPagamento.TabIndex = 36;
            // 
            // textLimiteCredito
            // 
            textLimiteCredito.Location = new Point(7, 35);
            textLimiteCredito.Name = "textLimiteCredito";
            textLimiteCredito.ReadOnly = true;
            textLimiteCredito.Size = new Size(176, 23);
            textLimiteCredito.TabIndex = 33;
            textLimiteCredito.Text = "0,00";
            textLimiteCredito.TextChanged += MaskaraCampoMoeda_TextChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 9.75F);
            label27.ForeColor = Color.FromArgb(44, 62, 80);
            label27.Location = new Point(6, 16);
            label27.Name = "label27";
            label27.Size = new Size(103, 16);
            label27.TabIndex = 12;
            label27.Text = "Limite de crédito";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 681);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 51);
            panel1.TabIndex = 11;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(1, 8);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 40);
            btnNovo.TabIndex = 18;
            btnNovo.Text = "Incluir F4";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += LiberararCamposParaNovoCadastro_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(189, 8);
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
            btnGravar.Location = new Point(95, 8);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 40);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(textMotivo);
            groupBox4.Controls.Add(label31);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(comboBoxGralParentesco);
            groupBox4.Controls.Add(textNomeContato);
            groupBox4.Controls.Add(textEmailContato);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(textWhatsAppContato);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(textTelFixoContato);
            groupBox4.Controls.Add(label25);
            groupBox4.Controls.Add(label28);
            groupBox4.Controls.Add(textRgContato);
            groupBox4.Controls.Add(label29);
            groupBox4.Controls.Add(textCpfContato);
            groupBox4.Location = new Point(6, 240);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1168, 136);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dados Para Contato";
            // 
            // textMotivo
            // 
            textMotivo.Location = new Point(850, 34);
            textMotivo.Name = "textMotivo";
            textMotivo.ReadOnly = true;
            textMotivo.Size = new Size(304, 23);
            textMotivo.TabIndex = 38;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial", 9.75F);
            label31.ForeColor = Color.FromArgb(44, 62, 80);
            label31.Location = new Point(850, 14);
            label31.Name = "label31";
            label31.Size = new Size(114, 16);
            label31.TabIndex = 37;
            label31.Text = "Motivo de bloqueio";
            // 
            // groupBox7
            // 
            groupBox7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox7.Controls.Add(radioBloqueadoNao);
            groupBox7.Controls.Add(radioBloqueadoSim);
            groupBox7.Font = new Font("Arial", 9.75F);
            groupBox7.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox7.Location = new Point(675, 16);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(169, 56);
            groupBox7.TabIndex = 36;
            groupBox7.TabStop = false;
            groupBox7.Text = "Bloqueado para compras";
            // 
            // radioBloqueadoNao
            // 
            radioBloqueadoNao.Enabled = false;
            radioBloqueadoNao.Location = new Point(87, 21);
            radioBloqueadoNao.Name = "radioBloqueadoNao";
            radioBloqueadoNao.Size = new Size(76, 22);
            radioBloqueadoNao.TabIndex = 4;
            radioBloqueadoNao.TabStop = true;
            radioBloqueadoNao.Text = "Não";
            radioBloqueadoNao.UseVisualStyleBackColor = true;
            // 
            // radioBloqueadoSim
            // 
            radioBloqueadoSim.Enabled = false;
            radioBloqueadoSim.Location = new Point(6, 18);
            radioBloqueadoSim.Name = "radioBloqueadoSim";
            radioBloqueadoSim.Size = new Size(54, 24);
            radioBloqueadoSim.TabIndex = 3;
            radioBloqueadoSim.TabStop = true;
            radioBloqueadoSim.Text = "Sim";
            radioBloqueadoSim.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 9.75F);
            label26.ForeColor = Color.FromArgb(44, 62, 80);
            label26.Location = new Point(663, 72);
            label26.Name = "label26";
            label26.Size = new Size(119, 16);
            label26.TabIndex = 35;
            label26.Text = "Gral de Parentesco";
            // 
            // comboBoxGralParentesco
            // 
            comboBoxGralParentesco.Enabled = false;
            comboBoxGralParentesco.FormattingEnabled = true;
            comboBoxGralParentesco.Items.AddRange(new object[] { "Pai", "Mãe", "Filho(a)", "Irmão(ã)", "Avô", "Avó", "Tio(a)", "Primo(a)", "Sobrinho(a)", "Cônjuge", "Companheiro(a)", "Sogro(a)", "Genro", "Nora", "Responsável Legal", "Outro" });
            comboBoxGralParentesco.Location = new Point(663, 92);
            comboBoxGralParentesco.Name = "comboBoxGralParentesco";
            comboBoxGralParentesco.Size = new Size(228, 23);
            comboBoxGralParentesco.TabIndex = 34;
            // 
            // textNomeContato
            // 
            textNomeContato.Location = new Point(314, 35);
            textNomeContato.Name = "textNomeContato";
            textNomeContato.ReadOnly = true;
            textNomeContato.Size = new Size(343, 23);
            textNomeContato.TabIndex = 33;
            // 
            // textEmailContato
            // 
            textEmailContato.Location = new Point(314, 92);
            textEmailContato.Name = "textEmailContato";
            textEmailContato.ReadOnly = true;
            textEmailContato.Size = new Size(343, 23);
            textEmailContato.TabIndex = 19;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 9.75F);
            label22.ForeColor = Color.FromArgb(44, 62, 80);
            label22.Location = new Point(314, 73);
            label22.Name = "label22";
            label22.Size = new Size(40, 16);
            label22.TabIndex = 18;
            label22.Text = "Email";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 9.75F);
            label23.ForeColor = Color.FromArgb(44, 62, 80);
            label23.Location = new Point(160, 70);
            label23.Name = "label23";
            label23.Size = new Size(68, 16);
            label23.TabIndex = 17;
            label23.Text = "WhatsApp";
            // 
            // textWhatsAppContato
            // 
            textWhatsAppContato.Location = new Point(160, 90);
            textWhatsAppContato.Mask = "(00) 00000-0000";
            textWhatsAppContato.Name = "textWhatsAppContato";
            textWhatsAppContato.ReadOnly = true;
            textWhatsAppContato.Size = new Size(148, 23);
            textWhatsAppContato.TabIndex = 16;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 9.75F);
            label24.ForeColor = Color.FromArgb(44, 62, 80);
            label24.Location = new Point(6, 70);
            label24.Name = "label24";
            label24.Size = new Size(83, 16);
            label24.TabIndex = 15;
            label24.Text = "Telefone Fixo";
            // 
            // textTelFixoContato
            // 
            textTelFixoContato.Location = new Point(6, 90);
            textTelFixoContato.Mask = "(00) 00000-0000";
            textTelFixoContato.Name = "textTelFixoContato";
            textTelFixoContato.ReadOnly = true;
            textTelFixoContato.Size = new Size(148, 23);
            textTelFixoContato.TabIndex = 14;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial", 9.75F);
            label25.ForeColor = Color.FromArgb(44, 62, 80);
            label25.Location = new Point(314, 16);
            label25.Name = "label25";
            label25.Size = new Size(100, 16);
            label25.TabIndex = 12;
            label25.Text = "Nome Completo";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 9.75F);
            label28.ForeColor = Color.FromArgb(44, 62, 80);
            label28.Location = new Point(160, 14);
            label28.Name = "label28";
            label28.Size = new Size(23, 16);
            label28.TabIndex = 6;
            label28.Text = "Rg";
            // 
            // textRgContato
            // 
            textRgContato.Location = new Point(160, 34);
            textRgContato.Mask = "00.000.000-0";
            textRgContato.Name = "textRgContato";
            textRgContato.ReadOnly = true;
            textRgContato.Size = new Size(148, 23);
            textRgContato.TabIndex = 5;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Arial", 9.75F);
            label29.ForeColor = Color.FromArgb(44, 62, 80);
            label29.Location = new Point(6, 14);
            label29.Name = "label29";
            label29.Size = new Size(26, 16);
            label29.TabIndex = 4;
            label29.Text = "Cpf";
            // 
            // textCpfContato
            // 
            textCpfContato.Location = new Point(6, 34);
            textCpfContato.Name = "textCpfContato";
            textCpfContato.ReadOnly = true;
            textCpfContato.Size = new Size(148, 23);
            textCpfContato.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(comboBoxUf);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(btnBuscarPais);
            groupBox1.Controls.Add(btnBuscaBairro);
            groupBox1.Controls.Add(textDataCadastro);
            groupBox1.Controls.Add(btnBuscaCidade);
            groupBox1.Controls.Add(textNumero);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(textBairro);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textCidade);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textPais);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textWhatsApp);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textTelefoneFixo);
            groupBox1.Controls.Add(textNomeCliente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxSexo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textDataNascimento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textRg);
            groupBox1.Controls.Add(labelCpfCnpj);
            groupBox1.Controls.Add(textCpfCnpj);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textCod);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1168, 218);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Do Cliente";
            // 
            // comboBoxUf
            // 
            comboBoxUf.Enabled = false;
            comboBoxUf.FormattingEnabled = true;
            comboBoxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxUf.Location = new Point(185, 177);
            comboBoxUf.Name = "comboBoxUf";
            comboBoxUf.Size = new Size(64, 23);
            comboBoxUf.TabIndex = 36;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F);
            label19.ForeColor = Color.FromArgb(44, 62, 80);
            label19.Location = new Point(829, 161);
            label19.Name = "label19";
            label19.Size = new Size(108, 16);
            label19.TabIndex = 35;
            label19.Text = "Data de Cadastro";
            // 
            // btnBuscarPais
            // 
            btnBuscarPais.BackColor = Color.Transparent;
            btnBuscarPais.Enabled = false;
            btnBuscarPais.FlatAppearance.BorderSize = 0;
            btnBuscarPais.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscarPais.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscarPais.FlatStyle = FlatStyle.Flat;
            btnBuscarPais.Image = Properties.Resources.lupa;
            btnBuscarPais.Location = new Point(155, 178);
            btnBuscarPais.Name = "btnBuscarPais";
            btnBuscarPais.Size = new Size(28, 23);
            btnBuscarPais.TabIndex = 33;
            btnBuscarPais.UseVisualStyleBackColor = false;
            // 
            // btnBuscaBairro
            // 
            btnBuscaBairro.BackColor = Color.Transparent;
            btnBuscaBairro.Enabled = false;
            btnBuscaBairro.FlatAppearance.BorderSize = 0;
            btnBuscaBairro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaBairro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaBairro.FlatStyle = FlatStyle.Flat;
            btnBuscaBairro.Image = Properties.Resources.lupa;
            btnBuscaBairro.Location = new Point(663, 178);
            btnBuscaBairro.Name = "btnBuscaBairro";
            btnBuscaBairro.Size = new Size(28, 23);
            btnBuscaBairro.TabIndex = 32;
            btnBuscaBairro.UseVisualStyleBackColor = false;
            // 
            // textDataCadastro
            // 
            textDataCadastro.Location = new Point(829, 178);
            textDataCadastro.Mask = "00/00/0000";
            textDataCadastro.Name = "textDataCadastro";
            textDataCadastro.ReadOnly = true;
            textDataCadastro.Size = new Size(148, 23);
            textDataCadastro.TabIndex = 34;
            textDataCadastro.ValidatingType = typeof(DateTime);
            // 
            // btnBuscaCidade
            // 
            btnBuscaCidade.BackColor = Color.Transparent;
            btnBuscaCidade.Enabled = false;
            btnBuscaCidade.FlatAppearance.BorderSize = 0;
            btnBuscaCidade.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaCidade.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaCidade.FlatStyle = FlatStyle.Flat;
            btnBuscaCidade.Image = Properties.Resources.lupa;
            btnBuscaCidade.Location = new Point(400, 178);
            btnBuscaCidade.Name = "btnBuscaCidade";
            btnBuscaCidade.Size = new Size(28, 23);
            btnBuscaCidade.TabIndex = 0;
            btnBuscaCidade.UseVisualStyleBackColor = false;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(698, 178);
            textNumero.Name = "textNumero";
            textNumero.ReadOnly = true;
            textNumero.Size = new Size(125, 23);
            textNumero.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F);
            label15.ForeColor = Color.FromArgb(44, 62, 80);
            label15.Location = new Point(698, 158);
            label15.Name = "label15";
            label15.Size = new Size(52, 16);
            label15.TabIndex = 30;
            label15.Text = "Numero";
            // 
            // textBairro
            // 
            textBairro.Location = new Point(434, 178);
            textBairro.Name = "textBairro";
            textBairro.ReadOnly = true;
            textBairro.Size = new Size(223, 23);
            textBairro.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F);
            label13.ForeColor = Color.FromArgb(44, 62, 80);
            label13.Location = new Point(434, 158);
            label13.Name = "label13";
            label13.Size = new Size(68, 16);
            label13.TabIndex = 26;
            label13.Text = "Bairro - F2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F);
            label12.ForeColor = Color.FromArgb(44, 62, 80);
            label12.Location = new Point(255, 159);
            label12.Name = "label12";
            label12.Size = new Size(74, 16);
            label12.TabIndex = 25;
            label12.Text = "Cidade - F1";
            // 
            // textCidade
            // 
            textCidade.Location = new Point(255, 178);
            textCidade.Name = "textCidade";
            textCidade.ReadOnly = true;
            textCidade.Size = new Size(139, 23);
            textCidade.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F);
            label11.ForeColor = Color.FromArgb(44, 62, 80);
            label11.Location = new Point(185, 158);
            label11.Name = "label11";
            label11.Size = new Size(19, 16);
            label11.TabIndex = 22;
            label11.Text = "Uf";
            // 
            // textPais
            // 
            textPais.Location = new Point(6, 178);
            textPais.Name = "textPais";
            textPais.ReadOnly = true;
            textPais.Size = new Size(148, 23);
            textPais.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(6, 158);
            label10.Name = "label10";
            label10.Size = new Size(37, 16);
            label10.TabIndex = 20;
            label10.Text = "Pais ";
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textEmail.Location = new Point(698, 113);
            textEmail.Name = "textEmail";
            textEmail.ReadOnly = true;
            textEmail.Size = new Size(456, 23);
            textEmail.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F);
            label9.ForeColor = Color.FromArgb(44, 62, 80);
            label9.Location = new Point(698, 94);
            label9.Name = "label9";
            label9.Size = new Size(40, 16);
            label9.TabIndex = 18;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(544, 91);
            label8.Name = "label8";
            label8.Size = new Size(68, 16);
            label8.TabIndex = 17;
            label8.Text = "WhatsApp";
            // 
            // textWhatsApp
            // 
            textWhatsApp.Location = new Point(544, 111);
            textWhatsApp.Mask = "(00) 00000-0000";
            textWhatsApp.Name = "textWhatsApp";
            textWhatsApp.ReadOnly = true;
            textWhatsApp.Size = new Size(148, 23);
            textWhatsApp.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(390, 91);
            label7.Name = "label7";
            label7.Size = new Size(83, 16);
            label7.TabIndex = 15;
            label7.Text = "Telefone Fixo";
            // 
            // textTelefoneFixo
            // 
            textTelefoneFixo.Location = new Point(390, 111);
            textTelefoneFixo.Mask = "(00) 00000-0000";
            textTelefoneFixo.Name = "textTelefoneFixo";
            textTelefoneFixo.ReadOnly = true;
            textTelefoneFixo.Size = new Size(148, 23);
            textTelefoneFixo.TabIndex = 14;
            // 
            // textNomeCliente
            // 
            textNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNomeCliente.Location = new Point(568, 40);
            textNomeCliente.Name = "textNomeCliente";
            textNomeCliente.ReadOnly = true;
            textNomeCliente.Size = new Size(586, 23);
            textNomeCliente.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(568, 22);
            label6.Name = "label6";
            label6.Size = new Size(100, 16);
            label6.TabIndex = 12;
            label6.Text = "Nome Completo";
            // 
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(radioButtonAtivoNao);
            groupBox3.Controls.Add(radioButtonAtivoSim);
            groupBox3.Font = new Font("Arial", 9.75F);
            groupBox3.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox3.Location = new Point(242, 94);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(139, 52);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ativo";
            // 
            // radioButtonAtivoNao
            // 
            radioButtonAtivoNao.Enabled = false;
            radioButtonAtivoNao.Location = new Point(66, 19);
            radioButtonAtivoNao.Name = "radioButtonAtivoNao";
            radioButtonAtivoNao.Size = new Size(76, 22);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(160, 91);
            label5.Name = "label5";
            label5.Size = new Size(37, 16);
            label5.TabIndex = 10;
            label5.Text = "Sexo";
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.Enabled = false;
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Location = new Point(160, 111);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(76, 23);
            comboBoxSexo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(6, 94);
            label4.Name = "label4";
            label4.Size = new Size(125, 16);
            label4.TabIndex = 8;
            label4.Text = "Data de Nascimento";
            // 
            // textDataNascimento
            // 
            textDataNascimento.Location = new Point(6, 111);
            textDataNascimento.Mask = "00/00/0000";
            textDataNascimento.Name = "textDataNascimento";
            textDataNascimento.ReadOnly = true;
            textDataNascimento.Size = new Size(148, 23);
            textDataNascimento.TabIndex = 7;
            textDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(414, 20);
            label3.Name = "label3";
            label3.Size = new Size(23, 16);
            label3.TabIndex = 6;
            label3.Text = "Rg";
            // 
            // textRg
            // 
            textRg.Location = new Point(414, 40);
            textRg.Mask = "00.000.000-0";
            textRg.Name = "textRg";
            textRg.ReadOnly = true;
            textRg.Size = new Size(148, 23);
            textRg.TabIndex = 5;
            // 
            // labelCpfCnpj
            // 
            labelCpfCnpj.AutoSize = true;
            labelCpfCnpj.Font = new Font("Arial", 9.75F);
            labelCpfCnpj.ForeColor = Color.FromArgb(44, 62, 80);
            labelCpfCnpj.Location = new Point(260, 21);
            labelCpfCnpj.Name = "labelCpfCnpj";
            labelCpfCnpj.Size = new Size(74, 16);
            labelCpfCnpj.TabIndex = 4;
            labelCpfCnpj.Text = "Cnpj ou Cpf";
            // 
            // textCpfCnpj
            // 
            textCpfCnpj.Location = new Point(260, 41);
            textCpfCnpj.Name = "textCpfCnpj";
            textCpfCnpj.ReadOnly = true;
            textCpfCnpj.Size = new Size(148, 23);
            textCpfCnpj.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(radioButtonPessaoJuridica);
            groupBox2.Controls.Add(radioButtonPessoaFisica);
            groupBox2.Font = new Font("Arial", 9.75F);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(63, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(191, 52);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Pessoa";
            // 
            // radioButtonPessaoJuridica
            // 
            radioButtonPessaoJuridica.Enabled = false;
            radioButtonPessaoJuridica.Location = new Point(86, 19);
            radioButtonPessaoJuridica.Name = "radioButtonPessaoJuridica";
            radioButtonPessaoJuridica.Size = new Size(87, 22);
            radioButtonPessaoJuridica.TabIndex = 4;
            radioButtonPessaoJuridica.TabStop = true;
            radioButtonPessaoJuridica.Text = "Juridica";
            radioButtonPessaoJuridica.UseVisualStyleBackColor = true;
            radioButtonPessaoJuridica.CheckedChanged += DefinirMascaraCpfCnpj_CheckedChanged;
            // 
            // radioButtonPessoaFisica
            // 
            radioButtonPessoaFisica.Enabled = false;
            radioButtonPessoaFisica.Location = new Point(6, 18);
            radioButtonPessoaFisica.Name = "radioButtonPessoaFisica";
            radioButtonPessoaFisica.Size = new Size(74, 24);
            radioButtonPessoaFisica.TabIndex = 3;
            radioButtonPessoaFisica.TabStop = true;
            radioButtonPessoaFisica.Text = "Fisica";
            radioButtonPessoaFisica.UseVisualStyleBackColor = true;
            radioButtonPessoaFisica.CheckedChanged += DefinirMascaraCpfCnpj_CheckedChanged;
            // 
            // textCod
            // 
            textCod.Location = new Point(6, 42);
            textCod.Name = "textCod";
            textCod.ReadOnly = true;
            textCod.Size = new Size(51, 23);
            textCod.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1184, 739);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnExcluir);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 664);
            panel3.Name = "panel3";
            panel3.Size = new Size(1174, 68);
            panel3.TabIndex = 11;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.novo;
            btnEditar.Location = new Point(4, 14);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(128, 40);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.lixeira;
            btnExcluir.Location = new Point(138, 14);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(tabelaCliente);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(1174, 627);
            panel2.TabIndex = 1;
            // 
            // tabelaCliente
            // 
            tabelaCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabelaCliente.BackgroundColor = Color.White;
            tabelaCliente.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tabelaCliente.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, CpfCnpj, TelCliente, Whatsapp, Uf, Cidade, Bairro, Ativo, DataCriacao, UltimaAtualizacao, NomeFantasia, LimiteCredito, ContatoComercial, ObservacaoGeral, Bloqueado });
            tabelaCliente.EditMode = DataGridViewEditMode.EditOnF2;
            tabelaCliente.Location = new Point(2, 0);
            tabelaCliente.Name = "tabelaCliente";
            tabelaCliente.ReadOnly = true;
            tabelaCliente.Size = new Size(1170, 551);
            tabelaCliente.TabIndex = 3;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 80;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 400;
            // 
            // CpfCnpj
            // 
            CpfCnpj.HeaderText = "Cpf/Cnpj";
            CpfCnpj.Name = "CpfCnpj";
            CpfCnpj.ReadOnly = true;
            CpfCnpj.Width = 200;
            // 
            // TelCliente
            // 
            TelCliente.HeaderText = "Tel";
            TelCliente.Name = "TelCliente";
            TelCliente.ReadOnly = true;
            TelCliente.Width = 200;
            // 
            // Whatsapp
            // 
            Whatsapp.HeaderText = "Whatsapp";
            Whatsapp.Name = "Whatsapp";
            Whatsapp.ReadOnly = true;
            Whatsapp.Width = 200;
            // 
            // Uf
            // 
            Uf.HeaderText = "Uf";
            Uf.Name = "Uf";
            Uf.ReadOnly = true;
            Uf.Width = 200;
            // 
            // Cidade
            // 
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            Cidade.Width = 200;
            // 
            // Bairro
            // 
            Bairro.HeaderText = "Bairro";
            Bairro.Name = "Bairro";
            Bairro.ReadOnly = true;
            Bairro.Width = 250;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Width = 50;
            // 
            // DataCriacao
            // 
            DataCriacao.HeaderText = "Data de Criação";
            DataCriacao.Name = "DataCriacao";
            DataCriacao.ReadOnly = true;
            DataCriacao.Width = 250;
            // 
            // UltimaAtualizacao
            // 
            UltimaAtualizacao.HeaderText = "Ultima Atulização";
            UltimaAtualizacao.Name = "UltimaAtualizacao";
            UltimaAtualizacao.ReadOnly = true;
            UltimaAtualizacao.Width = 250;
            // 
            // NomeFantasia
            // 
            NomeFantasia.HeaderText = "Nome Fantasia";
            NomeFantasia.Name = "NomeFantasia";
            NomeFantasia.ReadOnly = true;
            // 
            // LimiteCredito
            // 
            LimiteCredito.HeaderText = "Limite de Credito";
            LimiteCredito.Name = "LimiteCredito";
            LimiteCredito.ReadOnly = true;
            // 
            // ContatoComercial
            // 
            ContatoComercial.HeaderText = "Contato Comercial";
            ContatoComercial.Name = "ContatoComercial";
            ContatoComercial.ReadOnly = true;
            // 
            // ObservacaoGeral
            // 
            ObservacaoGeral.HeaderText = "Observação Geral";
            ObservacaoGeral.Name = "ObservacaoGeral";
            ObservacaoGeral.ReadOnly = true;
            // 
            // Bloqueado
            // 
            Bloqueado.HeaderText = "Bloqueado ";
            Bloqueado.Name = "Bloqueado";
            Bloqueado.ReadOnly = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnPesquisar);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(comboModelo);
            groupBox5.Controls.Add(checkBoxCarregarTodos);
            groupBox5.Controls.Add(textDadosPesquisa);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(comboFiltros);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1174, 102);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Campos de Pesquisa";
            groupBox5.Resize += groupBox5_Resize;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(1059, 67);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(109, 29);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F);
            label17.ForeColor = Color.FromArgb(44, 62, 80);
            label17.Location = new Point(190, 21);
            label17.Name = "label17";
            label17.Size = new Size(122, 16);
            label17.TabIndex = 18;
            label17.Text = "Modelo de Consulta";
            // 
            // comboModelo
            // 
            comboModelo.FormattingEnabled = true;
            comboModelo.Location = new Point(190, 40);
            comboModelo.Name = "comboModelo";
            comboModelo.Size = new Size(178, 23);
            comboModelo.TabIndex = 17;
            // 
            // checkBoxCarregarTodos
            // 
            checkBoxCarregarTodos.AutoSize = true;
            checkBoxCarregarTodos.Location = new Point(1110, 18);
            checkBoxCarregarTodos.Name = "checkBoxCarregarTodos";
            checkBoxCarregarTodos.Size = new Size(58, 19);
            checkBoxCarregarTodos.TabIndex = 16;
            checkBoxCarregarTodos.Text = "Todos";
            checkBoxCarregarTodos.UseVisualStyleBackColor = true;
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(374, 40);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(794, 23);
            textDadosPesquisa.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F);
            label16.ForeColor = Color.FromArgb(44, 62, 80);
            label16.Location = new Point(374, 19);
            label16.Name = "label16";
            label16.Size = new Size(117, 16);
            label16.TabIndex = 14;
            label16.Text = "Dados a Pesquisar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 1;
            label2.Text = "Filtros";
            // 
            // comboFiltros
            // 
            comboFiltros.FormattingEnabled = true;
            comboFiltros.Location = new Point(6, 40);
            comboFiltros.Name = "comboFiltros";
            comboFiltros.Size = new Size(178, 23);
            comboFiltros.TabIndex = 0;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1192, 767);
            Controls.Add(tabControl1);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimizeBox = false;
            Name = "CadastrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Clientes";
            Load += CadastrarCliente_Load;
            KeyDown += LiberararCamposParaNovoCadastro_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabelaCliente).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButtonPessaoJuridica;
        private RadioButton radioButtonPessoaFisica;
        private Label labelCpfCnpj;
        private MaskedTextBox textCpfCnpj;
        private Label label3;
        private MaskedTextBox textRg;
        private Label label4;
        private MaskedTextBox textDataNascimento;
        private Label label5;
        private ComboBox comboBoxSexo;
        private GroupBox groupBox3;
        private RadioButton radioButtonAtivoNao;
        private RadioButton radioButtonAtivoSim;
        private TextBox textNomeCliente;
        private Label label6;
        private TextBox textEmail;
        private Label label9;
        private Label label8;
        private MaskedTextBox textWhatsApp;
        private Label label7;
        private MaskedTextBox textTelefoneFixo;
        private TextBox textPais;
        private Label label10;
        private TextBox textBairro;
        private Label label13;
        private Label label12;
        private TextBox textCidade;
        private Label label11;
        private TextBox textNumero;
        private Label label15;
        private Button btnBuscaCidade;
        private Button btnBuscaBairro;
        private Button btnBuscarPais;
        private GroupBox groupBox5;
        private Button btnExcluir;
        private Label label2;
        private ComboBox comboFiltros;
        private TextBox textDadosPesquisa;
        private Label label16;
        private CheckBox checkBoxCarregarTodos;
        private Label label17;
        private ComboBox comboModelo;
        private Panel panel2;
        private Button btnPesquisar;
        private Label label19;
        private MaskedTextBox textDataCadastro;
        private Button btnEditar;
        private Panel panel1;
        private Panel panel3;
        private DataGridView tabelaCliente;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CpfCnpj;
        private DataGridViewTextBoxColumn TelCliente;
        private DataGridViewTextBoxColumn Whatsapp;
        private DataGridViewTextBoxColumn Uf;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewCheckBoxColumn Ativo;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn UltimaAtualizacao;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnGravar;
        private GroupBox groupBox6;
        private Label label14;
        private ComboBox comboBoxCondicaoPagamento;
        private TextBox textLimiteCredito;
        private Label label27;
        private TextBox textBox4;
        private Label label21;
        private Label label30;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private Label label20;
        private Button button1;
        private TextBox textFormaPagamento;
        private Label label18;
        private GroupBox groupBox4;
        private Label label26;
        private ComboBox comboBoxGralParentesco;
        private TextBox textNomeContato;
        private TextBox textEmailContato;
        private Label label22;
        private Label label23;
        private MaskedTextBox textWhatsAppContato;
        private Label label24;
        private MaskedTextBox textTelFixoContato;
        private Label label25;
        private Label label28;
        private MaskedTextBox textRgContato;
        private Label label29;
        private MaskedTextBox textCpfContato;
        private DataGridViewTextBoxColumn NomeFantasia;
        private DataGridViewTextBoxColumn LimiteCredito;
        private DataGridViewTextBoxColumn ContatoComercial;
        private DataGridViewTextBoxColumn ObservacaoGeral;
        private DataGridViewCheckBoxColumn Bloqueado;
        private GroupBox groupBox7;
        private RadioButton radioBloqueadoNao;
        private RadioButton radioBloqueadoSim;
        private TextBox textMotivo;
        private Label label31;
        private TextBox textCod;
        private Label label1;
        private ComboBox comboBoxUf;
    }
}