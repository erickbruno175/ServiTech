namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPais));
            tabControl = new TabControl();
            tabCadastro = new TabPage();
            panel3 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            textNome = new TextBox();
            label10 = new Label();
            textCodigoPais = new TextBox();
            label1 = new Label();
            tabConsultas = new TabPage();
            panel2 = new Panel();
            dataGridPais = new DataGridView();
            panel1 = new Panel();
            bntNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            groupBox2 = new GroupBox();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label2 = new Label();
            comboFiltros = new ComboBox();
            label45 = new Label();
            tabControl.SuspendLayout();
            tabCadastro.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabConsultas.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPais).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCadastro);
            tabControl.Controls.Add(tabConsultas);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(788, 337);
            tabControl.TabIndex = 0;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(panel3);
            tabCadastro.Controls.Add(groupBox1);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(780, 309);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastro";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnNovo);
            panel3.Controls.Add(btnGravar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 256);
            panel3.Name = "panel3";
            panel3.Size = new Size(774, 50);
            panel3.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(6, 3);
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
            btnGravar.Location = new Point(100, 3);
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
            groupBox1.Controls.Add(label45);
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textCodigoPais);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // textNome
            // 
            textNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNome.Location = new Point(89, 45);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(679, 23);
            textNome.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(89, 26);
            label10.Name = "label10";
            label10.Size = new Size(45, 16);
            label10.TabIndex = 22;
            label10.Text = "Nome ";
            // 
            // textCodigoPais
            // 
            textCodigoPais.Location = new Point(6, 45);
            textCodigoPais.Name = "textCodigoPais";
            textCodigoPais.ReadOnly = true;
            textCodigoPais.Size = new Size(77, 23);
            textCodigoPais.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 2;
            label1.Text = "Codigo";
            // 
            // tabConsultas
            // 
            tabConsultas.BorderStyle = BorderStyle.Fixed3D;
            tabConsultas.Controls.Add(panel2);
            tabConsultas.Controls.Add(panel1);
            tabConsultas.Controls.Add(groupBox2);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3);
            tabConsultas.Size = new Size(780, 309);
            tabConsultas.TabIndex = 1;
            tabConsultas.Text = "Consultas";
            tabConsultas.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridPais);
            panel2.Location = new Point(3, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 140);
            panel2.TabIndex = 3;
            // 
            // dataGridPais
            // 
            dataGridPais.BackgroundColor = Color.White;
            dataGridPais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPais.Dock = DockStyle.Fill;
            dataGridPais.Location = new Point(0, 0);
            dataGridPais.Name = "dataGridPais";
            dataGridPais.Size = new Size(766, 136);
            dataGridPais.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(bntNovo);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnExcluir);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 56);
            panel1.TabIndex = 2;
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
            groupBox2.Size = new Size(770, 97);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(374, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(390, 23);
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
            label45.Location = new Point(140, 29);
            label45.Name = "label45";
            label45.Size = new Size(74, 13);
            label45.TabIndex = 276;
            label45.Text = "[Obrigatorio]";
            // 
            // CadastrarPais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 337);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "CadastrarPais";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Paises";
            Load += CadastrarPais_Load;
            KeyDown += LiberarCamposParaNovoCadastro_KeyDown;
            KeyPress += CadastrarPais_KeyPress;
            tabControl.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabConsultas.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPais).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabCadastro;
        private TabPage tabConsultas;
        private GroupBox groupBox1;
        private TextBox textCodigoPais;
        private Label label1;
        private TextBox textNome;
        private Label label10;
        private GroupBox groupBox2;
        private Label label17;
        private ComboBox comboModelo;
        private Label label2;
        private ComboBox comboFiltros;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Panel panel3;
        private Panel panel1;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnGravar;
        private Panel panel2;
        private DataGridView dataGridPais;
        private Button btnEditar;
        private Button bntNovo;
        private Label label45;
    }
}