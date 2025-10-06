namespace ServiTech.Componentes.FormConsultas
{
    partial class PesquisarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarProduto));
            groupBox2 = new GroupBox();
            checkBoxTodos = new CheckBox();
            btnPesquisar = new Button();
            textDadosPesquisa = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboModelo = new ComboBox();
            label2 = new Label();
            comboFiltros = new ComboBox();
            panel1 = new Panel();
            groupBox6 = new GroupBox();
            label21 = new Label();
            label18 = new Label();
            label1 = new Label();
            label14 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            CodigoBarra = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            UniMedida = new DataGridViewTextBoxColumn();
            ValorVenda = new DataGridViewTextBoxColumn();
            UltimaEntrada = new DataGridViewTextBoxColumn();
            UltimaSaida = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1170, 102);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Campos de Pesquisa";
            groupBox2.Resize += groupBox2_Resize;
            // 
            // checkBoxTodos
            // 
            checkBoxTodos.AutoSize = true;
            checkBoxTodos.Location = new Point(1100, 13);
            checkBoxTodos.Name = "checkBoxTodos";
            checkBoxTodos.Size = new Size(58, 19);
            checkBoxTodos.TabIndex = 27;
            checkBoxTodos.Text = "Todos";
            checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.lupa;
            btnPesquisar.Location = new Point(1049, 64);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(109, 29);
            btnPesquisar.TabIndex = 26;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // textDadosPesquisa
            // 
            textDadosPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDadosPesquisa.Location = new Point(291, 35);
            textDadosPesquisa.Name = "textDadosPesquisa";
            textDadosPesquisa.Size = new Size(867, 23);
            textDadosPesquisa.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F);
            label16.ForeColor = Color.FromArgb(44, 62, 80);
            label16.Location = new Point(291, 19);
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
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 464);
            panel1.TabIndex = 3;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(label21);
            groupBox6.Controls.Add(label18);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(textBox3);
            groupBox6.Controls.Add(textBox4);
            groupBox6.Controls.Add(textBox2);
            groupBox6.Controls.Add(textBox1);
            groupBox6.Location = new Point(4, 322);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1162, 87);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ultimas Compras";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9.75F);
            label21.ForeColor = Color.FromArgb(44, 62, 80);
            label21.Location = new Point(324, 21);
            label21.Name = "label21";
            label21.Size = new Size(72, 16);
            label21.TabIndex = 28;
            label21.Text = "Fornecedor";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F);
            label18.ForeColor = Color.FromArgb(44, 62, 80);
            label18.Location = new Point(218, 21);
            label18.Name = "label18";
            label18.Size = new Size(95, 16);
            label18.TabIndex = 27;
            label18.Text = "Qtd. Comprado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(112, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 26;
            label1.Text = "N.Fiscal";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F);
            label14.ForeColor = Color.FromArgb(44, 62, 80);
            label14.Location = new Point(6, 21);
            label14.Name = "label14";
            label14.Size = new Size(34, 16);
            label14.TabIndex = 25;
            label14.Text = "Data";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(324, 40);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(828, 30);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(218, 40);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 30);
            textBox4.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 40);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 30);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, CodigoBarra, NomeProduto, UniMedida, ValorVenda, UltimaEntrada, UltimaSaida });
            dataGridView1.Location = new Point(0, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.Size = new Size(1166, 318);
            dataGridView1.TabIndex = 3;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 120;
            // 
            // CodigoBarra
            // 
            CodigoBarra.HeaderText = "Codigo de Barra";
            CodigoBarra.Name = "CodigoBarra";
            CodigoBarra.Width = 150;
            // 
            // NomeProduto
            // 
            NomeProduto.FillWeight = 320F;
            NomeProduto.HeaderText = "Nome Produto";
            NomeProduto.Name = "NomeProduto";
            NomeProduto.Width = 350;
            // 
            // UniMedida
            // 
            UniMedida.HeaderText = "Unid";
            UniMedida.Name = "UniMedida";
            UniMedida.Width = 50;
            // 
            // ValorVenda
            // 
            ValorVenda.HeaderText = "Valor de Venda";
            ValorVenda.Name = "ValorVenda";
            ValorVenda.Width = 150;
            // 
            // UltimaEntrada
            // 
            UltimaEntrada.HeaderText = "Ultima Entrada";
            UltimaEntrada.Name = "UltimaEntrada";
            UltimaEntrada.Width = 150;
            // 
            // UltimaSaida
            // 
            UltimaSaida.HeaderText = "Ultima Saida";
            UltimaSaida.Name = "UltimaSaida";
            UltimaSaida.Width = 150;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnExcluir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 510);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 56);
            panel2.TabIndex = 4;
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
            // PesquisarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 566);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PesquisarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Produto";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private CheckBox checkBoxTodos;
        private Button btnPesquisar;
        private TextBox textDadosPesquisa;
        private Label label16;
        private Label label17;
        private ComboBox comboModelo;
        private Label label2;
        private ComboBox comboFiltros;
        private Panel panel1;
        private Panel panel2;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn CodigoBarra;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn UniMedida;
        private DataGridViewTextBoxColumn ValorVenda;
        private DataGridViewTextBoxColumn UltimaEntrada;
        private DataGridViewTextBoxColumn UltimaSaida;
        private GroupBox groupBox6;
        private Label label21;
        private Label label18;
        private Label label1;
        private Label label14;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}