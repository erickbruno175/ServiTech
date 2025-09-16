namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarBairro
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
            panel1 = new Panel();
            btnNovo = new Button();
            btnSair = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            textCodigoBairro = new TextBox();
            label3 = new Label();
            btnBuscaMunici = new Button();
            textNomeCidade = new TextBox();
            label5 = new Label();
            labelUf = new Label();
            comboBoxUf = new ComboBox();
            textBairro = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            NomeBairro = new DataGridViewTextBoxColumn();
            Uf = new DataGridViewTextBoxColumn();
            NomeCidade = new DataGridViewTextBoxColumn();
            NomePais = new DataGridViewTextBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            UltimaAtulizacao = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisarPais = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label2 = new Label();
            comboFiltros = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(962, 478);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(954, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 52);
            panel1.TabIndex = 2;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(5, 5);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(129, 40);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo Bairro -F4";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += LiberararCamposParaNovoCadastro_Click;
            btnNovo.KeyDown += LiberararCamposParaNovoCadastro_Click;
            // 
            // btnSair
            // 
            btnSair.Image = Properties.Resources.sair;
            btnSair.Location = new Point(846, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(93, 40);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sair";
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += SairFormCadastroBairro;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(275, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar  -F6";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Image = Properties.Resources.salvar;
            btnGravar.Location = new Point(140, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(129, 40);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar - F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textCodigoBairro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnBuscaMunici);
            groupBox1.Controls.Add(textNomeCidade);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelUf);
            groupBox1.Controls.Add(comboBoxUf);
            groupBox1.Controls.Add(textBairro);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(942, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            groupBox1.Resize += groupBox1_Resize;
            // 
            // textCodigoBairro
            // 
            textCodigoBairro.Location = new Point(4, 38);
            textCodigoBairro.Name = "textCodigoBairro";
            textCodigoBairro.ReadOnly = true;
            textCodigoBairro.Size = new Size(64, 23);
            textCodigoBairro.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(4, 18);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 39;
            label3.Text = "Codigo";
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
            btnBuscaMunici.Location = new Point(903, 89);
            btnBuscaMunici.Name = "btnBuscaMunici";
            btnBuscaMunici.Size = new Size(33, 23);
            btnBuscaMunici.TabIndex = 38;
            btnBuscaMunici.UseVisualStyleBackColor = false;
            // 
            // textNomeCidade
            // 
            textNomeCidade.Location = new Point(4, 89);
            textNomeCidade.Name = "textNomeCidade";
            textNomeCidade.ReadOnly = true;
            textNomeCidade.Size = new Size(893, 23);
            textNomeCidade.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(4, 69);
            label5.Name = "label5";
            label5.Size = new Size(74, 16);
            label5.TabIndex = 34;
            label5.Text = "Cidade - F1";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Font = new Font("Arial", 9.75F);
            labelUf.ForeColor = Color.FromArgb(44, 62, 80);
            labelUf.Location = new Point(903, 19);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(19, 16);
            labelUf.TabIndex = 25;
            labelUf.Text = "Uf";
            // 
            // comboBoxUf
            // 
            comboBoxUf.Enabled = false;
            comboBoxUf.FormattingEnabled = true;
            comboBoxUf.Location = new Point(903, 38);
            comboBoxUf.Name = "comboBoxUf";
            comboBoxUf.Size = new Size(33, 23);
            comboBoxUf.TabIndex = 24;
            // 
            // textBairro
            // 
            textBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBairro.Location = new Point(73, 38);
            textBairro.Name = "textBairro";
            textBairro.ReadOnly = true;
            textBairro.Size = new Size(824, 23);
            textBairro.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(73, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 16);
            label1.TabIndex = 22;
            label1.Text = "Nome do Bairro";
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(954, 450);
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
            panel3.Location = new Point(3, 377);
            panel3.Name = "panel3";
            panel3.Size = new Size(944, 66);
            panel3.TabIndex = 3;
            panel3.Resize += panel3_Resize;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.novo;
            btnEditar.Location = new Point(142, 19);
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
            btnExcluir.Location = new Point(7, 19);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(6, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 262);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, NomeBairro, Uf, NomeCidade, NomePais, DataCadastro, UltimaAtulizacao });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(938, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // NomeBairro
            // 
            NomeBairro.HeaderText = "Nome do Bairro";
            NomeBairro.Name = "NomeBairro";
            NomeBairro.Width = 350;
            // 
            // Uf
            // 
            Uf.HeaderText = "Uf";
            Uf.Name = "Uf";
            Uf.Width = 80;
            // 
            // NomeCidade
            // 
            NomeCidade.HeaderText = "Nome da Cidade";
            NomeCidade.Name = "NomeCidade";
            NomeCidade.Width = 250;
            // 
            // NomePais
            // 
            NomePais.HeaderText = "Nome do Pais";
            NomePais.Name = "NomePais";
            NomePais.Width = 250;
            // 
            // DataCadastro
            // 
            DataCadastro.HeaderText = "Data de Cadastro";
            DataCadastro.Name = "DataCadastro";
            DataCadastro.Width = 250;
            // 
            // UltimaAtulizacao
            // 
            UltimaAtulizacao.HeaderText = "Ultima Atualização";
            UltimaAtulizacao.Name = "UltimaAtulizacao";
            UltimaAtulizacao.Width = 250;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(checkBoxTodos);
            groupBox2.Controls.Add(btnPesquisarPais);
            groupBox2.Controls.Add(textDadosPesquisa);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboModelo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboFiltros);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(938, 97);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            groupBox2.Resize += groupBox2_Resize;
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(6, 72);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarPais
            // 
            btnPesquisarPais.Image = Properties.Resources.lupa;
            btnPesquisarPais.Location = new Point(819, 62);
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
            textDadosPesquisa.Size = new Size(558, 23);
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
            // CadastrarBairro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 481);
            Controls.Add(tabControl1);
            Name = "CadastrarBairro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Bairros";
            Load += CadastrarPais_Load;
            KeyDown += LiberararCamposParaNovoCadastro_KeyDown;
            Resize += CadastrarPais_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label17;
        private ComboBox comboModelo;
        private Label label2;
        private ComboBox comboFiltros;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Button btnPesquisarPais;
        private Panel panel2;
        private CheckBox checkBoxTodos;
        private TextBox textBairro;
        private Label label1;
        private Label labelUf;
        private ComboBox comboBoxUf;
        private Panel panel1;
        private Button btnNovo;
        private Button btnSair;
        private Button btnCancelar;
        private Button btnGravar;
        private Panel panel3;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnBuscaMunici;
        private DataGridView dataGridView1;
        private TextBox textCodigoBairro;
        private Label label3;
        private TextBox textNomeCidade;
        private Label label5;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NomeBairro;
        private DataGridViewTextBoxColumn Uf;
        private DataGridViewTextBoxColumn NomeCidade;
        private DataGridViewTextBoxColumn NomePais;
        private DataGridViewTextBoxColumn DataCadastro;
        private DataGridViewTextBoxColumn UltimaAtulizacao;
    }
}