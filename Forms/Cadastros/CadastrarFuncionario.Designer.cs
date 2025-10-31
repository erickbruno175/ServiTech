namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFuncionario));
            tabControl1 = new TabControl();
            tabCadastro = new TabPage();
            groupBox1 = new GroupBox();
            textTel = new MaskedTextBox();
            textCod = new TextBox();
            label18 = new Label();
            groupBox3 = new GroupBox();
            radioButtonVendasExternasSim = new RadioButton();
            groupBox2 = new GroupBox();
            radioButtonAtivoSim = new RadioButton();
            groupBox5 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textInfoAdcionais = new TextBox();
            label15 = new Label();
            label13 = new Label();
            comboBoxCargo = new ComboBox();
            textSalario = new TextBox();
            label12 = new Label();
            textAdmissao = new MaskedTextBox();
            label11 = new Label();
            textComissao = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textUf = new ComboBox();
            textCidade = new TextBox();
            label7 = new Label();
            textBairro = new TextBox();
            label6 = new Label();
            textEndereco = new TextBox();
            label5 = new Label();
            textNascimento = new MaskedTextBox();
            label4 = new Label();
            textRg = new MaskedTextBox();
            label2 = new Label();
            textCpf = new MaskedTextBox();
            label1 = new Label();
            textNome = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            tabConsultas = new TabPage();
            panel3 = new Panel();
            panel2 = new Panel();
            bntNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            groupBox4 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisar = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label14 = new Label();
            comboFiltros = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabConsultas.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCadastro);
            tabControl1.Controls.Add(tabConsultas);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1016, 560);
            tabControl1.TabIndex = 0;
            // 
            // tabCadastro
            // 
            tabCadastro.BorderStyle = BorderStyle.Fixed3D;
            tabCadastro.Controls.Add(groupBox1);
            tabCadastro.Controls.Add(panel1);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(1008, 532);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastrar";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textTel);
            groupBox1.Controls.Add(textCod);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(textInfoAdcionais);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(comboBoxCargo);
            groupBox1.Controls.Add(textSalario);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textAdmissao);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textComissao);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textUf);
            groupBox1.Controls.Add(textCidade);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBairro);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textEndereco);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textNascimento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textRg);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textCpf);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(998, 468);
            groupBox1.TabIndex = 126;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // textTel
            // 
            textTel.Location = new Point(258, 164);
            textTel.Mask = "(00) 00000-0000";
            textTel.Name = "textTel";
            textTel.ReadOnly = true;
            textTel.Size = new Size(143, 23);
            textTel.TabIndex = 164;
            // 
            // textCod
            // 
            textCod.Location = new Point(4, 58);
            textCod.Name = "textCod";
            textCod.ReadOnly = true;
            textCod.Size = new Size(66, 23);
            textCod.TabIndex = 163;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F);
            label18.ForeColor = Color.FromArgb(44, 62, 80);
            label18.Location = new Point(4, 38);
            label18.Name = "label18";
            label18.Size = new Size(47, 16);
            label18.TabIndex = 162;
            label18.Text = "Codigo";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonVendasExternasSim);
            groupBox3.Font = new Font("Arial", 9.75F);
            groupBox3.ForeColor = Color.FromArgb(38, 52, 75);
            groupBox3.Location = new Point(625, 195);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(134, 52);
            groupBox3.TabIndex = 161;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vendas Externas ?";
            // 
            // radioButtonVendasExternasSim
            // 
            radioButtonVendasExternasSim.AutoSize = true;
            radioButtonVendasExternasSim.Enabled = false;
            radioButtonVendasExternasSim.Location = new Point(41, 20);
            radioButtonVendasExternasSim.Name = "radioButtonVendasExternasSim";
            radioButtonVendasExternasSim.Size = new Size(48, 20);
            radioButtonVendasExternasSim.TabIndex = 0;
            radioButtonVendasExternasSim.TabStop = true;
            radioButtonVendasExternasSim.Text = "Sim";
            radioButtonVendasExternasSim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonAtivoSim);
            groupBox2.Font = new Font("Arial", 9.75F);
            groupBox2.ForeColor = Color.FromArgb(38, 52, 75);
            groupBox2.Location = new Point(4, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(89, 55);
            groupBox2.TabIndex = 158;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ativo?";
            // 
            // radioButtonAtivoSim
            // 
            radioButtonAtivoSim.AutoSize = true;
            radioButtonAtivoSim.Enabled = false;
            radioButtonAtivoSim.Location = new Point(18, 19);
            radioButtonAtivoSim.Name = "radioButtonAtivoSim";
            radioButtonAtivoSim.Size = new Size(48, 20);
            radioButtonAtivoSim.TabIndex = 0;
            radioButtonAtivoSim.TabStop = true;
            radioButtonAtivoSim.Text = "Sim";
            radioButtonAtivoSim.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(pictureBox1);
            groupBox5.Location = new Point(647, 261);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(198, 192);
            groupBox5.TabIndex = 157;
            groupBox5.TabStop = false;
            groupBox5.Text = "Foto";
            // 
            // button2
            // 
            button2.Image = Properties.Resources.bin;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(101, 145);
            button2.Name = "button2";
            button2.Size = new Size(91, 37);
            button2.TabIndex = 2;
            button2.Text = "Remover";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.plus;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 145);
            button1.Name = "button1";
            button1.Size = new Size(91, 37);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 114);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textInfoAdcionais
            // 
            textInfoAdcionais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textInfoAdcionais.Location = new Point(4, 261);
            textInfoAdcionais.Name = "textInfoAdcionais";
            textInfoAdcionais.ReadOnly = true;
            textInfoAdcionais.Size = new Size(753, 23);
            textInfoAdcionais.TabIndex = 156;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F);
            label15.ForeColor = Color.FromArgb(38, 52, 75);
            label15.Location = new Point(4, 245);
            label15.Name = "label15";
            label15.Size = new Size(144, 16);
            label15.TabIndex = 155;
            label15.Text = "Informações Adicionais ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F);
            label13.ForeColor = Color.FromArgb(38, 52, 75);
            label13.Location = new Point(384, 195);
            label13.Name = "label13";
            label13.Size = new Size(45, 16);
            label13.TabIndex = 154;
            label13.Text = "Cargo ";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.Enabled = false;
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(384, 212);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(235, 23);
            comboBoxCargo.TabIndex = 153;
            // 
            // textSalario
            // 
            textSalario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSalario.Location = new Point(208, 212);
            textSalario.Name = "textSalario";
            textSalario.ReadOnly = true;
            textSalario.Size = new Size(297, 23);
            textSalario.TabIndex = 152;
            textSalario.Text = "0,00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F);
            label12.ForeColor = Color.FromArgb(38, 52, 75);
            label12.Location = new Point(208, 195);
            label12.Name = "label12";
            label12.Size = new Size(55, 16);
            label12.TabIndex = 151;
            label12.Text = "Salario  ";
            // 
            // textAdmissao
            // 
            textAdmissao.Location = new Point(4, 212);
            textAdmissao.Mask = "00/00/0000";
            textAdmissao.Name = "textAdmissao";
            textAdmissao.ReadOnly = true;
            textAdmissao.Size = new Size(198, 23);
            textAdmissao.TabIndex = 150;
            textAdmissao.ValidatingType = typeof(DateTime);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F);
            label11.ForeColor = Color.FromArgb(38, 52, 75);
            label11.Location = new Point(4, 195);
            label11.Name = "label11";
            label11.Size = new Size(69, 16);
            label11.TabIndex = 149;
            label11.Text = "Admissão ";
            // 
            // textComissao
            // 
            textComissao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textComissao.Location = new Point(407, 164);
            textComissao.Name = "textComissao";
            textComissao.ReadOnly = true;
            textComissao.Size = new Size(255, 23);
            textComissao.TabIndex = 148;
            textComissao.Text = "0,00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(38, 52, 75);
            label10.Location = new Point(407, 148);
            label10.Name = "label10";
            label10.Size = new Size(65, 16);
            label10.TabIndex = 147;
            label10.Text = "Comissão";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F);
            label9.ForeColor = Color.FromArgb(38, 52, 75);
            label9.Location = new Point(258, 148);
            label9.Name = "label9";
            label9.Size = new Size(27, 16);
            label9.TabIndex = 145;
            label9.Text = "Tel ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F);
            label8.ForeColor = Color.FromArgb(38, 52, 75);
            label8.Location = new Point(208, 147);
            label8.Name = "label8";
            label8.Size = new Size(23, 16);
            label8.TabIndex = 144;
            label8.Text = "Uf ";
            // 
            // textUf
            // 
            textUf.Enabled = false;
            textUf.FormattingEnabled = true;
            textUf.Location = new Point(208, 164);
            textUf.Name = "textUf";
            textUf.Size = new Size(44, 23);
            textUf.TabIndex = 143;
            // 
            // textCidade
            // 
            textCidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textCidade.Location = new Point(4, 164);
            textCidade.Name = "textCidade";
            textCidade.ReadOnly = true;
            textCidade.Size = new Size(325, 23);
            textCidade.TabIndex = 142;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.ForeColor = Color.FromArgb(38, 52, 75);
            label7.Location = new Point(4, 148);
            label7.Name = "label7";
            label7.Size = new Size(51, 16);
            label7.TabIndex = 141;
            label7.Text = "Cidade ";
            // 
            // textBairro
            // 
            textBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBairro.Location = new Point(541, 109);
            textBairro.Name = "textBairro";
            textBairro.ReadOnly = true;
            textBairro.Size = new Size(431, 23);
            textBairro.TabIndex = 140;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.ForeColor = Color.FromArgb(38, 52, 75);
            label6.Location = new Point(541, 92);
            label6.Name = "label6";
            label6.Size = new Size(49, 16);
            label6.TabIndex = 139;
            label6.Text = "Bairro :";
            // 
            // textEndereco
            // 
            textEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textEndereco.Location = new Point(208, 109);
            textEndereco.Name = "textEndereco";
            textEndereco.ReadOnly = true;
            textEndereco.Size = new Size(454, 23);
            textEndereco.TabIndex = 138;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(38, 52, 75);
            label5.Location = new Point(208, 92);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 137;
            label5.Text = "Endereço :";
            // 
            // textNascimento
            // 
            textNascimento.Location = new Point(4, 109);
            textNascimento.Mask = "00/00/0000";
            textNascimento.Name = "textNascimento";
            textNascimento.ReadOnly = true;
            textNascimento.Size = new Size(198, 23);
            textNascimento.TabIndex = 136;
            textNascimento.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(38, 52, 75);
            label4.Location = new Point(4, 92);
            label4.Name = "label4";
            label4.Size = new Size(80, 16);
            label4.TabIndex = 135;
            label4.Text = "Nascimento ";
            // 
            // textRg
            // 
            textRg.Location = new Point(611, 58);
            textRg.Mask = "00.000.000-0";
            textRg.Name = "textRg";
            textRg.ReadOnly = true;
            textRg.Size = new Size(174, 23);
            textRg.TabIndex = 134;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(38, 52, 75);
            label2.Location = new Point(611, 41);
            label2.Name = "label2";
            label2.Size = new Size(27, 16);
            label2.TabIndex = 133;
            label2.Text = "Rg ";
            // 
            // textCpf
            // 
            textCpf.Location = new Point(407, 58);
            textCpf.Mask = "000.000.000-00";
            textCpf.Name = "textCpf";
            textCpf.ReadOnly = true;
            textCpf.Size = new Size(198, 23);
            textCpf.TabIndex = 132;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(38, 52, 75);
            label1.Location = new Point(407, 41);
            label1.Name = "label1";
            label1.Size = new Size(30, 16);
            label1.TabIndex = 131;
            label1.Text = "Cpf ";
            // 
            // textNome
            // 
            textNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNome.Location = new Point(76, 58);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(452, 23);
            textNome.TabIndex = 130;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(38, 52, 75);
            label3.Location = new Point(76, 39);
            label3.Name = "label3";
            label3.Size = new Size(49, 16);
            label3.TabIndex = 129;
            label3.Text = "Nome  ";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 477);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 48);
            panel1.TabIndex = 125;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(3, 6);
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
            btnGravar.Location = new Point(97, 6);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 40);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // tabConsultas
            // 
            tabConsultas.Controls.Add(panel3);
            tabConsultas.Controls.Add(panel2);
            tabConsultas.Controls.Add(groupBox4);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3);
            tabConsultas.Size = new Size(881, 532);
            tabConsultas.TabIndex = 1;
            tabConsultas.Text = "Consultas";
            tabConsultas.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 367);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(bntNovo);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnExcluir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 56);
            panel2.TabIndex = 3;
            // 
            // bntNovo
            // 
            bntNovo.Image = Properties.Resources.plus;
            bntNovo.Location = new Point(267, 7);
            bntNovo.Name = "bntNovo";
            bntNovo.Size = new Size(101, 40);
            bntNovo.TabIndex = 27;
            bntNovo.Text = " Novo";
            bntNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.marca_de_verificacao;
            btnEditar.Location = new Point(141, 7);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Selecionar";
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
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBoxTodos);
            groupBox4.Controls.Add(btnPesquisar);
            groupBox4.Controls.Add(textDadosPesquisa);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(comboModelo);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(comboFiltros);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(875, 103);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Campos de Pesquisa";
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(811, 19);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 35;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(758, 70);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(113, 29);
            btnPesquisar.TabIndex = 34;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(368, 43);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(503, 23);
            textDadosPesquisa.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F);
            label16.ForeColor = Color.FromArgb(44, 62, 80);
            label16.Location = new Point(368, 24);
            label16.Name = "label16";
            label16.Size = new Size(117, 16);
            label16.TabIndex = 32;
            label16.Text = "Dados a Pesquisar";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F);
            label17.ForeColor = Color.FromArgb(44, 62, 80);
            label17.Location = new Point(184, 19);
            label17.Name = "label17";
            label17.Size = new Size(122, 16);
            label17.TabIndex = 31;
            label17.Text = "Modelo de Consulta";
            // 
            // comboModelo
            // 
            comboModelo.FormattingEnabled = true;
            comboModelo.Location = new Point(184, 43);
            comboModelo.Name = "comboModelo";
            comboModelo.Size = new Size(178, 23);
            comboModelo.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F);
            label14.ForeColor = Color.FromArgb(44, 62, 80);
            label14.Location = new Point(3, 24);
            label14.Name = "label14";
            label14.Size = new Size(43, 16);
            label14.TabIndex = 29;
            label14.Text = "Filtros";
            // 
            // comboFiltros
            // 
            comboFiltros.FormattingEnabled = true;
            comboFiltros.Location = new Point(0, 43);
            comboFiltros.Name = "comboFiltros";
            comboFiltros.Size = new Size(178, 23);
            comboFiltros.TabIndex = 28;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // CadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 560);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "CadastrarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Funcionarios";
            Load += CadastrarFuncionario_Load;
            KeyDown += LiberarCamposParaNovoCadastro_KeyDown;
            tabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tabConsultas.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCadastro;
        private Panel panel1;
        private Button btnNovo;
        private Button btnGravar;
        private TabPage tabConsultas;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox4;
        private CheckBox checkBoxTodos;
        private Button btnPesquisar;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label14;
        private ComboBox comboFiltros;
        private Panel panel3;
        private Panel panel2;
        private Button btnExcluir;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private RadioButton radioButtonVendasExternasSim;
        private GroupBox groupBox2;
        private RadioButton radioButtonAtivoSim;
        private GroupBox groupBox5;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textInfoAdcionais;
        private Label label15;
        private Label label13;
        private ComboBox comboBoxCargo;
        private TextBox textSalario;
        private Label label12;
        private MaskedTextBox textAdmissao;
        private Label label11;
        private TextBox textComissao;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox textUf;
        private TextBox textCidade;
        private Label label7;
        private TextBox textBairro;
        private Label label6;
        private TextBox textEndereco;
        private Label label5;
        private MaskedTextBox textNascimento;
        private Label label4;
        private MaskedTextBox textRg;
        private Label label2;
        private MaskedTextBox textCpf;
        private Label label1;
        private TextBox textNome;
        private Label label3;
        private TextBox textCod;
        private Label label18;
        private MaskedTextBox textTel;
        private Button btnEditar;
        private Button bntNovo;
    }
}