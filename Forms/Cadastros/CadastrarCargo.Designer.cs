namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarCargo
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
            panel3 = new Panel();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            textDescriCargo = new TextBox();
            label3 = new Label();
            textNomeCargo = new TextBox();
            label10 = new Label();
            textCodigoCargo = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            NomeCargo = new DataGridViewTextBoxColumn();
            DescricaoCargo = new DataGridViewTextBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            UltimaAtualização = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisar = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label2 = new Label();
            comboFiltros = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
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
            tabControl1.Size = new Size(989, 467);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(981, 439);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnNovo);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGravar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 386);
            panel3.Name = "panel3";
            panel3.Size = new Size(975, 50);
            panel3.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(7, 3);
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
            btnCancelar.Location = new Point(195, 3);
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
            btnGravar.Location = new Point(101, 3);
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
            groupBox1.Controls.Add(textDescriCargo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textNomeCargo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textCodigoCargo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // textDescriCargo
            // 
            textDescriCargo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDescriCargo.Location = new Point(288, 45);
            textDescriCargo.Name = "textDescriCargo";
            textDescriCargo.ReadOnly = true;
            textDescriCargo.Size = new Size(673, 23);
            textDescriCargo.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(288, 26);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 24;
            label3.Text = "Descrição";
            // 
            // textNomeCargo
            // 
            textNomeCargo.Location = new Point(76, 45);
            textNomeCargo.Name = "textNomeCargo";
            textNomeCargo.ReadOnly = true;
            textNomeCargo.Size = new Size(206, 23);
            textNomeCargo.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(76, 25);
            label10.Name = "label10";
            label10.Size = new Size(97, 16);
            label10.TabIndex = 22;
            label10.Text = "Nome do Cargo";
            // 
            // textCodigoCargo
            // 
            textCodigoCargo.Location = new Point(6, 45);
            textCodigoCargo.Name = "textCodigoCargo";
            textCodigoCargo.ReadOnly = true;
            textCodigoCargo.Size = new Size(64, 23);
            textCodigoCargo.TabIndex = 3;
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
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(981, 439);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnExcluir);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 56);
            panel1.TabIndex = 2;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(-2, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 261);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, NomeCargo, DescricaoCargo, DataCadastro, UltimaAtualização });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(974, 257);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // NomeCargo
            // 
            NomeCargo.HeaderText = "Nome do Cargo";
            NomeCargo.Name = "NomeCargo";
            NomeCargo.ReadOnly = true;
            NomeCargo.Width = 450;
            // 
            // DescricaoCargo
            // 
            DescricaoCargo.HeaderText = "Descrição ";
            DescricaoCargo.Name = "DescricaoCargo";
            DescricaoCargo.ReadOnly = true;
            DescricaoCargo.Width = 300;
            // 
            // DataCadastro
            // 
            DataCadastro.HeaderText = "Data de Cadastro";
            DataCadastro.Name = "DataCadastro";
            DataCadastro.ReadOnly = true;
            DataCadastro.Width = 250;
            // 
            // UltimaAtualização
            // 
            UltimaAtualização.HeaderText = "Ultima Atualização";
            UltimaAtualização.Name = "UltimaAtualização";
            UltimaAtualização.ReadOnly = true;
            UltimaAtualização.Width = 250;
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
            groupBox2.Size = new Size(971, 97);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            groupBox2.Resize += groupBox2_Resize;
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(907, 16);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(852, 62);
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
            textDadosPesquisa.Size = new Size(591, 23);
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
            // CadastrarCargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 467);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "CadastrarCargo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Cargo";
            Load += CadastrarPais_Load;
            KeyDown += LiberarCamposParaNovoCadastro_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox textCodigoCargo;
        private Label label1;
        private TextBox textNomeCargo;
        private Label label10;
        private GroupBox groupBox2;
        private Label label17;
        private ComboBox comboModelo;
        private Label label2;
        private ComboBox comboFiltros;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Button btnPesquisar;
        private CheckBox checkBoxTodos;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox textDescriCargo;
        private Label label3;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnGravar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NomeCargo;
        private DataGridViewTextBoxColumn DescricaoCargo;
        private DataGridViewTextBoxColumn DataCadastro;
        private DataGridViewTextBoxColumn UltimaAtualização;
    }
}