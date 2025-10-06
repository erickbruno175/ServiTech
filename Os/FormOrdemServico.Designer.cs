namespace ServiTech.Os
{
    partial class FormOrdemServico
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdemServico));
            btnNovaOs = new Button();
            btnGravar = new Button();
            btnAddServico = new Button();
            panel1 = new Panel();
            btnSair = new Button();
            btnImprimir = new Button();
            btnExcluir = new Button();
            groupBox2 = new GroupBox();
            textValorPeca = new TextBox();
            label10 = new Label();
            button1 = new Button();
            label11 = new Label();
            textPeca = new TextBox();
            groupBox5 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label32 = new Label();
            textDataEntrada = new MaskedTextBox();
            label34 = new Label();
            textDataGarantia = new MaskedTextBox();
            comboStatus = new ComboBox();
            comboPrioridade = new ComboBox();
            textValor = new TextBox();
            label33 = new Label();
            label27 = new Label();
            comboBoxResTecnico = new ComboBox();
            label26 = new Label();
            label25 = new Label();
            textDataPrevista = new MaskedTextBox();
            textDataAtual = new MaskedTextBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            textTempoGasto = new MaskedTextBox();
            label21 = new Label();
            textPeçaTrocada = new TextBox();
            button5 = new Button();
            button4 = new Button();
            label20 = new Label();
            label19 = new Label();
            textServico = new TextBox();
            label18 = new Label();
            textDiagnostico = new TextBox();
            textObservacao = new TextBox();
            label17 = new Label();
            textDefeito = new TextBox();
            textNumeroSerie = new TextBox();
            label16 = new Label();
            label5 = new Label();
            textModelo = new TextBox();
            label9 = new Label();
            textMarca = new TextBox();
            textEquipamento = new TextBox();
            label14 = new Label();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            button6 = new Button();
            textTotal = new TextBox();
            label30 = new Label();
            label28 = new Label();
            texteDesconto = new TextBox();
            label29 = new Label();
            textSubTotal = new TextBox();
            groupBox3 = new GroupBox();
            labelContadorDados = new Label();
            textBuscarOs = new TextBox();
            panel3 = new Panel();
            labelNumeroOS = new Label();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            CodigoOs = new DataGridViewTextBoxColumn();
            NomeCliente = new DataGridViewTextBoxColumn();
            CpfCnpj = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Garantia = new DataGridViewCheckBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Servico = new DataGridViewTextBoxColumn();
            Diagnostico = new DataGridViewTextBoxColumn();
            Tecnico = new DataGridViewTextBoxColumn();
            Peça = new DataGridViewTextBoxColumn();
            Defeito = new DataGridViewTextBoxColumn();
            TempoGasto = new DataGridViewTextBoxColumn();
            DataAbertura = new DataGridViewTextBoxColumn();
            PrevisaoEntrega = new DataGridViewTextBoxColumn();
            DataEntrada = new DataGridViewTextBoxColumn();
            Prioridade = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            WhatasApp = new DataGridViewTextBoxColumn();
            ValorTotalPagar = new DataGridViewTextBoxColumn();
            FormaPagamento = new DataGridViewTextBoxColumn();
            Atendente = new DataGridViewTextBoxColumn();
            ValorPeca = new DataGridViewTextBoxColumn();
            label1InfoOperador = new Label();
            labelDataHora = new Label();
            label6 = new Label();
            textCodOs = new TextBox();
            textCodCliente = new TextBox();
            label2 = new Label();
            textNomeCliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnBuscaBairro = new Button();
            label31 = new Label();
            textCod = new TextBox();
            textTel = new MaskedTextBox();
            textWhatsApp = new MaskedTextBox();
            textCpfCnpl = new MaskedTextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovaOs
            // 
            btnNovaOs.BackColor = Color.Transparent;
            btnNovaOs.Dock = DockStyle.Left;
            btnNovaOs.FlatAppearance.BorderSize = 0;
            btnNovaOs.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNovaOs.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnNovaOs.FlatStyle = FlatStyle.Flat;
            btnNovaOs.Font = new Font("Segoe UI", 9.75F);
            btnNovaOs.ForeColor = Color.Black;
            btnNovaOs.Image = Properties.Resources.ferram1;
            btnNovaOs.ImageAlign = ContentAlignment.TopCenter;
            btnNovaOs.ImeMode = ImeMode.NoControl;
            btnNovaOs.Location = new Point(0, 0);
            btnNovaOs.Name = "btnNovaOs";
            btnNovaOs.Size = new Size(102, 71);
            btnNovaOs.TabIndex = 5;
            btnNovaOs.Text = "Abrir Nova OS";
            btnNovaOs.TextAlign = ContentAlignment.BottomCenter;
            btnNovaOs.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNovaOs.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.Transparent;
            btnGravar.Dock = DockStyle.Left;
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGravar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Font = new Font("Segoe UI", 9.75F);
            btnGravar.ForeColor = Color.Black;
            btnGravar.Image = Properties.Resources.salve_os;
            btnGravar.ImageAlign = ContentAlignment.TopCenter;
            btnGravar.ImeMode = ImeMode.NoControl;
            btnGravar.Location = new Point(102, 0);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(83, 71);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.TextAlign = ContentAlignment.BottomCenter;
            btnGravar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnAddServico
            // 
            btnAddServico.BackColor = Color.Transparent;
            btnAddServico.Dock = DockStyle.Left;
            btnAddServico.FlatAppearance.BorderSize = 0;
            btnAddServico.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddServico.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnAddServico.FlatStyle = FlatStyle.Flat;
            btnAddServico.Font = new Font("Segoe UI", 9.75F);
            btnAddServico.ForeColor = Color.Black;
            btnAddServico.Image = Properties.Resources.mais;
            btnAddServico.ImageAlign = ContentAlignment.TopCenter;
            btnAddServico.ImeMode = ImeMode.NoControl;
            btnAddServico.Location = new Point(185, 0);
            btnAddServico.Name = "btnAddServico";
            btnAddServico.Size = new Size(103, 71);
            btnAddServico.TabIndex = 7;
            btnAddServico.Text = "Adicionar";
            btnAddServico.TextAlign = ContentAlignment.BottomCenter;
            btnAddServico.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddServico.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnImprimir);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAddServico);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnNovaOs);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(1522, 75);
            panel1.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Dock = DockStyle.Left;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9.75F);
            btnSair.ForeColor = Color.Black;
            btnSair.Image = Properties.Resources.sair__1_;
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.ImeMode = ImeMode.NoControl;
            btnSair.Location = new Point(494, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(103, 71);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.Transparent;
            btnImprimir.Dock = DockStyle.Left;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 9.75F);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Image = Properties.Resources.impressao;
            btnImprimir.ImageAlign = ContentAlignment.TopCenter;
            btnImprimir.ImeMode = ImeMode.NoControl;
            btnImprimir.Location = new Point(391, 0);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(103, 71);
            btnImprimir.TabIndex = 9;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextAlign = ContentAlignment.BottomCenter;
            btnImprimir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Dock = DockStyle.Left;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 9.75F);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Image = Properties.Resources.excluir;
            btnExcluir.ImageAlign = ContentAlignment.TopCenter;
            btnExcluir.ImeMode = ImeMode.NoControl;
            btnExcluir.Location = new Point(288, 0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(103, 71);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Exluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textValorPeca);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textPeca);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(textDataEntrada);
            groupBox2.Controls.Add(label34);
            groupBox2.Controls.Add(textDataGarantia);
            groupBox2.Controls.Add(comboStatus);
            groupBox2.Controls.Add(comboPrioridade);
            groupBox2.Controls.Add(textValor);
            groupBox2.Controls.Add(label33);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(comboBoxResTecnico);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(textDataPrevista);
            groupBox2.Controls.Add(textDataAtual);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(textTempoGasto);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(textPeçaTrocada);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(textServico);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(textDiagnostico);
            groupBox2.Controls.Add(textObservacao);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(textDefeito);
            groupBox2.Controls.Add(textNumeroSerie);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textModelo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textMarca);
            groupBox2.Controls.Add(textEquipamento);
            groupBox2.Controls.Add(label14);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1522, 255);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Equipamento / Serviço";
            // 
            // textValorPeca
            // 
            textValorPeca.Location = new Point(722, 101);
            textValorPeca.Multiline = true;
            textValorPeca.Name = "textValorPeca";
            textValorPeca.PlaceholderText = "0,00";
            textValorPeca.ReadOnly = true;
            textValorPeca.Size = new Size(106, 29);
            textValorPeca.TabIndex = 190;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(722, 83);
            label10.Name = "label10";
            label10.Size = new Size(70, 16);
            label10.TabIndex = 189;
            label10.Text = "Valor Peça";
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
            button1.Location = new Point(690, 99);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 188;
            button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F);
            label11.ForeColor = Color.FromArgb(44, 62, 80);
            label11.Location = new Point(423, 82);
            label11.Name = "label11";
            label11.Size = new Size(41, 16);
            label11.TabIndex = 187;
            label11.Text = "Peça ";
            // 
            // textPeca
            // 
            textPeca.Location = new Point(423, 101);
            textPeca.Multiline = true;
            textPeca.Name = "textPeca";
            textPeca.ReadOnly = true;
            textPeca.Size = new Size(261, 29);
            textPeca.TabIndex = 186;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(checkBox2);
            groupBox5.Controls.Add(checkBox1);
            groupBox5.Location = new Point(1352, 136);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(120, 67);
            groupBox5.TabIndex = 185;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tem Garantia ?";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(69, 21);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(41, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "N";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(28, 21);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(38, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "S";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Arial", 9.75F);
            label32.ForeColor = Color.FromArgb(44, 62, 80);
            label32.Location = new Point(13, 191);
            label32.Name = "label32";
            label32.Size = new Size(101, 16);
            label32.TabIndex = 184;
            label32.Text = "Data de Entrada";
            // 
            // textDataEntrada
            // 
            textDataEntrada.Location = new Point(13, 210);
            textDataEntrada.Mask = "00/00/0000 ";
            textDataEntrada.Name = "textDataEntrada";
            textDataEntrada.Size = new Size(145, 29);
            textDataEntrada.TabIndex = 183;
            textDataEntrada.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textDataEntrada.ValidatingType = typeof(DateTime);
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Arial", 9.75F);
            label34.ForeColor = Color.FromArgb(44, 62, 80);
            label34.Location = new Point(504, 191);
            label34.Name = "label34";
            label34.Size = new Size(56, 16);
            label34.TabIndex = 182;
            label34.Text = "Garantia";
            // 
            // textDataGarantia
            // 
            textDataGarantia.Location = new Point(504, 210);
            textDataGarantia.Mask = "00/00/0000 ";
            textDataGarantia.Name = "textDataGarantia";
            textDataGarantia.Size = new Size(164, 29);
            textDataGarantia.TabIndex = 181;
            textDataGarantia.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textDataGarantia.ValidatingType = typeof(DateTime);
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Aberta", "Em andamento", "Aguardando peças", "Aguardando aprovação", "Concluída", "Cancelada" });
            comboStatus.Location = new Point(834, 155);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(156, 29);
            comboStatus.TabIndex = 180;
            // 
            // comboPrioridade
            // 
            comboPrioridade.FormattingEnabled = true;
            comboPrioridade.Items.AddRange(new object[] { "Baixa", "Normal", "Alta", "Urgente", "Crítica" });
            comboPrioridade.Location = new Point(669, 155);
            comboPrioridade.Name = "comboPrioridade";
            comboPrioridade.Size = new Size(159, 29);
            comboPrioridade.TabIndex = 179;
            // 
            // textValor
            // 
            textValor.Location = new Point(311, 101);
            textValor.Multiline = true;
            textValor.Name = "textValor";
            textValor.PlaceholderText = "0,00";
            textValor.ReadOnly = true;
            textValor.Size = new Size(106, 29);
            textValor.TabIndex = 178;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Arial", 9.75F);
            label33.ForeColor = Color.FromArgb(44, 62, 80);
            label33.Location = new Point(311, 83);
            label33.Name = "label33";
            label33.Size = new Size(103, 16);
            label33.TabIndex = 177;
            label33.Text = "Valor M.De Obra";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 9.75F);
            label27.ForeColor = Color.FromArgb(44, 62, 80);
            label27.Location = new Point(996, 136);
            label27.Name = "label27";
            label27.Size = new Size(135, 16);
            label27.TabIndex = 176;
            label27.Text = "Responssavel Tecnico";
            // 
            // comboBoxResTecnico
            // 
            comboBoxResTecnico.FormattingEnabled = true;
            comboBoxResTecnico.ItemHeight = 21;
            comboBoxResTecnico.Location = new Point(996, 155);
            comboBoxResTecnico.Name = "comboBoxResTecnico";
            comboBoxResTecnico.Size = new Size(199, 29);
            comboBoxResTecnico.TabIndex = 175;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 9.75F);
            label26.ForeColor = Color.FromArgb(44, 62, 80);
            label26.Location = new Point(334, 191);
            label26.Name = "label26";
            label26.Size = new Size(123, 16);
            label26.TabIndex = 174;
            label26.Text = "Previsão de Entrega";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial", 9.75F);
            label25.ForeColor = Color.FromArgb(44, 62, 80);
            label25.Location = new Point(164, 191);
            label25.Name = "label25";
            label25.Size = new Size(104, 16);
            label25.TabIndex = 173;
            label25.Text = "Data de Abertura";
            // 
            // textDataPrevista
            // 
            textDataPrevista.Location = new Point(334, 210);
            textDataPrevista.Mask = "00/00/0000 ";
            textDataPrevista.Name = "textDataPrevista";
            textDataPrevista.Size = new Size(164, 29);
            textDataPrevista.TabIndex = 172;
            textDataPrevista.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textDataPrevista.ValidatingType = typeof(DateTime);
            // 
            // textDataAtual
            // 
            textDataAtual.Location = new Point(164, 210);
            textDataAtual.Mask = "00/00/0000 ";
            textDataAtual.Name = "textDataAtual";
            textDataAtual.Size = new Size(164, 29);
            textDataAtual.TabIndex = 171;
            textDataAtual.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textDataAtual.ValidatingType = typeof(DateTime);
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 9.75F);
            label24.ForeColor = Color.FromArgb(44, 62, 80);
            label24.Location = new Point(831, 137);
            label24.Name = "label24";
            label24.Size = new Size(45, 16);
            label24.TabIndex = 169;
            label24.Text = "Status";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 9.75F);
            label23.ForeColor = Color.FromArgb(44, 62, 80);
            label23.Location = new Point(669, 136);
            label23.Name = "label23";
            label23.Size = new Size(65, 16);
            label23.TabIndex = 168;
            label23.Text = "Prioridade";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 9.75F);
            label22.ForeColor = Color.FromArgb(44, 62, 80);
            label22.Location = new Point(1201, 136);
            label22.Name = "label22";
            label22.Size = new Size(84, 16);
            label22.TabIndex = 165;
            label22.Text = "Tempo Gasto";
            // 
            // textTempoGasto
            // 
            textTempoGasto.Location = new Point(1201, 155);
            textTempoGasto.Mask = "90:00";
            textTempoGasto.Name = "textTempoGasto";
            textTempoGasto.Size = new Size(145, 29);
            textTempoGasto.TabIndex = 164;
            textTempoGasto.ValidatingType = typeof(DateTime);
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9.75F);
            label21.ForeColor = Color.FromArgb(44, 62, 80);
            label21.Location = new Point(12, 136);
            label21.Name = "label21";
            label21.Size = new Size(101, 16);
            label21.TabIndex = 163;
            label21.Text = "Peças Trocadas";
            // 
            // textPeçaTrocada
            // 
            textPeçaTrocada.Location = new Point(12, 155);
            textPeçaTrocada.Multiline = true;
            textPeçaTrocada.Name = "textPeçaTrocada";
            textPeçaTrocada.ReadOnly = true;
            textPeçaTrocada.Size = new Size(302, 29);
            textPeçaTrocada.TabIndex = 162;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Enabled = false;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.lupa;
            button5.Location = new Point(210, 49);
            button5.Name = "button5";
            button5.Size = new Size(26, 23);
            button5.TabIndex = 161;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Enabled = false;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.lupa;
            button4.Location = new Point(279, 99);
            button4.Name = "button4";
            button4.Size = new Size(26, 23);
            button4.TabIndex = 160;
            button4.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 9.75F);
            label20.ForeColor = Color.FromArgb(44, 62, 80);
            label20.Location = new Point(12, 82);
            label20.Name = "label20";
            label20.Size = new Size(134, 16);
            label20.TabIndex = 67;
            label20.Text = "Serviço Executado F2";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F);
            label19.ForeColor = Color.FromArgb(44, 62, 80);
            label19.Location = new Point(834, 83);
            label19.Name = "label19";
            label19.Size = new Size(75, 16);
            label19.TabIndex = 65;
            label19.Text = "Diagnóstico";
            // 
            // textServico
            // 
            textServico.Location = new Point(12, 101);
            textServico.Multiline = true;
            textServico.Name = "textServico";
            textServico.ReadOnly = true;
            textServico.Size = new Size(261, 29);
            textServico.TabIndex = 66;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F);
            label18.ForeColor = Color.FromArgb(44, 62, 80);
            label18.Location = new Point(902, 30);
            label18.Name = "label18";
            label18.Size = new Size(82, 16);
            label18.TabIndex = 63;
            label18.Text = "Observações";
            // 
            // textDiagnostico
            // 
            textDiagnostico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDiagnostico.Location = new Point(834, 101);
            textDiagnostico.Multiline = true;
            textDiagnostico.Name = "textDiagnostico";
            textDiagnostico.ReadOnly = true;
            textDiagnostico.Size = new Size(371, 29);
            textDiagnostico.TabIndex = 64;
            // 
            // textObservacao
            // 
            textObservacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textObservacao.Location = new Point(902, 49);
            textObservacao.Multiline = true;
            textObservacao.Name = "textObservacao";
            textObservacao.ReadOnly = true;
            textObservacao.Size = new Size(303, 29);
            textObservacao.TabIndex = 62;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F);
            label17.ForeColor = Color.FromArgb(44, 62, 80);
            label17.Location = new Point(320, 136);
            label17.Name = "label17";
            label17.Size = new Size(47, 16);
            label17.TabIndex = 61;
            label17.Text = "Defeito";
            // 
            // textDefeito
            // 
            textDefeito.Location = new Point(320, 155);
            textDefeito.Multiline = true;
            textDefeito.Name = "textDefeito";
            textDefeito.ReadOnly = true;
            textDefeito.Size = new Size(343, 29);
            textDefeito.TabIndex = 60;
            // 
            // textNumeroSerie
            // 
            textNumeroSerie.Location = new Point(704, 49);
            textNumeroSerie.Multiline = true;
            textNumeroSerie.Name = "textNumeroSerie";
            textNumeroSerie.ReadOnly = true;
            textNumeroSerie.Size = new Size(192, 29);
            textNumeroSerie.TabIndex = 59;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F);
            label16.ForeColor = Color.FromArgb(44, 62, 80);
            label16.Location = new Point(704, 30);
            label16.Name = "label16";
            label16.Size = new Size(104, 16);
            label16.TabIndex = 58;
            label16.Text = "Número de Série";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(423, 30);
            label5.Name = "label5";
            label5.Size = new Size(49, 16);
            label5.TabIndex = 57;
            label5.Text = "Modelo";
            // 
            // textModelo
            // 
            textModelo.Location = new Point(423, 49);
            textModelo.Multiline = true;
            textModelo.Name = "textModelo";
            textModelo.ReadOnly = true;
            textModelo.Size = new Size(275, 29);
            textModelo.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F);
            label9.ForeColor = Color.FromArgb(44, 62, 80);
            label9.Location = new Point(230, 30);
            label9.Name = "label9";
            label9.Size = new Size(43, 16);
            label9.TabIndex = 55;
            label9.Text = "Marca";
            // 
            // textMarca
            // 
            textMarca.Location = new Point(242, 49);
            textMarca.Multiline = true;
            textMarca.Name = "textMarca";
            textMarca.ReadOnly = true;
            textMarca.Size = new Size(175, 29);
            textMarca.TabIndex = 54;
            // 
            // textEquipamento
            // 
            textEquipamento.Location = new Point(12, 49);
            textEquipamento.Multiline = true;
            textEquipamento.Name = "textEquipamento";
            textEquipamento.ReadOnly = true;
            textEquipamento.Size = new Size(192, 29);
            textEquipamento.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F);
            label14.ForeColor = Color.FromArgb(44, 62, 80);
            label14.Location = new Point(12, 30);
            label14.Name = "label14";
            label14.Size = new Size(102, 16);
            label14.TabIndex = 52;
            label14.Text = "Equipamento F3";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(0, 483);
            panel2.Name = "panel2";
            panel2.Size = new Size(1522, 357);
            panel2.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(textTotal);
            groupBox4.Controls.Add(label30);
            groupBox4.Controls.Add(label28);
            groupBox4.Controls.Add(texteDesconto);
            groupBox4.Controls.Add(label29);
            groupBox4.Controls.Add(textSubTotal);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(1117, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(405, 357);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pagamento";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(0, 64, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(47, 297);
            button6.Name = "button6";
            button6.Size = new Size(330, 48);
            button6.TabIndex = 15;
            button6.Text = "Finalizar F5";
            button6.UseVisualStyleBackColor = false;
            // 
            // textTotal
            // 
            textTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTotal.BackColor = Color.FromArgb(0, 66, 100);
            textTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTotal.ForeColor = Color.White;
            textTotal.Location = new Point(47, 226);
            textTotal.Multiline = true;
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(330, 53);
            textTotal.TabIndex = 14;
            textTotal.Text = "0,00";
            textTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.FromArgb(0, 66, 100);
            label30.Location = new Point(47, 193);
            label30.Name = "label30";
            label30.Size = new Size(327, 30);
            label30.TabIndex = 13;
            label30.Text = "Total a Pagar";
            label30.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label28.BackColor = Color.Transparent;
            label28.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.FromArgb(0, 66, 100);
            label28.Location = new Point(50, 106);
            label28.Name = "label28";
            label28.Size = new Size(327, 25);
            label28.TabIndex = 12;
            label28.Text = "Desconto";
            label28.TextAlign = ContentAlignment.MiddleRight;
            // 
            // texteDesconto
            // 
            texteDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            texteDesconto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            texteDesconto.Location = new Point(50, 134);
            texteDesconto.Multiline = true;
            texteDesconto.Name = "texteDesconto";
            texteDesconto.PlaceholderText = "0,00";
            texteDesconto.Size = new Size(327, 40);
            texteDesconto.TabIndex = 11;
            texteDesconto.TextAlign = HorizontalAlignment.Right;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.FromArgb(0, 66, 100);
            label29.Location = new Point(50, 25);
            label29.Name = "label29";
            label29.Size = new Size(327, 25);
            label29.TabIndex = 10;
            label29.Text = "Sub Total";
            label29.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textSubTotal
            // 
            textSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSubTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textSubTotal.Location = new Point(50, 53);
            textSubTotal.Multiline = true;
            textSubTotal.Name = "textSubTotal";
            textSubTotal.PlaceholderText = "0,00";
            textSubTotal.Size = new Size(327, 40);
            textSubTotal.TabIndex = 9;
            textSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelContadorDados);
            groupBox3.Controls.Add(textBuscarOs);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1117, 357);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordemse de Serviços";
            // 
            // labelContadorDados
            // 
            labelContadorDados.Dock = DockStyle.Right;
            labelContadorDados.ForeColor = Color.FromArgb(0, 66, 100);
            labelContadorDados.Location = new Point(922, 201);
            labelContadorDados.Name = "labelContadorDados";
            labelContadorDados.Size = new Size(192, 53);
            labelContadorDados.TabIndex = 5;
            labelContadorDados.Text = "Total Encontrado:";
            labelContadorDados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBuscarOs
            // 
            textBuscarOs.BackColor = Color.FromArgb(255, 255, 192);
            textBuscarOs.Location = new Point(6, 216);
            textBuscarOs.Multiline = true;
            textBuscarOs.Name = "textBuscarOs";
            textBuscarOs.PlaceholderText = "Cod/Cpf/N.OS";
            textBuscarOs.Size = new Size(471, 32);
            textBuscarOs.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 66, 100);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(labelNumeroOS);
            panel3.Dock = DockStyle.Bottom;
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(3, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(1111, 100);
            panel3.TabIndex = 3;
            // 
            // labelNumeroOS
            // 
            labelNumeroOS.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumeroOS.ForeColor = Color.White;
            labelNumeroOS.Location = new Point(317, 33);
            labelNumeroOS.Name = "labelNumeroOS";
            labelNumeroOS.Size = new Size(427, 47);
            labelNumeroOS.TabIndex = 0;
            labelNumeroOS.Text = "Numero OS";
            labelNumeroOS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, CodigoOs, NomeCliente, CpfCnpj, Telefone, Garantia, Numero, Servico, Diagnostico, Tecnico, Peça, Defeito, TempoGasto, DataAbertura, PrevisaoEntrega, DataEntrada, Prioridade, Status, WhatasApp, ValorTotalPagar, FormaPagamento, Atendente, ValorPeca });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1111, 176);
            dataGridView1.TabIndex = 2;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // CodigoOs
            // 
            CodigoOs.HeaderText = "Codigo Os";
            CodigoOs.Name = "CodigoOs";
            CodigoOs.ReadOnly = true;
            CodigoOs.Width = 150;
            // 
            // NomeCliente
            // 
            NomeCliente.HeaderText = "Nome do Cliente";
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            NomeCliente.Width = 350;
            // 
            // CpfCnpj
            // 
            CpfCnpj.HeaderText = "Cpf/Cnpj";
            CpfCnpj.Name = "CpfCnpj";
            CpfCnpj.ReadOnly = true;
            CpfCnpj.Width = 150;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 150;
            // 
            // Garantia
            // 
            Garantia.HeaderText = "Garantia";
            Garantia.Name = "Garantia";
            Garantia.ReadOnly = true;
            // 
            // Numero
            // 
            Numero.HeaderText = "Numero";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            Numero.Width = 120;
            // 
            // Servico
            // 
            Servico.HeaderText = "Serviço";
            Servico.Name = "Servico";
            Servico.ReadOnly = true;
            Servico.Width = 300;
            // 
            // Diagnostico
            // 
            Diagnostico.HeaderText = "Diagnostico";
            Diagnostico.Name = "Diagnostico";
            Diagnostico.ReadOnly = true;
            Diagnostico.Width = 400;
            // 
            // Tecnico
            // 
            Tecnico.HeaderText = "Tecnico";
            Tecnico.Name = "Tecnico";
            Tecnico.ReadOnly = true;
            Tecnico.Width = 250;
            // 
            // Peça
            // 
            Peça.HeaderText = "Peça";
            Peça.Name = "Peça";
            Peça.ReadOnly = true;
            Peça.Width = 200;
            // 
            // Defeito
            // 
            Defeito.HeaderText = "Defeito";
            Defeito.Name = "Defeito";
            Defeito.ReadOnly = true;
            Defeito.Width = 300;
            // 
            // TempoGasto
            // 
            TempoGasto.HeaderText = "Tempo Gasto";
            TempoGasto.Name = "TempoGasto";
            TempoGasto.ReadOnly = true;
            TempoGasto.Width = 150;
            // 
            // DataAbertura
            // 
            DataAbertura.HeaderText = "Data Abertura";
            DataAbertura.Name = "DataAbertura";
            DataAbertura.ReadOnly = true;
            DataAbertura.Width = 150;
            // 
            // PrevisaoEntrega
            // 
            PrevisaoEntrega.HeaderText = "Previsão de Entrega";
            PrevisaoEntrega.Name = "PrevisaoEntrega";
            PrevisaoEntrega.ReadOnly = true;
            PrevisaoEntrega.Width = 150;
            // 
            // DataEntrada
            // 
            DataEntrada.HeaderText = "Data Entrada";
            DataEntrada.Name = "DataEntrada";
            DataEntrada.ReadOnly = true;
            // 
            // Prioridade
            // 
            Prioridade.HeaderText = "Prioridade";
            Prioridade.Name = "Prioridade";
            Prioridade.ReadOnly = true;
            Prioridade.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // WhatasApp
            // 
            WhatasApp.HeaderText = "WhatasApp";
            WhatasApp.Name = "WhatasApp";
            WhatasApp.ReadOnly = true;
            WhatasApp.Width = 150;
            // 
            // ValorTotalPagar
            // 
            ValorTotalPagar.HeaderText = "Valor Total Pagar";
            ValorTotalPagar.Name = "ValorTotalPagar";
            ValorTotalPagar.ReadOnly = true;
            ValorTotalPagar.Width = 150;
            // 
            // FormaPagamento
            // 
            FormaPagamento.HeaderText = "Forma  de Pagamento";
            FormaPagamento.Name = "FormaPagamento";
            FormaPagamento.ReadOnly = true;
            FormaPagamento.Width = 200;
            // 
            // Atendente
            // 
            Atendente.HeaderText = "Atendente";
            Atendente.Name = "Atendente";
            Atendente.ReadOnly = true;
            Atendente.Width = 250;
            // 
            // ValorPeca
            // 
            ValorPeca.HeaderText = "Valor da Peça";
            ValorPeca.Name = "ValorPeca";
            ValorPeca.ReadOnly = true;
            // 
            // label1InfoOperador
            // 
            label1InfoOperador.AccessibleRole = AccessibleRole.OutlineButton;
            label1InfoOperador.BackColor = Color.FromArgb(0, 66, 100);
            label1InfoOperador.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1InfoOperador.ForeColor = Color.White;
            label1InfoOperador.Image = Properties.Resources.operador_de_telefone;
            label1InfoOperador.ImageAlign = ContentAlignment.MiddleLeft;
            label1InfoOperador.Location = new Point(3, 4);
            label1InfoOperador.Name = "label1InfoOperador";
            label1InfoOperador.Size = new Size(124, 35);
            label1InfoOperador.TabIndex = 5;
            label1InfoOperador.Text = "Operador:";
            label1InfoOperador.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDataHora
            // 
            labelDataHora.BackColor = Color.FromArgb(0, 66, 100);
            labelDataHora.Font = new Font("Segoe UI", 12F);
            labelDataHora.ForeColor = Color.White;
            labelDataHora.Location = new Point(1316, 4);
            labelDataHora.Name = "labelDataHora";
            labelDataHora.Size = new Size(206, 35);
            labelDataHora.TabIndex = 6;
            labelDataHora.Text = "Data";
            labelDataHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(88, 35);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 41;
            label6.Text = "Codigo OS";
            // 
            // textCodOs
            // 
            textCodOs.Location = new Point(88, 54);
            textCodOs.Multiline = true;
            textCodOs.Name = "textCodOs";
            textCodOs.ReadOnly = true;
            textCodOs.Size = new Size(81, 29);
            textCodOs.TabIndex = 47;
            // 
            // textCodCliente
            // 
            textCodCliente.Location = new Point(175, 54);
            textCodCliente.Multiline = true;
            textCodCliente.Name = "textCodCliente";
            textCodCliente.ReadOnly = true;
            textCodCliente.Size = new Size(91, 29);
            textCodCliente.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(175, 35);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 49;
            label2.Text = "Codigo Cliente";
            // 
            // textNomeCliente
            // 
            textNomeCliente.Location = new Point(272, 54);
            textNomeCliente.Multiline = true;
            textNomeCliente.Name = "textNomeCliente";
            textNomeCliente.ReadOnly = true;
            textNomeCliente.Size = new Size(310, 29);
            textNomeCliente.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(270, 35);
            label3.Name = "label3";
            label3.Size = new Size(103, 16);
            label3.TabIndex = 51;
            label3.Text = "Nome do Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(615, 34);
            label4.Name = "label4";
            label4.Size = new Size(56, 16);
            label4.TabIndex = 53;
            label4.Text = "Cpf/Cnpj";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(766, 33);
            label7.Name = "label7";
            label7.Size = new Size(58, 16);
            label7.TabIndex = 56;
            label7.Text = "Telefone ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(918, 33);
            label8.Name = "label8";
            label8.Size = new Size(68, 16);
            label8.TabIndex = 58;
            label8.Text = "WhatsApp";
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
            btnBuscaBairro.Location = new Point(592, 54);
            btnBuscaBairro.Name = "btnBuscaBairro";
            btnBuscaBairro.Size = new Size(23, 23);
            btnBuscaBairro.TabIndex = 160;
            btnBuscaBairro.UseVisualStyleBackColor = false;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial", 9.75F);
            label31.ForeColor = Color.FromArgb(44, 62, 80);
            label31.Location = new Point(12, 35);
            label31.Name = "label31";
            label31.Size = new Size(51, 16);
            label31.TabIndex = 161;
            label31.Text = "Codigo ";
            // 
            // textCod
            // 
            textCod.Location = new Point(12, 54);
            textCod.Multiline = true;
            textCod.Name = "textCod";
            textCod.ReadOnly = true;
            textCod.Size = new Size(70, 29);
            textCod.TabIndex = 162;
            // 
            // textTel
            // 
            textTel.Location = new Point(766, 54);
            textTel.Mask = "(00) 00000-0000";
            textTel.Name = "textTel";
            textTel.Size = new Size(146, 29);
            textTel.TabIndex = 163;
            // 
            // textWhatsApp
            // 
            textWhatsApp.Location = new Point(918, 54);
            textWhatsApp.Mask = "(00) 00000-0000";
            textWhatsApp.Name = "textWhatsApp";
            textWhatsApp.Size = new Size(162, 29);
            textWhatsApp.TabIndex = 164;
            // 
            // textCpfCnpl
            // 
            textCpfCnpl.Location = new Point(621, 54);
            textCpfCnpl.Name = "textCpfCnpl";
            textCpfCnpl.Size = new Size(136, 29);
            textCpfCnpl.TabIndex = 165;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textCpfCnpl);
            groupBox1.Controls.Add(textWhatsApp);
            groupBox1.Controls.Add(textTel);
            groupBox1.Controls.Add(textCod);
            groupBox1.Controls.Add(label31);
            groupBox1.Controls.Add(btnBuscaBairro);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textNomeCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textCodCliente);
            groupBox1.Controls.Add(textCodOs);
            groupBox1.Controls.Add(label6);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1522, 105);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 66, 100);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1522, 42);
            label1.TabIndex = 0;
            label1.Text = "Ordem de Serviço";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(1111, 100);
            label12.TabIndex = 1;
            label12.Text = "Numero OS";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Left;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(287, 100);
            label13.TabIndex = 2;
            label13.Text = "Status :";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormOrdemServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1522, 840);
            Controls.Add(labelDataHora);
            Controls.Add(label1InfoOperador);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOrdemServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordem de Serviços";
            Load += FormOrdemServico_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnGravar;
        private Button btnNovaOs;
        private Button btnAddServico;
        private Button btnExcluir;
        private Button btnImprimir;
        private TextBox textCpfCnpj;
        private GroupBox groupBox2;
        private TextBox textNumeroSerie;
        private Label label16;
        private Label label5;
        private TextBox textModelo;
        private Label label9;
        private TextBox textMarca;
        private TextBox textEquipamento;
        private Label label14;
        private Label label20;
        private TextBox textServico;
        private Label label19;
        private TextBox textDiagnostico;
        private Label label18;
        private TextBox textObservacao;
        private Label label17;
        private TextBox textDefeito;
        private Button button4;
        private Button button5;
        private Label label21;
        private TextBox textPeçaTrocada;
        private Label label22;
        private MaskedTextBox textTempoGasto;
        private Label label26;
        private Label label25;
        private MaskedTextBox textDataPrevista;
        private MaskedTextBox textDataAtual;
        private Label label24;
        private Label label23;
        private Label label27;
        private ComboBox comboBoxResTecnico;
        private Panel panel2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private Label label28;
        private TextBox texteDesconto;
        private Label label29;
        private TextBox textSubTotal;
        private TextBox textTotal;
        private Label label30;
        private Panel panel3;
        private Label labelNumeroOS;
        private TextBox textBuscarOs;
        private Label labelContadorDados;
        private TextBox textValor;
        private Label label33;
        private Label label1InfoOperador;
        private Button button6;
        private ComboBox comboStatus;
        private ComboBox comboPrioridade;
        private Button btnSair;
        private Label label34;
        private MaskedTextBox textDataGarantia;
        private Label label32;
        private MaskedTextBox textDataEntrada;
        private Label labelDataHora;
        private GroupBox groupBox5;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label6;
        private TextBox textCodOs;
        private TextBox textCodCliente;
        private Label label2;
        private TextBox textNomeCliente;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Button btnBuscaBairro;
        private Label label31;
        private TextBox textCod;
        private MaskedTextBox textTel;
        private MaskedTextBox textWhatsApp;
        private MaskedTextBox textCpfCnpl;
        private GroupBox groupBox1;
        private TextBox textValorPeca;
        private Label label10;
        private Button button1;
        private Label label11;
        private TextBox textPeca;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn CodigoOs;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn CpfCnpj;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewCheckBoxColumn Garantia;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Servico;
        private DataGridViewTextBoxColumn Diagnostico;
        private DataGridViewTextBoxColumn Tecnico;
        private DataGridViewTextBoxColumn Peça;
        private DataGridViewTextBoxColumn Defeito;
        private DataGridViewTextBoxColumn TempoGasto;
        private DataGridViewTextBoxColumn DataAbertura;
        private DataGridViewTextBoxColumn PrevisaoEntrega;
        private DataGridViewTextBoxColumn DataEntrada;
        private DataGridViewTextBoxColumn Prioridade;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn WhatasApp;
        private DataGridViewTextBoxColumn ValorTotalPagar;
        private DataGridViewTextBoxColumn FormaPagamento;
        private DataGridViewTextBoxColumn Atendente;
        private DataGridViewTextBoxColumn ValorPeca;
        private Label label1;
        private Label label12;
        private Label label13;
    }
}