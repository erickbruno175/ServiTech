namespace ServiTech.Caixa
{
    partial class Pdv
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            header = new Panel();
            labelDataHora = new Label();
            label1InfoOperador = new Label();
            pictureBoxLogo = new PictureBox();
            panel2 = new Panel();
            content = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            btnAbrirGaveta = new Button();
            footer = new Panel();
            btnFecharCaixa = new Button();
            btnSangria = new Button();
            button1 = new Button();
            btnNovaVenda = new Button();
            btnConsultaProduto = new Button();
            btnCancelarVenda = new Button();
            btnDesconto = new Button();
            btnFinalizaVenda = new Button();
            labelTituloStatusCaixa = new Label();
            textTotal = new TextBox();
            label7 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            textReadTotalPreco = new TextBox();
            label4 = new Label();
            textReadPrecoProduto = new TextBox();
            label3 = new Label();
            textReadQuantProduto = new TextBox();
            label2 = new Label();
            textReadCodProduto = new TextBox();
            painelGridProdutos = new Panel();
            labelTituloCaixa = new Label();
            textReadCupom = new TextBox();
            gridProdutos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Quant = new DataGridViewTextBoxColumn();
            ValorUni = new DataGridViewTextBoxColumn();
            PreçoTotal = new DataGridViewTextBoxColumn();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            content.SuspendLayout();
            footer.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            painelGridProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(0, 66, 100);
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(labelDataHora);
            header.Controls.Add(label1InfoOperador);
            header.Controls.Add(pictureBoxLogo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1547, 66);
            header.TabIndex = 0;
            // 
            // labelDataHora
            // 
            labelDataHora.BackColor = Color.Transparent;
            labelDataHora.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDataHora.ForeColor = Color.White;
            labelDataHora.Location = new Point(1372, 2);
            labelDataHora.Name = "labelDataHora";
            labelDataHora.Size = new Size(174, 62);
            labelDataHora.TabIndex = 7;
            labelDataHora.Text = "data";
            labelDataHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1InfoOperador
            // 
            label1InfoOperador.AccessibleRole = AccessibleRole.OutlineButton;
            label1InfoOperador.BackColor = Color.Transparent;
            label1InfoOperador.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1InfoOperador.ForeColor = Color.White;
            label1InfoOperador.Location = new Point(99, 0);
            label1InfoOperador.Name = "label1InfoOperador";
            label1InfoOperador.Size = new Size(1267, 62);
            label1InfoOperador.TabIndex = 3;
            label1InfoOperador.Text = "Operador:";
            label1InfoOperador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Left;
            pictureBoxLogo.Image = Properties.Resources.imagemlogo;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(97, 64);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 66, 100);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(0, 785);
            panel2.Name = "panel2";
            panel2.Size = new Size(1547, 40);
            panel2.TabIndex = 1;
            // 
            // content
            // 
            content.BackColor = Color.White;
            content.Controls.Add(label1);
            content.Controls.Add(textBox1);
            content.Controls.Add(btnAbrirGaveta);
            content.Controls.Add(footer);
            content.Controls.Add(labelTituloStatusCaixa);
            content.Controls.Add(textTotal);
            content.Controls.Add(label7);
            content.Controls.Add(panel4);
            content.Controls.Add(label5);
            content.Controls.Add(textReadTotalPreco);
            content.Controls.Add(label4);
            content.Controls.Add(textReadPrecoProduto);
            content.Controls.Add(label3);
            content.Controls.Add(textReadQuantProduto);
            content.Controls.Add(label2);
            content.Controls.Add(textReadCodProduto);
            content.Controls.Add(painelGridProdutos);
            content.Dock = DockStyle.Fill;
            content.Location = new Point(0, 66);
            content.Name = "content";
            content.Size = new Size(1547, 759);
            content.TabIndex = 2;
            content.Resize += panel3_Resize;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 66, 100);
            label1.Location = new Point(835, 536);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 15;
            label1.Text = "Quant. Estoque";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(728, 571);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 40);
            textBox1.TabIndex = 14;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAbrirGaveta
            // 
            btnAbrirGaveta.BackColor = Color.Transparent;
            btnAbrirGaveta.FlatAppearance.BorderSize = 0;
            btnAbrirGaveta.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAbrirGaveta.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnAbrirGaveta.FlatStyle = FlatStyle.Flat;
            btnAbrirGaveta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirGaveta.ForeColor = Color.FromArgb(0, 66, 100);
            btnAbrirGaveta.Image = Properties.Resources.maquina__2_;
            btnAbrirGaveta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirGaveta.Location = new Point(1363, 24);
            btnAbrirGaveta.Name = "btnAbrirGaveta";
            btnAbrirGaveta.Size = new Size(172, 73);
            btnAbrirGaveta.TabIndex = 5;
            btnAbrirGaveta.TabStop = false;
            btnAbrirGaveta.Text = "Abrir Gaveta F12";
            btnAbrirGaveta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbrirGaveta.UseVisualStyleBackColor = false;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            footer.BackColor = Color.FromArgb(0, 66, 100);
            footer.BorderStyle = BorderStyle.Fixed3D;
            footer.Controls.Add(btnFecharCaixa);
            footer.Controls.Add(btnSangria);
            footer.Controls.Add(button1);
            footer.Controls.Add(btnNovaVenda);
            footer.Controls.Add(btnConsultaProduto);
            footer.Controls.Add(btnCancelarVenda);
            footer.Controls.Add(btnDesconto);
            footer.Controls.Add(btnFinalizaVenda);
            footer.Location = new Point(3, 682);
            footer.Name = "footer";
            footer.Size = new Size(1540, 77);
            footer.TabIndex = 13;
            // 
            // btnFecharCaixa
            // 
            btnFecharCaixa.BackColor = Color.Transparent;
            btnFecharCaixa.FlatAppearance.BorderSize = 0;
            btnFecharCaixa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFecharCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnFecharCaixa.FlatStyle = FlatStyle.Flat;
            btnFecharCaixa.Font = new Font("Segoe UI", 9.75F);
            btnFecharCaixa.ForeColor = Color.White;
            btnFecharCaixa.Image = Properties.Resources.feichamento;
            btnFecharCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnFecharCaixa.Location = new Point(945, -1);
            btnFecharCaixa.Name = "btnFecharCaixa";
            btnFecharCaixa.Size = new Size(174, 73);
            btnFecharCaixa.TabIndex = 8;
            btnFecharCaixa.TabStop = false;
            btnFecharCaixa.Text = "Fechamento do Caixa F8";
            btnFecharCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFecharCaixa.UseVisualStyleBackColor = false;
            // 
            // btnSangria
            // 
            btnSangria.BackColor = Color.Transparent;
            btnSangria.FlatAppearance.BorderSize = 0;
            btnSangria.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSangria.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnSangria.FlatStyle = FlatStyle.Flat;
            btnSangria.Font = new Font("Segoe UI", 9.75F);
            btnSangria.ForeColor = Color.White;
            btnSangria.Image = Properties.Resources.retirada_de_dinheiro;
            btnSangria.ImageAlign = ContentAlignment.MiddleLeft;
            btnSangria.Location = new Point(842, -1);
            btnSangria.Name = "btnSangria";
            btnSangria.Size = new Size(97, 73);
            btnSangria.TabIndex = 7;
            btnSangria.TabStop = false;
            btnSangria.Text = "Sangria F7";
            btnSangria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSangria.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.atendimento_ao_cliente;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(691, -3);
            button1.Name = "button1";
            button1.Size = new Size(145, 73);
            button1.TabIndex = 6;
            button1.TabStop = false;
            button1.Text = "Consultar Cliente F6";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.BackColor = Color.Transparent;
            btnNovaVenda.FlatAppearance.BorderSize = 0;
            btnNovaVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNovaVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnNovaVenda.FlatStyle = FlatStyle.Flat;
            btnNovaVenda.Font = new Font("Segoe UI", 9.75F);
            btnNovaVenda.ForeColor = Color.White;
            btnNovaVenda.Image = Properties.Resources.carrinho_de_compras1;
            btnNovaVenda.Location = new Point(1, -2);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(122, 72);
            btnNovaVenda.TabIndex = 4;
            btnNovaVenda.TabStop = false;
            btnNovaVenda.Text = "Nova Venda F1";
            btnNovaVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovaVenda.UseVisualStyleBackColor = false;
            // 
            // btnConsultaProduto
            // 
            btnConsultaProduto.BackColor = Color.Transparent;
            btnConsultaProduto.FlatAppearance.BorderSize = 0;
            btnConsultaProduto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConsultaProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnConsultaProduto.FlatStyle = FlatStyle.Flat;
            btnConsultaProduto.Font = new Font("Segoe UI", 9.75F);
            btnConsultaProduto.ForeColor = Color.White;
            btnConsultaProduto.Image = Properties.Resources.prod;
            btnConsultaProduto.Location = new Point(129, -2);
            btnConsultaProduto.Name = "btnConsultaProduto";
            btnConsultaProduto.Size = new Size(146, 72);
            btnConsultaProduto.TabIndex = 3;
            btnConsultaProduto.TabStop = false;
            btnConsultaProduto.Text = "Consultar Produto F2";
            btnConsultaProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaProduto.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.BackColor = Color.Transparent;
            btnCancelarVenda.FlatAppearance.BorderSize = 0;
            btnCancelarVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancelarVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnCancelarVenda.FlatStyle = FlatStyle.Flat;
            btnCancelarVenda.Font = new Font("Segoe UI", 9.75F);
            btnCancelarVenda.ForeColor = Color.White;
            btnCancelarVenda.Image = Properties.Resources.cancelar1;
            btnCancelarVenda.Location = new Point(281, -2);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(144, 72);
            btnCancelarVenda.TabIndex = 2;
            btnCancelarVenda.TabStop = false;
            btnCancelarVenda.Text = "Cancelar Venda F3";
            btnCancelarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // btnDesconto
            // 
            btnDesconto.BackColor = Color.Transparent;
            btnDesconto.FlatAppearance.BorderSize = 0;
            btnDesconto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDesconto.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnDesconto.FlatStyle = FlatStyle.Flat;
            btnDesconto.Font = new Font("Segoe UI", 9.75F);
            btnDesconto.ForeColor = Color.White;
            btnDesconto.Image = Properties.Resources.desconto;
            btnDesconto.Location = new Point(431, -2);
            btnDesconto.Name = "btnDesconto";
            btnDesconto.Size = new Size(105, 72);
            btnDesconto.TabIndex = 1;
            btnDesconto.TabStop = false;
            btnDesconto.Text = "Desconto F4";
            btnDesconto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDesconto.UseVisualStyleBackColor = false;
            // 
            // btnFinalizaVenda
            // 
            btnFinalizaVenda.BackColor = Color.Transparent;
            btnFinalizaVenda.FlatAppearance.BorderSize = 0;
            btnFinalizaVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFinalizaVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnFinalizaVenda.FlatStyle = FlatStyle.Flat;
            btnFinalizaVenda.Font = new Font("Segoe UI", 9.75F);
            btnFinalizaVenda.ForeColor = Color.White;
            btnFinalizaVenda.Image = Properties.Resources.finalisar_compra;
            btnFinalizaVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizaVenda.Location = new Point(542, -2);
            btnFinalizaVenda.Name = "btnFinalizaVenda";
            btnFinalizaVenda.Size = new Size(143, 72);
            btnFinalizaVenda.TabIndex = 0;
            btnFinalizaVenda.TabStop = false;
            btnFinalizaVenda.Text = "Finalizar Venda F5";
            btnFinalizaVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinalizaVenda.UseVisualStyleBackColor = false;
            // 
            // labelTituloStatusCaixa
            // 
            labelTituloStatusCaixa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTituloStatusCaixa.BackColor = Color.FromArgb(0, 66, 100);
            labelTituloStatusCaixa.BorderStyle = BorderStyle.Fixed3D;
            labelTituloStatusCaixa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloStatusCaixa.ForeColor = Color.White;
            labelTituloStatusCaixa.Location = new Point(716, 636);
            labelTituloStatusCaixa.Name = "labelTituloStatusCaixa";
            labelTituloStatusCaixa.Size = new Size(827, 47);
            labelTituloStatusCaixa.TabIndex = 12;
            labelTituloStatusCaixa.Text = "Venda Aberta";
            labelTituloStatusCaixa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textTotal
            // 
            textTotal.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTotal.Location = new Point(1109, 545);
            textTotal.Multiline = true;
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(426, 82);
            textTotal.TabIndex = 11;
            textTotal.Text = "0,00";
            textTotal.TextAlign = HorizontalAlignment.Center;
            textTotal.KeyPress += textTotal_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 66, 100);
            label7.Location = new Point(1238, 502);
            label7.Name = "label7";
            label7.Size = new Size(195, 40);
            label7.TabIndex = 10;
            label7.Text = "Total a Pagar";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(1109, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 396);
            panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 358);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(0, 66, 100);
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(426, 38);
            label6.TabIndex = 1;
            label6.Text = "Imagem do produto";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 66, 100);
            label5.Location = new Point(835, 424);
            label5.Name = "label5";
            label5.Size = new Size(142, 32);
            label5.TabIndex = 8;
            label5.Text = "Preço Total";
            // 
            // textReadTotalPreco
            // 
            textReadTotalPreco.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textReadTotalPreco.Location = new Point(728, 459);
            textReadTotalPreco.Multiline = true;
            textReadTotalPreco.Name = "textReadTotalPreco";
            textReadTotalPreco.Size = new Size(350, 40);
            textReadTotalPreco.TabIndex = 7;
            textReadTotalPreco.Text = "0,00";
            textReadTotalPreco.TextAlign = HorizontalAlignment.Center;
            textReadTotalPreco.KeyPress += textTotal_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 66, 100);
            label4.Location = new Point(835, 312);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 6;
            label4.Text = "Preço Unit";
            // 
            // textReadPrecoProduto
            // 
            textReadPrecoProduto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textReadPrecoProduto.Location = new Point(728, 347);
            textReadPrecoProduto.Multiline = true;
            textReadPrecoProduto.Name = "textReadPrecoProduto";
            textReadPrecoProduto.Size = new Size(350, 40);
            textReadPrecoProduto.TabIndex = 5;
            textReadPrecoProduto.Text = "0,00";
            textReadPrecoProduto.TextAlign = HorizontalAlignment.Center;
            textReadPrecoProduto.KeyPress += textTotal_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 66, 100);
            label3.Location = new Point(835, 200);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 4;
            label3.Text = "Quantidade";
            // 
            // textReadQuantProduto
            // 
            textReadQuantProduto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textReadQuantProduto.Location = new Point(728, 235);
            textReadQuantProduto.Multiline = true;
            textReadQuantProduto.Name = "textReadQuantProduto";
            textReadQuantProduto.Size = new Size(350, 40);
            textReadQuantProduto.TabIndex = 3;
            textReadQuantProduto.Text = "1";
            textReadQuantProduto.TextAlign = HorizontalAlignment.Center;
            textReadQuantProduto.KeyPress += textTotal_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 66, 100);
            label2.Location = new Point(863, 56);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 2;
            label2.Text = "Código";
            // 
            // textReadCodProduto
            // 
            textReadCodProduto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textReadCodProduto.Location = new Point(728, 101);
            textReadCodProduto.Multiline = true;
            textReadCodProduto.Name = "textReadCodProduto";
            textReadCodProduto.Size = new Size(350, 40);
            textReadCodProduto.TabIndex = 1;
            textReadCodProduto.Text = "00000000";
            textReadCodProduto.TextAlign = HorizontalAlignment.Center;
            textReadCodProduto.KeyPress += textTotal_KeyPress;
            // 
            // painelGridProdutos
            // 
            painelGridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            painelGridProdutos.BackColor = Color.White;
            painelGridProdutos.BorderStyle = BorderStyle.FixedSingle;
            painelGridProdutos.Controls.Add(labelTituloCaixa);
            painelGridProdutos.Controls.Add(textReadCupom);
            painelGridProdutos.Controls.Add(gridProdutos);
            painelGridProdutos.Location = new Point(3, 3);
            painelGridProdutos.Name = "painelGridProdutos";
            painelGridProdutos.Size = new Size(708, 681);
            painelGridProdutos.TabIndex = 0;
            // 
            // labelTituloCaixa
            // 
            labelTituloCaixa.BackColor = Color.FromArgb(0, 66, 100);
            labelTituloCaixa.BorderStyle = BorderStyle.Fixed3D;
            labelTituloCaixa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloCaixa.ForeColor = Color.White;
            labelTituloCaixa.Location = new Point(0, 631);
            labelTituloCaixa.Name = "labelTituloCaixa";
            labelTituloCaixa.Size = new Size(703, 48);
            labelTituloCaixa.TabIndex = 13;
            labelTituloCaixa.Text = "Caixa 01";
            labelTituloCaixa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textReadCupom
            // 
            textReadCupom.Dock = DockStyle.Top;
            textReadCupom.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textReadCupom.ForeColor = Color.FromArgb(0, 66, 100);
            textReadCupom.Location = new Point(0, 0);
            textReadCupom.Multiline = true;
            textReadCupom.Name = "textReadCupom";
            textReadCupom.Size = new Size(706, 53);
            textReadCupom.TabIndex = 2;
            textReadCupom.Text = "Cupom";
            textReadCupom.TextAlign = HorizontalAlignment.Center;
            textReadCupom.KeyPress += textTotal_KeyPress;
            // 
            // gridProdutos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            gridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridProdutos.BackgroundColor = Color.LightGray;
            gridProdutos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 66, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridProdutos.ColumnHeadersHeight = 35;
            gridProdutos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descricao, Quant, ValorUni, PreçoTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(30, 144, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            gridProdutos.EnableHeadersVisualStyles = false;
            gridProdutos.GridColor = Color.LightGray;
            gridProdutos.Location = new Point(2, 52);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            gridProdutos.RowHeadersVisible = false;
            gridProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridProdutos.Size = new Size(699, 571);
            gridProdutos.TabIndex = 0;
            gridProdutos.Paint += CarregarMarcaDgua_Paint;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 80;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 300;
            // 
            // Quant
            // 
            Quant.HeaderText = "Quant.";
            Quant.Name = "Quant";
            Quant.ReadOnly = true;
            Quant.Width = 80;
            // 
            // ValorUni
            // 
            ValorUni.HeaderText = "Valor Unit.";
            ValorUni.Name = "ValorUni";
            ValorUni.ReadOnly = true;
            ValorUni.Width = 120;
            // 
            // PreçoTotal
            // 
            PreçoTotal.HeaderText = "Preço Total";
            PreçoTotal.Name = "PreçoTotal";
            PreçoTotal.ReadOnly = true;
            PreçoTotal.Width = 120;
            // 
            // Pdv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 825);
            Controls.Add(content);
            Controls.Add(panel2);
            Controls.Add(header);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Pdv";
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            content.ResumeLayout(false);
            content.PerformLayout();
            footer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            painelGridProdutos.ResumeLayout(false);
            painelGridProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel panel2;
        private Panel content;
        private Panel painelGridProdutos;
        private DataGridView gridProdutos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Quant;
        private DataGridViewTextBoxColumn ValorUni;
        private DataGridViewTextBoxColumn PreçoTotal;
        private Label label2;
        private TextBox textReadCodProduto;
        private Label label5;
        private TextBox textReadTotalPreco;
        private Label label4;
        private TextBox textReadPrecoProduto;
        private Label label3;
        private TextBox textReadQuantProduto;
        private Panel panel4;
        private Label label6;
        private PictureBox pictureBox1;
        private Label labelTituloStatusCaixa;
        private TextBox textTotal;
        private Label label7;
        private Panel footer;
        private PictureBox pictureBoxLogo;
        private TextBox textReadCupom;
        private Button btnConsultaProduto;
        private Button btnCancelarVenda;
        private Button btnDesconto;
        private Button btnFinalizaVenda;
        private Button btnNovaVenda;
        private Button btnAbrirGaveta;
        private Button button1;
        private Label labelTituloCaixa;
        private Label label1InfoOperador;
        private Label labelDataHora;
        private Button btnSangria;
        private Label label1;
        private TextBox textBox1;
        private Button btnFecharCaixa;
    }
}