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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarBairro));
            tabControl1 = new TabControl();
            tabCadastro = new TabPage();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            comboCidades = new ComboBox();
            textCodigo = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBairro = new TextBox();
            label1 = new Label();
            tabConsultas = new TabPage();
            panel3 = new Panel();
            bntNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            dataGridBairro = new DataGridView();
            groupBox2 = new GroupBox();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label2 = new Label();
            comboFiltros = new ComboBox();
            label45 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabConsultas.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBairro).BeginInit();
            groupBox2.SuspendLayout();
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
            tabControl1.Size = new Size(762, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(panel1);
            tabCadastro.Controls.Add(groupBox1);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(754, 398);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastro";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 343);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 52);
            panel1.TabIndex = 2;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(5, 5);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 40);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Incluir F4";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += LiberararCamposParaNovoCadastro_Click;
            btnNovo.KeyDown += LiberararCamposParaNovoCadastro_Click;
            // 
            // btnGravar
            // 
            btnGravar.Image = Properties.Resources.salvar;
            btnGravar.Location = new Point(99, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 40);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label45);
            groupBox1.Controls.Add(comboCidades);
            groupBox1.Controls.Add(textCodigo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBairro);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // comboCidades
            // 
            comboCidades.Enabled = false;
            comboCidades.FormattingEnabled = true;
            comboCidades.Location = new Point(7, 92);
            comboCidades.Name = "comboCidades";
            comboCidades.Size = new Size(278, 23);
            comboCidades.TabIndex = 198;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(6, 38);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(88, 23);
            textCodigo.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 39;
            label3.Text = "Codigo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(6, 73);
            label5.Name = "label5";
            label5.Size = new Size(54, 16);
            label5.TabIndex = 34;
            label5.Text = "Cidades";
            // 
            // textBairro
            // 
            textBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBairro.Location = new Point(100, 38);
            textBairro.Name = "textBairro";
            textBairro.ReadOnly = true;
            textBairro.Size = new Size(629, 23);
            textBairro.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(100, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 16);
            label1.TabIndex = 22;
            label1.Text = "Nome do Bairro";
            // 
            // tabConsultas
            // 
            tabConsultas.BorderStyle = BorderStyle.Fixed3D;
            tabConsultas.Controls.Add(panel3);
            tabConsultas.Controls.Add(panel2);
            tabConsultas.Controls.Add(groupBox2);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3);
            tabConsultas.Size = new Size(754, 398);
            tabConsultas.TabIndex = 1;
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
            panel3.Location = new Point(3, 341);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 50);
            panel3.TabIndex = 3;
            // 
            // bntNovo
            // 
            bntNovo.Image = Properties.Resources.plus;
            bntNovo.Location = new Point(265, 5);
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
            btnEditar.Location = new Point(139, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Selecionar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.lixeira;
            btnExcluir.Location = new Point(4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridBairro);
            panel2.Location = new Point(6, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 226);
            panel2.TabIndex = 1;
            // 
            // dataGridBairro
            // 
            dataGridBairro.BackgroundColor = Color.White;
            dataGridBairro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBairro.Dock = DockStyle.Fill;
            dataGridBairro.Location = new Point(0, 0);
            dataGridBairro.Name = "dataGridBairro";
            dataGridBairro.Size = new Size(734, 222);
            dataGridBairro.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textDadosPesquisa);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboModelo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboFiltros);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(744, 97);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(374, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(364, 23);
            textDadosPesquisa.TabIndex = 24;
            textDadosPesquisa.TextChanged += textDadosPesquisa_TextChanged;
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
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.ForeColor = Color.FromArgb(192, 0, 0);
            label45.Location = new Point(203, 22);
            label45.Name = "label45";
            label45.Size = new Size(74, 13);
            label45.TabIndex = 276;
            label45.Text = "[Obrigatorio]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(66, 76);
            label4.Name = "label4";
            label4.Size = new Size(74, 13);
            label4.TabIndex = 277;
            label4.Text = "[Obrigatorio]";
            // 
            // CadastrarBairro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 426);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "CadastrarBairro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Bairros";
            Load += CadastrarPais_Load;
            KeyDown += LiberararCamposParaNovoCadastro_KeyDown;
            KeyPress += CadastrarBairro_KeyPress;
            tabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabConsultas.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridBairro).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCadastro;
        private TabPage tabConsultas;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label17;
        private ComboBox comboModelo;
        private Label label2;
        private ComboBox comboFiltros;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Panel panel2;
        private TextBox textBairro;
        private Label label1;
        private Panel panel1;
        private Button btnNovo;
        private Button btnGravar;
        private Panel panel3;
        private Button btnExcluir;
        private TextBox textCodigo;
        private Label label3;
        private Label label5;
        private ComboBox comboCidades;
        private DataGridView dataGridBairro;
        private Button btnEditar;
        private Button bntNovo;
        private Label label4;
        private Label label45;
    }
}