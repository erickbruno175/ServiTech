using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pdv));
            header = new Panel();
            labelInfoCaixa = new Label();
            labelDataHora = new Label();
            labelInfoOperador = new Label();
            pictureBoxLogo = new PictureBox();
            panel2 = new Panel();
            content = new Panel();
            textBoxTitulo = new TextBox();
            btnAbrirGaveta = new Button();
            textTotal = new TextBox();
            panel4 = new Panel();
            pictureLogo = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            textDecProduto = new TextBox();
            label4 = new Label();
            textQunatProduto = new TextBox();
            label3 = new Label();
            textQauntiProduto = new TextBox();
            label2 = new Label();
            textCodProduto = new TextBox();
            painelGridProdutos = new Panel();
            textCupom = new TextBox();
            gridItensVendas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Quant = new DataGridViewTextBoxColumn();
            ValorUni = new DataGridViewTextBoxColumn();
            PreçoTotal = new DataGridViewTextBoxColumn();
            btnFinalizaVenda = new Button();
            btnDesconto = new Button();
            btnCancelarVenda = new Button();
            btnConsultaProduto = new Button();
            btnNovaVenda = new Button();
            btnSair = new Button();
            paienlButtosOperacoes = new Panel();
            labelMessagem = new Label();
            label7 = new Label();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            content.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            painelGridProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridItensVendas).BeginInit();
            paienlButtosOperacoes.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(0, 66, 100);
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(labelInfoCaixa);
            header.Controls.Add(labelDataHora);
            header.Controls.Add(labelInfoOperador);
            header.Controls.Add(pictureBoxLogo);
            header.Dock = DockStyle.Top;
            header.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            header.ForeColor = Color.White;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1547, 66);
            header.TabIndex = 0;
            // 
            // labelInfoCaixa
            // 
            labelInfoCaixa.AccessibleRole = AccessibleRole.OutlineButton;
            labelInfoCaixa.BackColor = Color.Transparent;
            labelInfoCaixa.Dock = DockStyle.Fill;
            labelInfoCaixa.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoCaixa.ForeColor = Color.White;
            labelInfoCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            labelInfoCaixa.Location = new Point(165, 0);
            labelInfoCaixa.Name = "labelInfoCaixa";
            labelInfoCaixa.Size = new Size(1017, 64);
            labelInfoCaixa.TabIndex = 8;
            labelInfoCaixa.Text = "Caixa-1";
            labelInfoCaixa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDataHora
            // 
            labelDataHora.BackColor = Color.Transparent;
            labelDataHora.Dock = DockStyle.Right;
            labelDataHora.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDataHora.ForeColor = Color.White;
            labelDataHora.Location = new Point(1182, 0);
            labelDataHora.Name = "labelDataHora";
            labelDataHora.Size = new Size(183, 64);
            labelDataHora.TabIndex = 7;
            labelDataHora.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelInfoOperador
            // 
            labelInfoOperador.AccessibleRole = AccessibleRole.OutlineButton;
            labelInfoOperador.BackColor = Color.Transparent;
            labelInfoOperador.Dock = DockStyle.Right;
            labelInfoOperador.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoOperador.ForeColor = Color.White;
            labelInfoOperador.ImageAlign = ContentAlignment.MiddleLeft;
            labelInfoOperador.Location = new Point(1365, 0);
            labelInfoOperador.Name = "labelInfoOperador";
            labelInfoOperador.Size = new Size(180, 64);
            labelInfoOperador.TabIndex = 3;
            labelInfoOperador.Text = "Op: Pedro Silva";
            labelInfoOperador.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Left;
            pictureBoxLogo.Image = Properties.Resources.imagemlogo;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(165, 64);
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
            content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            content.BackColor = Color.White;
            content.Controls.Add(textBoxTitulo);
            content.Controls.Add(btnAbrirGaveta);
            content.Controls.Add(paienlButtosOperacoes);
            content.Controls.Add(textTotal);
            content.Controls.Add(label7);
            content.Controls.Add(panel4);
            content.Controls.Add(label5);
            content.Controls.Add(textDecProduto);
            content.Controls.Add(label4);
            content.Controls.Add(textQunatProduto);
            content.Controls.Add(label3);
            content.Controls.Add(textQauntiProduto);
            content.Controls.Add(label2);
            content.Controls.Add(textCodProduto);
            content.Controls.Add(painelGridProdutos);
            content.Location = new Point(0, 66);
            content.Name = "content";
            content.Size = new Size(1547, 759);
            content.TabIndex = 2;
            content.Resize += panel3_Resize;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.BackColor = Color.FromArgb(0, 66, 100);
            textBoxTitulo.Dock = DockStyle.Top;
            textBoxTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTitulo.ForeColor = Color.White;
            textBoxTitulo.Location = new Point(0, 0);
            textBoxTitulo.Multiline = true;
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(1547, 72);
            textBoxTitulo.TabIndex = 15;
            textBoxTitulo.TextAlign = HorizontalAlignment.Center;
            textBoxTitulo.KeyPress += textReadTotalPreco_KeyPress;
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
            btnAbrirGaveta.Location = new Point(1226, 127);
            btnAbrirGaveta.Name = "btnAbrirGaveta";
            btnAbrirGaveta.Size = new Size(172, 39);
            btnAbrirGaveta.TabIndex = 5;
            btnAbrirGaveta.TabStop = false;
            btnAbrirGaveta.Text = "Abrir Gaveta F12";
            btnAbrirGaveta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbrirGaveta.UseVisualStyleBackColor = false;
            // 
            // textTotal
            // 
            textTotal.BackColor = Color.FromArgb(0, 64, 0);
            textTotal.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTotal.ForeColor = Color.White;
            textTotal.Location = new Point(821, 602);
            textTotal.Multiline = true;
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(722, 77);
            textTotal.TabIndex = 11;
            textTotal.Text = "0,00";
            textTotal.TextAlign = HorizontalAlignment.Right;
            textTotal.TextChanged += MskararCampoMoeda_Changed;
            textTotal.KeyPress += textTotal_KeyPress_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureLogo);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(1226, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 351);
            panel4.TabIndex = 9;
            // 
            // pictureLogo
            // 
            pictureLogo.BorderStyle = BorderStyle.Fixed3D;
            pictureLogo.Dock = DockStyle.Fill;
            pictureLogo.Image = Properties.Resources.marca;
            pictureLogo.Location = new Point(0, 46);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(309, 305);
            pictureLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureLogo.TabIndex = 2;
            pictureLogo.TabStop = false;
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
            label6.Size = new Size(309, 46);
            label6.TabIndex = 1;
            label6.Text = "Sua Logo Aqui!";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 66, 100);
            label5.Location = new Point(984, 449);
            label5.Name = "label5";
            label5.Size = new Size(58, 30);
            label5.TabIndex = 8;
            label5.Text = "Desc";
            // 
            // textDecProduto
            // 
            textDecProduto.Font = new Font("Segoe UI", 26.25F);
            textDecProduto.Location = new Point(842, 482);
            textDecProduto.Multiline = true;
            textDecProduto.Name = "textDecProduto";
            textDecProduto.PlaceholderText = "0,00";
            textDecProduto.Size = new Size(350, 67);
            textDecProduto.TabIndex = 7;
            textDecProduto.TextAlign = HorizontalAlignment.Center;
            textDecProduto.TextChanged += MskararCampoMoeda_Changed;
            textDecProduto.KeyPress += textReadTotalPreco_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 66, 100);
            label4.Location = new Point(958, 343);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 6;
            label4.Text = "Preço Unit";
            // 
            // textQunatProduto
            // 
            textQunatProduto.Font = new Font("Segoe UI", 26.25F);
            textQunatProduto.Location = new Point(842, 376);
            textQunatProduto.Multiline = true;
            textQunatProduto.Name = "textQunatProduto";
            textQunatProduto.PlaceholderText = "0,00";
            textQunatProduto.Size = new Size(350, 67);
            textQunatProduto.TabIndex = 5;
            textQunatProduto.TextAlign = HorizontalAlignment.Center;
            textQunatProduto.TextChanged += MskararCampoMoeda_Changed;
            textQunatProduto.KeyPress += textReadTotalPreco_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 66, 100);
            label3.Location = new Point(992, 237);
            label3.Name = "label3";
            label3.Size = new Size(50, 30);
            label3.TabIndex = 4;
            label3.Text = "Qtd";
            // 
            // textQauntiProduto
            // 
            textQauntiProduto.Font = new Font("Segoe UI", 26.25F);
            textQauntiProduto.Location = new Point(842, 270);
            textQauntiProduto.Multiline = true;
            textQauntiProduto.Name = "textQauntiProduto";
            textQauntiProduto.PlaceholderText = "1";
            textQauntiProduto.Size = new Size(350, 67);
            textQauntiProduto.TabIndex = 3;
            textQauntiProduto.TextAlign = HorizontalAlignment.Center;
            textQauntiProduto.KeyPress += textReadTotalPreco_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 66, 100);
            label2.Location = new Point(867, 128);
            label2.Name = "label2";
            label2.Size = new Size(299, 30);
            label2.TabIndex = 2;
            label2.Text = "Cód. Barra / Descr. / Cód. Int.";
            // 
            // textCodProduto
            // 
            textCodProduto.Font = new Font("Segoe UI", 26.25F);
            textCodProduto.Location = new Point(842, 162);
            textCodProduto.Multiline = true;
            textCodProduto.Name = "textCodProduto";
            textCodProduto.PlaceholderText = "0000";
            textCodProduto.Size = new Size(350, 67);
            textCodProduto.TabIndex = 1;
            textCodProduto.TextAlign = HorizontalAlignment.Center;
            textCodProduto.Enter += textReadCodProduto_TextChanged;
            // 
            // painelGridProdutos
            // 
            painelGridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            painelGridProdutos.BackColor = Color.White;
            painelGridProdutos.BorderStyle = BorderStyle.FixedSingle;
            painelGridProdutos.Controls.Add(labelMessagem);
            painelGridProdutos.Controls.Add(textCupom);
            painelGridProdutos.Controls.Add(gridItensVendas);
            painelGridProdutos.Location = new Point(3, 70);
            painelGridProdutos.Name = "painelGridProdutos";
            painelGridProdutos.Size = new Size(813, 613);
            painelGridProdutos.TabIndex = 0;
            painelGridProdutos.Paint += painelGridProdutos_Paint;
            // 
            // textCupom
            // 
            textCupom.Dock = DockStyle.Top;
            textCupom.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textCupom.ForeColor = Color.FromArgb(0, 66, 100);
            textCupom.Location = new Point(0, 0);
            textCupom.Name = "textCupom";
            textCupom.Size = new Size(811, 39);
            textCupom.TabIndex = 2;
            textCupom.Text = "Cupom";
            textCupom.TextAlign = HorizontalAlignment.Center;
            textCupom.UseWaitCursor = true;
            textCupom.KeyPress += textTotal_KeyPress;
            // 
            // gridItensVendas
            // 
            gridItensVendas.AllowUserToAddRows = false;
            gridItensVendas.AllowUserToDeleteRows = false;
            gridItensVendas.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            gridItensVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridItensVendas.BackgroundColor = Color.LightGray;
            gridItensVendas.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 66, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridItensVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridItensVendas.ColumnHeadersHeight = 35;
            gridItensVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridItensVendas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descricao, Quant, ValorUni, PreçoTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 66, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridItensVendas.DefaultCellStyle = dataGridViewCellStyle3;
            gridItensVendas.EnableHeadersVisualStyles = false;
            gridItensVendas.GridColor = Color.LightGray;
            gridItensVendas.Location = new Point(2, 39);
            gridItensVendas.Name = "gridItensVendas";
            gridItensVendas.ReadOnly = true;
            gridItensVendas.RowHeadersVisible = false;
            gridItensVendas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridItensVendas.Size = new Size(809, 489);
            gridItensVendas.TabIndex = 0;
            gridItensVendas.Paint += CarregarMarcaDgua_Paint;
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
            Descricao.Width = 420;
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
            // btnFinalizaVenda
            // 
            btnFinalizaVenda.BackColor = Color.Transparent;
            btnFinalizaVenda.FlatAppearance.BorderSize = 0;
            btnFinalizaVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFinalizaVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnFinalizaVenda.FlatStyle = FlatStyle.Flat;
            btnFinalizaVenda.Font = new Font("Segoe UI", 12F);
            btnFinalizaVenda.ForeColor = Color.White;
            btnFinalizaVenda.Image = Properties.Resources.pagar;
            btnFinalizaVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizaVenda.Location = new Point(600, 0);
            btnFinalizaVenda.Name = "btnFinalizaVenda";
            btnFinalizaVenda.Size = new Size(159, 72);
            btnFinalizaVenda.TabIndex = 0;
            btnFinalizaVenda.TabStop = false;
            btnFinalizaVenda.Text = "Finalizar Venda F5";
            btnFinalizaVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinalizaVenda.UseVisualStyleBackColor = false;
            // 
            // btnDesconto
            // 
            btnDesconto.BackColor = Color.Transparent;
            btnDesconto.FlatAppearance.BorderSize = 0;
            btnDesconto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDesconto.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnDesconto.FlatStyle = FlatStyle.Flat;
            btnDesconto.Font = new Font("Segoe UI", 12F);
            btnDesconto.ForeColor = Color.White;
            btnDesconto.Image = Properties.Resources.desconto;
            btnDesconto.Location = new Point(489, -1);
            btnDesconto.Name = "btnDesconto";
            btnDesconto.Size = new Size(105, 72);
            btnDesconto.TabIndex = 1;
            btnDesconto.TabStop = false;
            btnDesconto.Text = "Desc/Acres F4";
            btnDesconto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDesconto.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.BackColor = Color.Transparent;
            btnCancelarVenda.FlatAppearance.BorderSize = 0;
            btnCancelarVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancelarVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnCancelarVenda.FlatStyle = FlatStyle.Flat;
            btnCancelarVenda.Font = new Font("Segoe UI", 12F);
            btnCancelarVenda.ForeColor = Color.White;
            btnCancelarVenda.Image = Properties.Resources.cancelar1;
            btnCancelarVenda.Location = new Point(322, 1);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(161, 72);
            btnCancelarVenda.TabIndex = 2;
            btnCancelarVenda.TabStop = false;
            btnCancelarVenda.Text = "Cancelar Venda F3";
            btnCancelarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // btnConsultaProduto
            // 
            btnConsultaProduto.BackColor = Color.Transparent;
            btnConsultaProduto.FlatAppearance.BorderSize = 0;
            btnConsultaProduto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConsultaProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnConsultaProduto.FlatStyle = FlatStyle.Flat;
            btnConsultaProduto.Font = new Font("Segoe UI", 12F);
            btnConsultaProduto.ForeColor = Color.White;
            btnConsultaProduto.Image = Properties.Resources.prod;
            btnConsultaProduto.Location = new Point(141, 1);
            btnConsultaProduto.Name = "btnConsultaProduto";
            btnConsultaProduto.Size = new Size(175, 72);
            btnConsultaProduto.TabIndex = 3;
            btnConsultaProduto.TabStop = false;
            btnConsultaProduto.Text = "Consultar Produto  F2";
            btnConsultaProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaProduto.UseVisualStyleBackColor = false;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.BackColor = Color.Transparent;
            btnNovaVenda.FlatAppearance.BorderSize = 0;
            btnNovaVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNovaVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnNovaVenda.FlatStyle = FlatStyle.Flat;
            btnNovaVenda.Font = new Font("Segoe UI", 12F);
            btnNovaVenda.ForeColor = Color.White;
            btnNovaVenda.Image = Properties.Resources.carrinho_de_compras1;
            btnNovaVenda.Location = new Point(2, -2);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(133, 72);
            btnNovaVenda.TabIndex = 4;
            btnNovaVenda.TabStop = false;
            btnNovaVenda.Text = " Nova Venda  F1";
            btnNovaVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovaVenda.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.ForeColor = Color.White;
            btnSair.Image = Properties.Resources.sair1;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(765, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(117, 73);
            btnSair.TabIndex = 9;
            btnSair.TabStop = false;
            btnSair.Text = "Sair Esc";
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += SairPdv_Click;
            // 
            // paienlButtosOperacoes
            // 
            paienlButtosOperacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paienlButtosOperacoes.BackColor = Color.FromArgb(0, 60, 100);
            paienlButtosOperacoes.BorderStyle = BorderStyle.Fixed3D;
            paienlButtosOperacoes.Controls.Add(btnSair);
            paienlButtosOperacoes.Controls.Add(btnNovaVenda);
            paienlButtosOperacoes.Controls.Add(btnConsultaProduto);
            paienlButtosOperacoes.Controls.Add(btnCancelarVenda);
            paienlButtosOperacoes.Controls.Add(btnDesconto);
            paienlButtosOperacoes.Controls.Add(btnFinalizaVenda);
            paienlButtosOperacoes.Location = new Point(3, 682);
            paienlButtosOperacoes.Name = "paienlButtosOperacoes";
            paienlButtosOperacoes.Size = new Size(1540, 77);
            paienlButtosOperacoes.TabIndex = 13;
            // 
            // labelMessagem
            // 
            labelMessagem.BackColor = Color.FromArgb(0, 66, 100);
            labelMessagem.Dock = DockStyle.Bottom;
            labelMessagem.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessagem.ForeColor = Color.White;
            labelMessagem.Location = new Point(0, 531);
            labelMessagem.Name = "labelMessagem";
            labelMessagem.Size = new Size(811, 80);
            labelMessagem.TabIndex = 3;
            labelMessagem.Text = "CAIXA LIVRE";
            labelMessagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 66, 100);
            label7.Location = new Point(1438, 559);
            label7.Name = "label7";
            label7.Size = new Size(105, 40);
            label7.TabIndex = 10;
            label7.Text = "Total ";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Pdv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 825);
            Controls.Add(content);
            Controls.Add(panel2);
            Controls.Add(header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Pdv";
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += CapturaTecla;
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            content.ResumeLayout(false);
            content.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            painelGridProdutos.ResumeLayout(false);
            painelGridProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridItensVendas).EndInit();
            paienlButtosOperacoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel panel2;
        private Panel content;
        private Panel painelGridProdutos;
        private DataGridView gridItensVendas;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Quant;
        private DataGridViewTextBoxColumn ValorUni;
        private DataGridViewTextBoxColumn PreçoTotal;
        private TextBox textCodProduto;
        private PictureBox pictureBoxLogo;
        private TextBox textCupom;
        private Label labelInfoOperador;
        private Label labelDataHora;
        private TextBox textTotal;
        private Label labelInfoCaixa;
        private TextBox textBoxTitulo;
        private Button btnAbrirGaveta;
        private Panel panel4;
        private PictureBox pictureLogo;
        private Label label6;
        private Label label5;
        private TextBox textDecProduto;
        private Label label4;
        private TextBox textQunatProduto;
        private Label label3;
        private TextBox textQauntiProduto;
        private Label label2;
        private Panel paienlButtosOperacoes;
        private Button btnSair;
        private Button btnNovaVenda;
        private Button btnConsultaProduto;
        private Button btnCancelarVenda;
        private Button btnDesconto;
        private Button btnFinalizaVenda;
        private Label labelMessagem;
        private Label label7;
    }
}