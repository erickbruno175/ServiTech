namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarSubGrupo
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
            btnBuscaCategoriaPagamento = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
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
            groupBox1 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisar = new Button();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label5 = new Label();
            comboFiltros = new ComboBox();
            textDadosPesquisa = new TextBox();
            panel2 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            CodigoGrupo = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            tabControl1.Size = new Size(679, 420);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnBuscaCategoriaPagamento);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
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
            tabPage2.Size = new Size(671, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscaCategoriaPagamento
            // 
            btnBuscaCategoriaPagamento.BackColor = Color.Transparent;
            btnBuscaCategoriaPagamento.FlatAppearance.BorderSize = 0;
            btnBuscaCategoriaPagamento.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaCategoriaPagamento.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaCategoriaPagamento.FlatStyle = FlatStyle.Flat;
            btnBuscaCategoriaPagamento.Image = Properties.Resources.lupa;
            btnBuscaCategoriaPagamento.Location = new Point(634, 96);
            btnBuscaCategoriaPagamento.Name = "btnBuscaCategoriaPagamento";
            btnBuscaCategoriaPagamento.Size = new Size(29, 23);
            btnBuscaCategoriaPagamento.TabIndex = 82;
            btnBuscaCategoriaPagamento.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(338, 96);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(64, 23);
            textBox3.TabIndex = 81;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(338, 76);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 80;
            label4.Text = "Codigo";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(408, 96);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(230, 23);
            textBox2.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(408, 77);
            label3.Name = "label3";
            label3.Size = new Size(129, 16);
            label3.TabIndex = 78;
            label3.Text = "Qual Grupo Pertençe";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 245);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 58);
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
            groupBox3.Location = new Point(8, 125);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(134, 68);
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
            textNomePais.Size = new Size(560, 23);
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
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(671, 392);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Consultas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textDadosPesquisa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(checkBoxTodos);
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(comboModelo);
            groupBox1.Controls.Add(comboFiltros);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Campos de Pesquisa";
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(602, 17);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 34;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(546, 68);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(113, 29);
            btnPesquisar.TabIndex = 33;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F);
            label16.ForeColor = Color.FromArgb(44, 62, 80);
            label16.Location = new Point(371, 20);
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
            label17.Location = new Point(189, 17);
            label17.Name = "label17";
            label17.Size = new Size(122, 16);
            label17.TabIndex = 31;
            label17.Text = "Modelo de Consulta";
            // 
            // comboModelo
            // 
            comboModelo.FormattingEnabled = true;
            comboModelo.Location = new Point(189, 39);
            comboModelo.Name = "comboModelo";
            comboModelo.Size = new Size(178, 23);
            comboModelo.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(43, 16);
            label5.TabIndex = 29;
            label5.Text = "Filtros";
            // 
            // comboFiltros
            // 
            comboFiltros.FormattingEnabled = true;
            comboFiltros.Location = new Point(5, 39);
            comboFiltros.Name = "comboFiltros";
            comboFiltros.Size = new Size(178, 23);
            comboFiltros.TabIndex = 28;
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(371, 39);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(288, 23);
            textDadosPesquisa.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnExcluir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 333);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 56);
            panel2.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
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
            btnExcluir.Enabled = false;
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
            panel3.Location = new Point(3, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(665, 214);
            panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Descricao, CodigoGrupo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(661, 210);
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
            Descricao.Width = 300;
            // 
            // CodigoGrupo
            // 
            CodigoGrupo.HeaderText = "Codigo Grupo";
            CodigoGrupo.Name = "CodigoGrupo";
            CodigoGrupo.Width = 150;
            // 
            // CadastrarSubGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 420);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "CadastrarSubGrupo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Sub-Grupos";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Button btnBuscaCategoriaPagamento;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private CheckBox checkBoxTodos;
        private Button btnPesquisar;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private ComboBox comboFiltros;
        private Label label5;
        private TextBox textDadosPesquisa;
        private Panel panel2;
        private Button btnEditar;
        private Button btnExcluir;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn CodigoGrupo;
    }
}