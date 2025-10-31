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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarSubGrupo));
            tabControl1 = new TabControl();
            tabCadastro = new TabPage();
            groupBox2 = new GroupBox();
            label2 = new Label();
            comboGrupos = new ComboBox();
            textCod = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            checkAtivo = new CheckBox();
            textNome = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            tabConsultas = new TabPage();
            panel3 = new Panel();
            dataGridSubGrupo = new DataGridView();
            panel2 = new Panel();
            bntNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            groupBox1 = new GroupBox();
            textDadosPesquisa = new TextBox();
            label5 = new Label();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            comboFiltros = new ComboBox();
            label45 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            tabConsultas.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSubGrupo).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            tabControl1.Size = new Size(830, 420);
            tabControl1.TabIndex = 0;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(groupBox2);
            tabCadastro.Controls.Add(panel1);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(822, 392);
            tabCadastro.TabIndex = 1;
            tabCadastro.Text = "Cadastrar";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label45);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboGrupos);
            groupBox2.Controls.Add(textCod);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(textNome);
            groupBox2.Controls.Add(label10);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(816, 168);
            groupBox2.TabIndex = 78;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(42, 16);
            label2.TabIndex = 95;
            label2.Text = "Grupo";
            // 
            // comboGrupos
            // 
            comboGrupos.Enabled = false;
            comboGrupos.FormattingEnabled = true;
            comboGrupos.Location = new Point(6, 93);
            comboGrupos.Name = "comboGrupos";
            comboGrupos.Size = new Size(273, 23);
            comboGrupos.TabIndex = 94;
            // 
            // textCod
            // 
            textCod.Location = new Point(6, 39);
            textCod.Name = "textCod";
            textCod.ReadOnly = true;
            textCod.Size = new Size(65, 23);
            textCod.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 92;
            label1.Text = "Codigo";
            // 
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(checkAtivo);
            groupBox3.Font = new Font("Arial", 9.75F);
            groupBox3.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox3.Location = new Point(285, 75);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(129, 49);
            groupBox3.TabIndex = 87;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ativo ?";
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Enabled = false;
            checkAtivo.Location = new Point(6, 21);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(49, 20);
            checkAtivo.TabIndex = 0;
            checkAtivo.Text = "Sim";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // textNome
            // 
            textNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNome.Location = new Point(76, 39);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(711, 23);
            textNome.TabIndex = 86;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(76, 19);
            label10.Name = "label10";
            label10.Size = new Size(45, 16);
            label10.TabIndex = 85;
            label10.Text = "Nome ";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 58);
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
            // tabConsultas
            // 
            tabConsultas.Controls.Add(panel3);
            tabConsultas.Controls.Add(panel2);
            tabConsultas.Controls.Add(groupBox1);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3);
            tabConsultas.Size = new Size(822, 392);
            tabConsultas.TabIndex = 2;
            tabConsultas.Text = "Consultas";
            tabConsultas.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(dataGridSubGrupo);
            panel3.Location = new Point(3, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 209);
            panel3.TabIndex = 4;
            // 
            // dataGridSubGrupo
            // 
            dataGridSubGrupo.BackgroundColor = Color.White;
            dataGridSubGrupo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSubGrupo.Dock = DockStyle.Fill;
            dataGridSubGrupo.Location = new Point(0, 0);
            dataGridSubGrupo.Name = "dataGridSubGrupo";
            dataGridSubGrupo.Size = new Size(812, 205);
            dataGridSubGrupo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(bntNovo);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnExcluir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 332);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 57);
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
            bntNovo.Click += bntNovo_Click;
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
            btnEditar.Click += btnEditar_Click;
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
            btnExcluir.Click += btnExcluir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textDadosPesquisa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(comboModelo);
            groupBox1.Controls.Add(comboFiltros);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(816, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Campos de Pesquisa";
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(371, 39);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(439, 23);
            textDadosPesquisa.TabIndex = 35;
            textDadosPesquisa.TextChanged += textDadosPesquisa_TextChanged;
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
            // comboFiltros
            // 
            comboFiltros.FormattingEnabled = true;
            comboFiltros.Location = new Point(5, 39);
            comboFiltros.Name = "comboFiltros";
            comboFiltros.Size = new Size(178, 23);
            comboFiltros.TabIndex = 28;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.ForeColor = Color.FromArgb(192, 0, 0);
            label45.Location = new Point(127, 23);
            label45.Name = "label45";
            label45.Size = new Size(74, 13);
            label45.TabIndex = 276;
            label45.Text = "[Obrigatorio]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(54, 76);
            label3.Name = "label3";
            label3.Size = new Size(74, 13);
            label3.TabIndex = 277;
            label3.Text = "[Obrigatorio]";
            // 
            // CadastrarSubGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 420);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "CadastrarSubGrupo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Sub-Grupos";
            Load += CadastrarSubGrupo_Load;
            KeyDown += CadastrarSubGrupo_KeyDown;
            tabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            tabConsultas.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridSubGrupo).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCadastro;
        private Label label2;
        private Panel panel1;
        private Button btnNovo;
        private Button btnGravar;
        private TextBox textIdGrupo;
        private TabPage tabConsultas;
        private GroupBox groupBox1;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private ComboBox comboFiltros;
        private Label label5;
        private TextBox textDadosPesquisa;
        private Panel panel2;
        private Button btnExcluir;
        private Panel panel3;
        private GroupBox groupBox2;
        private TextBox textCod;
        private GroupBox groupBox3;
        private TextBox textNome;
        private Label label10;
        private Button btnEditar;
        private CheckBox checkAtivo;
        private ComboBox comboGrupos;
        private Label label1;
        private DataGridView dataGridSubGrupo;
        private Button bntNovo;
        private Label label3;
        private Label label45;
    }
}