namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarGrupo
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
            tabPage2 = new TabPage();
            panel1 = new Panel();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox3 = new GroupBox();
            radioAtivoNao = new RadioButton();
            radioAtivoSim = new RadioButton();
            textBox1 = new TextBox();
            label2 = new Label();
            textNomePais = new TextBox();
            label10 = new Label();
            textCodigoPais = new TextBox();
            label1 = new Label();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisarPais = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label3 = new Label();
            comboFiltros = new ComboBox();
            panel2 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Size = new Size(1108, 499);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textNomePais);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textCodigoPais);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1100, 471);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 58);
            panel1.TabIndex = 77;
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
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(radioAtivoNao);
            groupBox3.Controls.Add(radioAtivoSim);
            groupBox3.Font = new Font("Arial", 9.75F);
            groupBox3.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox3.Location = new Point(338, 78);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(166, 57);
            groupBox3.TabIndex = 76;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ativo ?";
            // 
            // radioAtivoNao
            // 
            radioAtivoNao.Enabled = false;
            radioAtivoNao.Location = new Point(66, 19);
            radioAtivoNao.Name = "radioAtivoNao";
            radioAtivoNao.Size = new Size(58, 22);
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
            // textBox1
            // 
            textBox1.Location = new Point(8, 96);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(324, 23);
            textBox1.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(8, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 28;
            label2.Text = "Descrição";
            // 
            // textNomePais
            // 
            textNomePais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNomePais.Location = new Point(78, 41);
            textNomePais.Name = "textNomePais";
            textNomePais.ReadOnly = true;
            textNomePais.Size = new Size(1014, 23);
            textNomePais.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(78, 21);
            label10.Name = "label10";
            label10.Size = new Size(98, 16);
            label10.TabIndex = 26;
            label10.Text = "Nome do Grupo";
            // 
            // textCodigoPais
            // 
            textCodigoPais.Location = new Point(8, 41);
            textCodigoPais.Name = "textCodigoPais";
            textCodigoPais.ReadOnly = true;
            textCodigoPais.Size = new Size(64, 23);
            textCodigoPais.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(8, 21);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 24;
            label1.Text = "Codigo";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1100, 471);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Consultas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxTodos);
            groupBox2.Controls.Add(btnPesquisarPais);
            groupBox2.Controls.Add(textDadosPesquisa);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboModelo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboFiltros);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1094, 97);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(1030, 16);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarPais
            // 
            btnPesquisarPais.Image = Properties.Resources.lupa;
            btnPesquisarPais.Location = new Point(976, 62);
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
            textDadosPesquisa.Size = new Size(714, 23);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(6, 16);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 20;
            label3.Text = "Filtros";
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
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnExcluir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 412);
            panel2.Name = "panel2";
            panel2.Size = new Size(1094, 56);
            panel2.TabIndex = 3;
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(3, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(1094, 300);
            panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Descricao });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1090, 296);
            dataGridView1.TabIndex = 0;
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
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            // 
            // CadastrarGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 499);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "CadastrarGrupo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Grupos";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textNomePais;
        private Label label10;
        private TextBox textCodigoPais;
        private Label label1;
        private GroupBox groupBox3;
        private RadioButton radioAtivoNao;
        private RadioButton radioAtivoSim;
        private Panel panel1;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnGravar;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private CheckBox checkBoxTodos;
        private Button btnPesquisarPais;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label3;
        private ComboBox comboFiltros;
        private Panel panel2;
        private Button btnEditar;
        private Button btnExcluir;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
    }
}