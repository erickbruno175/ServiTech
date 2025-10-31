namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarUnidadeMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarUnidadeMedida));
            tabControl1 = new TabControl();
            tabCadastro = new TabPage();
            groupBox1 = new GroupBox();
            textCod = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textDescricao = new TextBox();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            tabConsultas = new TabPage();
            panel3 = new Panel();
            bntNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            dataGridUnidadeMedida = new DataGridView();
            groupBox2 = new GroupBox();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label4 = new Label();
            comboFiltros = new ComboBox();
            label45 = new Label();
            tabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            tabConsultas.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUnidadeMedida).BeginInit();
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
            tabControl1.Size = new Size(750, 368);
            tabControl1.TabIndex = 1;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(groupBox1);
            tabCadastro.Controls.Add(panel1);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(742, 340);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastrar";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label45);
            groupBox1.Controls.Add(textCod);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textDescricao);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 75);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // textCod
            // 
            textCod.Location = new Point(5, 35);
            textCod.Name = "textCod";
            textCod.ReadOnly = true;
            textCod.Size = new Size(65, 23);
            textCod.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 54;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(79, 18);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 53;
            label2.Text = "Nome";
            // 
            // textDescricao
            // 
            textDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDescricao.Location = new Point(76, 35);
            textDescricao.Name = "textDescricao";
            textDescricao.ReadOnly = true;
            textDescricao.Size = new Size(632, 23);
            textDescricao.TabIndex = 52;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 286);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 51);
            panel1.TabIndex = 16;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(7, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 40);
            btnNovo.TabIndex = 22;
            btnNovo.Text = "Incluir F4";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGravar
            // 
            btnGravar.Image = Properties.Resources.salvar;
            btnGravar.Location = new Point(101, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 40);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // tabConsultas
            // 
            tabConsultas.Controls.Add(panel3);
            tabConsultas.Controls.Add(panel2);
            tabConsultas.Controls.Add(groupBox2);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3);
            tabConsultas.Size = new Size(742, 340);
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
            panel3.Location = new Point(3, 286);
            panel3.Name = "panel3";
            panel3.Size = new Size(736, 51);
            panel3.TabIndex = 4;
            // 
            // bntNovo
            // 
            bntNovo.Image = Properties.Resources.plus;
            bntNovo.Location = new Point(265, 4);
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
            btnEditar.Location = new Point(139, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Selecionar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.lixeira;
            btnExcluir.Location = new Point(4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 40);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir F7";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridUnidadeMedida);
            panel2.Location = new Point(3, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 170);
            panel2.TabIndex = 3;
            // 
            // dataGridUnidadeMedida
            // 
            dataGridUnidadeMedida.BackgroundColor = Color.White;
            dataGridUnidadeMedida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUnidadeMedida.Dock = DockStyle.Fill;
            dataGridUnidadeMedida.Location = new Point(0, 0);
            dataGridUnidadeMedida.Name = "dataGridUnidadeMedida";
            dataGridUnidadeMedida.Size = new Size(732, 166);
            dataGridUnidadeMedida.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textDadosPesquisa);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboModelo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboFiltros);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(736, 97);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(374, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(351, 23);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(6, 16);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 20;
            label4.Text = "Filtros";
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
            label45.Location = new Point(126, 21);
            label45.Name = "label45";
            label45.Size = new Size(74, 13);
            label45.TabIndex = 276;
            label45.Text = "[Obrigatorio]";
            // 
            // CadastrarUnidadeMedida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 368);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "CadastrarUnidadeMedida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Unidade Medida";
            Load += CadastrarUnidadeMedida_Load;
            KeyDown += LiberarCampoParaCadastro_KeyDown;
            tabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            tabConsultas.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUnidadeMedida).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCadastro;
        private Panel panel1;
        private TabPage tabConsultas;
        private GroupBox groupBox2;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label4;
        private ComboBox comboFiltros;
        private Panel panel2;
        private Panel panel3;
        private Button btnNovo;
        private Button btnGravar;
        private Button btnExcluir;
        private GroupBox groupBox1;
        private TextBox textCod;
        private Label label1;
        private Label label2;
        private TextBox textDescricao;
        private DataGridView dataGridUnidadeMedida;
        private Button btnEditar;
        private Button bntNovo;
        private Label label45;
    }
}