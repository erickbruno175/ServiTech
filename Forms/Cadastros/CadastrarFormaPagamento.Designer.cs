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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFormaPagamento));
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            textTaxa = new TextBox();
            label5 = new Label();
            textOperadora = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            radioButtonAceitaNao = new RadioButton();
            radioButtonAceitaSim = new RadioButton();
            textCod = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            radioAtivoNao = new RadioButton();
            radioAtivoSim = new RadioButton();
            textTipo = new TextBox();
            label3 = new Label();
            textNome = new TextBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Taxa = new DataGridViewTextBoxColumn();
            Operadora = new DataGridViewTextBoxColumn();
            AceitaParcelamento = new DataGridViewCheckBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            groupBox4 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisarDados = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label6 = new Label();
            comboFiltros = new ComboBox();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
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
            groupBox1.Controls.Add(textTaxa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textOperadora);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(textCod);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textTipo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // textTaxa
            // 
            textTaxa.Location = new Point(434, 89);
            textTaxa.Name = "textTaxa";
            textTaxa.ReadOnly = true;
            textTaxa.Size = new Size(123, 23);
            textTaxa.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(434, 69);
            label5.Name = "label5";
            label5.Size = new Size(93, 16);
            label5.TabIndex = 55;
            label5.Text = "Taxa/Desconto";
            // 
            // textOperadora
            // 
            textOperadora.Location = new Point(168, 87);
            textOperadora.Name = "textOperadora";
            textOperadora.ReadOnly = true;
            textOperadora.Size = new Size(260, 23);
            textOperadora.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(168, 67);
            label1.Name = "label1";
            label1.Size = new Size(108, 16);
            label1.TabIndex = 53;
            label1.Text = "Banco/Operadora";
            // 
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(radioButtonAceitaNao);
            groupBox3.Controls.Add(radioButtonAceitaSim);
            groupBox3.Font = new Font("Arial", 9.75F);
            groupBox3.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox3.Location = new Point(6, 67);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(156, 57);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aceita Parcelamento? ";
            // 
            // radioButtonAceitaNao
            // 
            radioButtonAceitaNao.Enabled = false;
            radioButtonAceitaNao.Location = new Point(66, 21);
            radioButtonAceitaNao.Name = "radioButtonAceitaNao";
            radioButtonAceitaNao.Size = new Size(53, 22);
            radioButtonAceitaNao.TabIndex = 4;
            radioButtonAceitaNao.TabStop = true;
            radioButtonAceitaNao.Text = "Não";
            radioButtonAceitaNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonAceitaSim
            // 
            radioButtonAceitaSim.Enabled = false;
            radioButtonAceitaSim.Location = new Point(6, 20);
            radioButtonAceitaSim.Name = "radioButtonAceitaSim";
            radioButtonAceitaSim.Size = new Size(54, 24);
            radioButtonAceitaSim.TabIndex = 3;
            radioButtonAceitaSim.TabStop = true;
            radioButtonAceitaSim.Text = "Sim";
            radioButtonAceitaSim.UseVisualStyleBackColor = true;
            // 
            // textCod
            // 
            textCod.Location = new Point(6, 38);
            textCod.Name = "textCod";
            textCod.ReadOnly = true;
            textCod.Size = new Size(64, 23);
            textCod.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 50;
            label4.Text = "Codigo";
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(radioAtivoNao);
            groupBox2.Controls.Add(radioAtivoSim);
            groupBox2.Font = new Font("Arial", 9.75F);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(567, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(133, 55);
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
            // textTipo
            // 
            textTipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTipo.Location = new Point(434, 38);
            textTipo.Name = "textTipo";
            textTipo.ReadOnly = true;
            textTipo.Size = new Size(352, 23);
            textTipo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(434, 18);
            label3.Name = "label3";
            label3.Size = new Size(176, 16);
            label3.TabIndex = 8;
            label3.Text = "Tipo Ex : (Avista , Parcelado)";
            // 
            // textNome
            // 
            textNome.Location = new Point(76, 38);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(352, 23);
            textNome.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(76, 18);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 6;
            label2.Text = "Nome";
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
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 298);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Tipo, Taxa, Operadora, AceitaParcelamento, Ativo });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(813, 234);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Taxa
            // 
            Taxa.HeaderText = "Taxa";
            Taxa.Name = "Taxa";
            Taxa.ReadOnly = true;
            // 
            // Operadora
            // 
            Operadora.HeaderText = "Operadora";
            Operadora.Name = "Operadora";
            Operadora.ReadOnly = true;
            // 
            // AceitaParcelamento
            // 
            AceitaParcelamento.HeaderText = "Aceita Parcelamento?";
            AceitaParcelamento.Name = "AceitaParcelamento";
            AceitaParcelamento.ReadOnly = true;
            AceitaParcelamento.Width = 200;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo?";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Resizable = DataGridViewTriState.True;
            Ativo.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // CadastrarFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 427);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "CadastrarFormaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Formas Pagamento";
            Load += CadastrarFormaPagamento_Load;
            KeyDown += LiberarCamposParaCadastro_KeyDown;
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioAtivoNao;
        private RadioButton radioAtivoSim;
        private Label label3;
        private TextBox textNome;
        private Label label2;
        private TabControl tabControl1;
        private TextBox textTipo;
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
        private DataGridView dataGridView1;
        private TextBox textCod;
        private Label label4;
        private GroupBox groupBox3;
        private RadioButton radioButtonAceitaNao;
        private RadioButton radioButtonAceitaSim;
        private TextBox textTaxa;
        private Label label5;
        private TextBox textOperadora;
        private Label label1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Taxa;
        private DataGridViewTextBoxColumn Operadora;
        private DataGridViewCheckBoxColumn AceitaParcelamento;
        private DataGridViewCheckBoxColumn Ativo;
    }
}