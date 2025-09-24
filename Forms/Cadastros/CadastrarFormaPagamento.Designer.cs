namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarFormaPagamento
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
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            radioAtivoNao = new RadioButton();
            radioAtivoSim = new RadioButton();
            btnBuscaCategoriaPagamento = new Button();
            textCategoria = new TextBox();
            label3 = new Label();
            textDescricao = new TextBox();
            label2 = new Label();
            textCodigo = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisarDados = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label6 = new Label();
            comboFiltros = new ComboBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Taxa = new DataGridViewTextBoxColumn();
            PermitidoDesconto = new DataGridViewCheckBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(823, 399);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 338);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 58);
            panel1.TabIndex = 1;
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnBuscaCategoriaPagamento);
            groupBox1.Controls.Add(textCategoria);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textDescricao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(809, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            groupBox1.Resize += groupBox1_Resize;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(434, 19);
            label7.Name = "label7";
            label7.Size = new Size(47, 16);
            label7.TabIndex = 47;
            label7.Text = "Codigo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 38);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(47, 23);
            textBox1.TabIndex = 46;
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(radioAtivoNao);
            groupBox2.Controls.Add(radioAtivoSim);
            groupBox2.Font = new Font("Arial", 9.75F);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(6, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 52);
            groupBox2.TabIndex = 45;
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
            // btnBuscaCategoriaPagamento
            // 
            btnBuscaCategoriaPagamento.BackColor = Color.Transparent;
            btnBuscaCategoriaPagamento.FlatAppearance.BorderSize = 0;
            btnBuscaCategoriaPagamento.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaCategoriaPagamento.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaCategoriaPagamento.FlatStyle = FlatStyle.Flat;
            btnBuscaCategoriaPagamento.Image = Properties.Resources.lupa;
            btnBuscaCategoriaPagamento.Location = new Point(772, 38);
            btnBuscaCategoriaPagamento.Name = "btnBuscaCategoriaPagamento";
            btnBuscaCategoriaPagamento.Size = new Size(29, 23);
            btnBuscaCategoriaPagamento.TabIndex = 39;
            btnBuscaCategoriaPagamento.UseVisualStyleBackColor = false;
            btnBuscaCategoriaPagamento.Click += BuscarCategoriaFormaPagamento_Click;
            // 
            // textCategoria
            // 
            textCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textCategoria.Location = new Point(487, 38);
            textCategoria.Name = "textCategoria";
            textCategoria.ReadOnly = true;
            textCategoria.Size = new Size(291, 23);
            textCategoria.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(492, 19);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 8;
            label3.Text = "Categoria";
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(76, 38);
            textDescricao.Name = "textDescricao";
            textDescricao.ReadOnly = true;
            textDescricao.Size = new Size(352, 23);
            textDescricao.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(76, 18);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 6;
            label2.Text = "Descrição";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(6, 38);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(64, 23);
            textCodigo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 4;
            label1.Text = "Codigo";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(831, 427);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(823, 399);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Consultas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnExcluir);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(817, 56);
            panel3.TabIndex = 4;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.novo;
            btnEditar.Location = new Point(4, 8);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(128, 40);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.lixeira;
            btnExcluir.Location = new Point(138, 8);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 238);
            panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBoxTodos);
            groupBox4.Controls.Add(btnPesquisarDados);
            groupBox4.Controls.Add(textDadosPesquisa);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(comboModelo);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(comboFiltros);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(817, 95);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Campos de Pesquisa";
            groupBox4.Resize += groupBox4_Resize;
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(753, 19);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarDados
            // 
            btnPesquisarDados.Image = Properties.Resources.lupa;
            btnPesquisarDados.Location = new Point(702, 62);
            btnPesquisarDados.Name = "btnPesquisarDados";
            btnPesquisarDados.Size = new Size(109, 29);
            btnPesquisarDados.TabIndex = 26;
            btnPesquisarDados.Text = "Pesquisar";
            btnPesquisarDados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarDados.UseVisualStyleBackColor = true;
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(291, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(520, 23);
            textDadosPesquisa.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F);
            label16.ForeColor = Color.FromArgb(44, 62, 80);
            label16.Location = new Point(291, 16);
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
            label17.Location = new Point(157, 19);
            label17.Name = "label17";
            label17.Size = new Size(122, 16);
            label17.TabIndex = 22;
            label17.Text = "Modelo de Consulta";
            // 
            // comboModelo
            // 
            comboModelo.FormattingEnabled = true;
            comboModelo.Location = new Point(157, 35);
            comboModelo.Name = "comboModelo";
            comboModelo.Size = new Size(128, 23);
            comboModelo.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(6, 16);
            label6.Name = "label6";
            label6.Size = new Size(43, 16);
            label6.TabIndex = 20;
            label6.Text = "Filtros";
            // 
            // comboFiltros
            // 
            comboFiltros.FormattingEnabled = true;
            comboFiltros.Location = new Point(6, 35);
            comboFiltros.Name = "comboFiltros";
            comboFiltros.Size = new Size(145, 23);
            comboFiltros.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Descricao, Categoria, Taxa, PermitidoDesconto, Ativo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(811, 234);
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
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.Width = 250;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Width = 250;
            // 
            // Taxa
            // 
            Taxa.HeaderText = "Taxa";
            Taxa.Name = "Taxa";
            Taxa.Width = 200;
            // 
            // PermitidoDesconto
            // 
            PermitidoDesconto.HeaderText = "Permitido Desconto?";
            PermitidoDesconto.Name = "PermitidoDesconto";
            PermitidoDesconto.Width = 200;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo?";
            Ativo.Name = "Ativo";
            Ativo.Resizable = DataGridViewTriState.True;
            Ativo.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CadastrarFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 427);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "CadastrarFormaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Formas Pagamento";
            KeyDown += LiberarCamposParaCadastro_KeyDown;
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioAtivoNao;
        private RadioButton radioAtivoSim;
        private Label label3;
        private TextBox textDescricao;
        private Label label2;
        private TextBox textCodigo;
        private Label label1;
        private TabControl tabControl1;
        private Button btnBuscaCategoriaPagamento;
        private TextBox textCategoria;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private CheckBox checkBoxTodos;
        private Button btnPesquisarDados;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label6;
        private ComboBox comboFiltros;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label7;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Taxa;
        private DataGridViewCheckBoxColumn PermitidoDesconto;
        private DataGridViewCheckBoxColumn Ativo;
    }
}