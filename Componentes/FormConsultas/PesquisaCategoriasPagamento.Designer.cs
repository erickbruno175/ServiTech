namespace ServiTech.Componentes.FormConsultas
{
    partial class PesquisaCategoriasPagamento
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
            groupBox2 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisarDados = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label2 = new Label();
            comboFiltros = new ComboBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnOk = new Button();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(checkBoxTodos);
            groupBox2.Controls.Add(btnPesquisarDados);
            groupBox2.Controls.Add(textDadosPesquisa);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboModelo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboFiltros);
            groupBox2.Location = new Point(3, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 102);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            groupBox2.Resize += groupBox2_Resize;
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(6, 72);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarDados
            // 
            btnPesquisarDados.Image = Properties.Resources.lupa;
            btnPesquisarDados.Location = new Point(428, 64);
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
            textDadosPesquisa.Size = new Size(248, 23);
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
            comboFiltros.Size = new Size(145, 23);
            comboFiltros.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(3, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 294);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Descricao });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(539, 290);
            dataGridView1.TabIndex = 2;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 300;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.Width = 300;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnOk);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 59);
            panel2.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.verifica;
            btnOk.Location = new Point(7, 12);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 40);
            btnOk.TabIndex = 16;
            btnOk.Text = "Selecionar";
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // PesquisaCategoriasPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 472);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Name = "PesquisaCategoriasPagamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pesquisa Categorias de Forma de Pagamento";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private CheckBox checkBoxTodos;
        private Button btnPesquisarDados;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label2;
        private ComboBox comboFiltros;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnOk;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
    }
}