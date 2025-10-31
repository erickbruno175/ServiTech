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
            tabCadastro = new TabPage();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            textTaxa = new TextBox();
            label5 = new Label();
            textOperadora = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            checkedAceita = new CheckBox();
            textCod = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            checkAtivo = new CheckBox();
            textTipo = new TextBox();
            label3 = new Label();
            textNome = new TextBox();
            label2 = new Label();
            tabControl = new TabControl();
            tabConsultas = new TabPage();
            panel3 = new Panel();
            bntNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            dataFormasPagamento = new DataGridView();
            groupBox4 = new GroupBox();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label6 = new Label();
            comboFiltros = new ComboBox();
            label45 = new Label();
            label7 = new Label();
            tabCadastro.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl.SuspendLayout();
            tabConsultas.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFormasPagamento).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(panel1);
            tabCadastro.Controls.Add(groupBox1);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(876, 518);
            tabCadastro.TabIndex = 2;
            tabCadastro.Text = "Cadastrar";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 457);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 58);
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
            btnNovo.Click += btnNovo_Click;
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
            btnGravar.Click += btnGravar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label45);
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
            groupBox1.Size = new Size(870, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // textTaxa
            // 
            textTaxa.Location = new Point(434, 89);
            textTaxa.Name = "textTaxa";
            textTaxa.PlaceholderText = "0,00";
            textTaxa.ReadOnly = true;
            textTaxa.Size = new Size(123, 23);
            textTaxa.TabIndex = 56;
            textTaxa.TextChanged += MskararCampoMoeda_Changed;
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
            textOperadora.Location = new Point(123, 87);
            textOperadora.Name = "textOperadora";
            textOperadora.ReadOnly = true;
            textOperadora.Size = new Size(305, 23);
            textOperadora.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(123, 69);
            label1.Name = "label1";
            label1.Size = new Size(108, 16);
            label1.TabIndex = 53;
            label1.Text = "Banco/Operadora";
            // 
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(checkedAceita);
            groupBox3.Font = new Font("Arial", 9.75F);
            groupBox3.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox3.Location = new Point(6, 67);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(111, 57);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aceita Parcel? ";
            // 
            // checkedAceita
            // 
            checkedAceita.AutoSize = true;
            checkedAceita.Enabled = false;
            checkedAceita.Location = new Point(15, 22);
            checkedAceita.Name = "checkedAceita";
            checkedAceita.Size = new Size(49, 20);
            checkedAceita.TabIndex = 0;
            checkedAceita.Text = "Sim";
            checkedAceita.UseVisualStyleBackColor = true;
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
            groupBox2.Controls.Add(checkAtivo);
            groupBox2.Font = new Font("Arial", 9.75F);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(567, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(82, 55);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ativo ?";
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Enabled = false;
            checkAtivo.Location = new Point(6, 19);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(54, 20);
            checkAtivo.TabIndex = 0;
            checkAtivo.Text = "Ativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // textTipo
            // 
            textTipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTipo.Location = new Point(434, 38);
            textTipo.Name = "textTipo";
            textTipo.ReadOnly = true;
            textTipo.Size = new Size(405, 23);
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
            // tabControl
            // 
            tabControl.Controls.Add(tabCadastro);
            tabControl.Controls.Add(tabConsultas);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(884, 546);
            tabControl.TabIndex = 0;
            // 
            // tabConsultas
            // 
            tabConsultas.Controls.Add(panel3);
            tabConsultas.Controls.Add(panel2);
            tabConsultas.Controls.Add(groupBox4);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3);
            tabConsultas.Size = new Size(876, 518);
            tabConsultas.TabIndex = 3;
            tabConsultas.Text = "Consultas";
            tabConsultas.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(bntNovo);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnExcluir);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 463);
            panel3.Name = "panel3";
            panel3.Size = new Size(870, 52);
            panel3.TabIndex = 4;
            // 
            // bntNovo
            // 
            bntNovo.Image = Properties.Resources.plus;
            bntNovo.Location = new Point(265, 7);
            bntNovo.Name = "bntNovo";
            bntNovo.Size = new Size(101, 40);
            bntNovo.TabIndex = 27;
            bntNovo.Text = " Novo";
            bntNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntNovo.UseVisualStyleBackColor = true;
            bntNovo.Click += bntNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.marca_de_verificacao;
            btnEditar.Location = new Point(139, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Selecionar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.lixeira;
            btnExcluir.Location = new Point(4, 6);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataFormasPagamento);
            panel2.Location = new Point(3, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 346);
            panel2.TabIndex = 3;
            // 
            // dataFormasPagamento
            // 
            dataFormasPagamento.BackgroundColor = Color.White;
            dataFormasPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFormasPagamento.Dock = DockStyle.Fill;
            dataFormasPagamento.Location = new Point(0, 0);
            dataFormasPagamento.Name = "dataFormasPagamento";
            dataFormasPagamento.Size = new Size(866, 342);
            dataFormasPagamento.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textDadosPesquisa);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(comboModelo);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(comboFiltros);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(870, 95);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Campos de Pesquisa";
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(291, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(573, 23);
            textDadosPesquisa.TabIndex = 24;
            textDadosPesquisa.TextChanged += textDadosPesquisa_TextChanged;
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
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.ForeColor = Color.FromArgb(192, 0, 0);
            label45.Location = new Point(123, 22);
            label45.Name = "label45";
            label45.Size = new Size(74, 13);
            label45.TabIndex = 276;
            label45.Text = "[Obrigatorio]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(616, 22);
            label7.Name = "label7";
            label7.Size = new Size(74, 13);
            label7.TabIndex = 277;
            label7.Text = "[Obrigatorio]";
            // 
            // CadastrarFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 546);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "CadastrarFormaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Formas de  Pagamento";
            Load += CadastrarFormaPagamento_Load;
            KeyDown += LiberarCamposParaCadastro_KeyDown;
            tabCadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl.ResumeLayout(false);
            tabConsultas.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataFormasPagamento).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabCadastro;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioAtivoNao;
        private RadioButton radioAtivoSim;
        private Label label3;
        private TextBox textNome;
        private Label label2;
        private TabControl tabControl;
        private TextBox textTipo;
        private TabPage tabConsultas;
        private GroupBox groupBox4;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label6;
        private ComboBox comboFiltros;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnGravar;
        private TextBox textCod;
        private Label label4;
        private GroupBox groupBox3;
        private RadioButton radioButtonAceitaNao;
        private TextBox textTaxa;
        private Label label5;
        private TextBox textOperadora;
        private Label label1;
        private DataGridView dataFormasPagamento;
        private CheckBox checkAtivo;
        private CheckBox checkedAceita;
        private Button btnEditar;
        private Button bntNovo;
        private Label label45;
        private Label label7;
    }
}