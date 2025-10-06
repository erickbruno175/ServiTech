namespace ServiTech.Caixa.Operacao
{
    partial class OperacaoConsultarProduto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperacaoConsultarProduto));
            panel1 = new Panel();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            CodigoBarra = new DataGridViewTextBoxColumn();
            CodigoInterno = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            QuantEstoque = new DataGridViewTextBoxColumn();
            UniMedida = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 741);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(10, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o Código de Barra ou Nome do Produto";
            textBox1.Size = new Size(1257, 43);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.MouseClick += textBox1_MouseClick;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, CodigoBarra, CodigoInterno, Nome, Preço, QuantEstoque, UniMedida });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(0, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1270, 452);
            dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 80;
            // 
            // CodigoBarra
            // 
            CodigoBarra.HeaderText = "Código de Barra";
            CodigoBarra.Name = "CodigoBarra";
            CodigoBarra.ReadOnly = true;
            CodigoBarra.Width = 200;
            // 
            // CodigoInterno
            // 
            CodigoInterno.HeaderText = "Código Interno";
            CodigoInterno.Name = "CodigoInterno";
            CodigoInterno.ReadOnly = true;
            CodigoInterno.Width = 200;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 400;
            // 
            // Preço
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            Preço.DefaultCellStyle = dataGridViewCellStyle2;
            Preço.HeaderText = "Preço (R$)";
            Preço.Name = "Preço";
            Preço.ReadOnly = true;
            Preço.Width = 120;
            // 
            // QuantEstoque
            // 
            QuantEstoque.HeaderText = "Quant. Estoque";
            QuantEstoque.Name = "QuantEstoque";
            QuantEstoque.ReadOnly = true;
            QuantEstoque.Width = 160;
            // 
            // UniMedida
            // 
            UniMedida.HeaderText = "Unid Medida";
            UniMedida.Name = "UniMedida";
            UniMedida.ReadOnly = true;
            UniMedida.Width = 150;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(0, 548);
            label2.Name = "label2";
            label2.Size = new Size(1274, 64);
            label2.TabIndex = 2;
            label2.Text = "Total de Dados :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OperacaoConsultarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 612);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OperacaoConsultarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Produto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn CodigoBarra;
        private DataGridViewTextBoxColumn CodigoInterno;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn QuantEstoque;
        private DataGridViewTextBoxColumn UniMedida;
        private TextBox textBox1;
    }
}