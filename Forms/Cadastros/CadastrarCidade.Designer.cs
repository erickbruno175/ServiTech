namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarCidade
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
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            textCodigoCidade = new TextBox();
            label3 = new Label();
            btnBuscaPais = new Button();
            textNomePais = new TextBox();
            label10 = new Label();
            textCodigoPais = new TextBox();
            label5 = new Label();
            labelUf = new Label();
            comboBoxUf = new ComboBox();
            textNomeCidade = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisar = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label2 = new Label();
            comboFiltros = new ComboBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            NomeCidade = new DataGridViewTextBoxColumn();
            Uf = new DataGridViewTextBoxColumn();
            DataCriacao = new DataGridViewTextBoxColumn();
            UltimaAtalização = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
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
            tabControl1.Size = new Size(1020, 456);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1012, 428);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 52);
            panel1.TabIndex = 2;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(5, 5);
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
            btnCancelar.Location = new Point(193, 5);
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
            btnGravar.Location = new Point(99, 5);
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
            groupBox1.Controls.Add(textCodigoCidade);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnBuscaPais);
            groupBox1.Controls.Add(textNomePais);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textCodigoPais);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelUf);
            groupBox1.Controls.Add(comboBoxUf);
            groupBox1.Controls.Add(textNomeCidade);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            groupBox1.Resize += groupBox1_Resize;
            // 
            // textCodigoCidade
            // 
            textCodigoCidade.Location = new Point(4, 38);
            textCodigoCidade.Name = "textCodigoCidade";
            textCodigoCidade.ReadOnly = true;
            textCodigoCidade.Size = new Size(64, 23);
            textCodigoCidade.TabIndex = 40;
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
            // btnBuscaPais
            // 
            btnBuscaPais.BackColor = Color.Transparent;
            btnBuscaPais.Enabled = false;
            btnBuscaPais.FlatAppearance.BorderSize = 0;
            btnBuscaPais.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaPais.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaPais.FlatStyle = FlatStyle.Flat;
            btnBuscaPais.Image = Properties.Resources.lupa;
            btnBuscaPais.Location = new Point(951, 92);
            btnBuscaPais.Name = "btnBuscaPais";
            btnBuscaPais.Size = new Size(25, 23);
            btnBuscaPais.TabIndex = 38;
            btnBuscaPais.UseVisualStyleBackColor = false;
            // 
            // textNomePais
            // 
            textNomePais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNomePais.Location = new Point(74, 93);
            textNomePais.Name = "textNomePais";
            textNomePais.ReadOnly = true;
            textNomePais.Size = new Size(871, 23);
            textNomePais.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(74, 73);
            label10.Name = "label10";
            label10.Size = new Size(33, 16);
            label10.TabIndex = 36;
            label10.Text = "Pais";
            // 
            // textCodigoPais
            // 
            textCodigoPais.Location = new Point(6, 93);
            textCodigoPais.Name = "textCodigoPais";
            textCodigoPais.ReadOnly = true;
            textCodigoPais.Size = new Size(62, 23);
            textCodigoPais.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(6, 73);
            label5.Name = "label5";
            label5.Size = new Size(47, 16);
            label5.TabIndex = 34;
            label5.Text = "Codigo";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Font = new Font("Arial", 9.75F);
            labelUf.ForeColor = Color.FromArgb(44, 62, 80);
            labelUf.Location = new Point(951, 19);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(19, 16);
            labelUf.TabIndex = 25;
            labelUf.Text = "Uf";
            // 
            // comboBoxUf
            // 
            comboBoxUf.Enabled = false;
            comboBoxUf.FormattingEnabled = true;
            comboBoxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxUf.Location = new Point(951, 38);
            comboBoxUf.Name = "comboBoxUf";
            comboBoxUf.Size = new Size(25, 23);
            comboBoxUf.TabIndex = 24;
            // 
            // textNomeCidade
            // 
            textNomeCidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNomeCidade.Location = new Point(74, 38);
            textNomeCidade.Name = "textNomeCidade";
            textNomeCidade.ReadOnly = true;
            textNomeCidade.Size = new Size(871, 23);
            textNomeCidade.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(74, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 22;
            label1.Text = "Cidade";
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
            tabPage2.Size = new Size(1012, 428);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 355);
            panel3.Name = "panel3";
            panel3.Size = new Size(1002, 66);
            panel3.TabIndex = 3;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.novo;
            button3.Location = new Point(142, 19);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 15;
            button3.Text = "Editar";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.lixeira;
            button2.Location = new Point(7, 19);
            button2.Name = "button2";
            button2.Size = new Size(129, 40);
            button2.TabIndex = 16;
            button2.Text = "Excluir F7";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(1004, 240);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxTodos);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Controls.Add(textDadosPesquisa);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboModelo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboFiltros);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1002, 97);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            groupBox2.Resize += groupBox2_Resize;
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(938, 16);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(883, 62);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(113, 29);
            btnPesquisar.TabIndex = 26;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(374, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(622, 23);
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, NomeCidade, Uf, DataCriacao, UltimaAtalização });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1000, 236);
            dataGridView1.TabIndex = 1;
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
            // NomeCidade
            // 
            NomeCidade.HeaderText = "Nome da Cidade";
            NomeCidade.Name = "NomeCidade";
            NomeCidade.Width = 350;
            // 
            // Uf
            // 
            Uf.HeaderText = "Uf";
            Uf.Name = "Uf";
            // 
            // DataCriacao
            // 
            DataCriacao.HeaderText = "Data de Criação";
            DataCriacao.Name = "DataCriacao";
            DataCriacao.Width = 250;
            // 
            // UltimaAtalização
            // 
            UltimaAtalização.HeaderText = "Ultima Atualização";
            UltimaAtalização.Name = "UltimaAtalização";
            UltimaAtalização.Width = 250;
            // 
            // CadastrarCidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 456);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "CadastrarCidade";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Cidade";
            Load += CadastrarPais_Load;
            KeyDown += LiberarCamposParaNovoCadastro_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnPesquisar;
        private Panel panel2;
        private CheckBox checkBoxTodos;
        private TextBox textNomeCidade;
        private Label label1;
        private Label labelUf;
        private ComboBox comboBoxUf;
        private TextBox textCodigoPais;
        private Label label5;
        private TextBox textNomePais;
        private Label label10;
        private Panel panel1;
        private Button btnBuscaPais;
        private TextBox textCodigoCidade;
        private Label label3;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnGravar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NomeCidade;
        private DataGridViewTextBoxColumn Uf;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn UltimaAtalização;
    }
}