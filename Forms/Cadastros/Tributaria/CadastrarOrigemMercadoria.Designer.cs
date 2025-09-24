namespace ServiTech.Forms.Cadastros.Tributaria
{
    partial class CadastrarOrigemMercadoria
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
            tabPage2 = new TabPage();
            textNomeProd = new TextBox();
            textCodBarra = new TextBox();
            textCodProd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
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
            tabControl1.Size = new Size(658, 331);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(textNomeProd);
            tabPage1.Controls.Add(textCodBarra);
            tabPage1.Controls.Add(textCodProd);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(650, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textNomeProd
            // 
            textNomeProd.Location = new Point(260, 41);
            textNomeProd.Name = "textNomeProd";
            textNomeProd.ReadOnly = true;
            textNomeProd.Size = new Size(380, 23);
            textNomeProd.TabIndex = 60;
            // 
            // textCodBarra
            // 
            textCodBarra.Location = new Point(81, 41);
            textCodBarra.Name = "textCodBarra";
            textCodBarra.ReadOnly = true;
            textCodBarra.Size = new Size(173, 23);
            textCodBarra.TabIndex = 59;
            // 
            // textCodProd
            // 
            textCodProd.Location = new Point(8, 41);
            textCodProd.Name = "textCodProd";
            textCodProd.ReadOnly = true;
            textCodProd.Size = new Size(67, 23);
            textCodProd.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(260, 21);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 61;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(81, 22);
            label2.Name = "label2";
            label2.Size = new Size(107, 16);
            label2.TabIndex = 58;
            label2.Text = "Codigo  da Regra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(8, 21);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 56;
            label1.Text = "Codigo";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 52);
            panel1.TabIndex = 62;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(11, 7);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(78, 40);
            btnNovo.TabIndex = 18;
            btnNovo.Text = "Incluir F4";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Image = Properties.Resources.salvar;
            btnGravar.Location = new Point(95, 7);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(80, 40);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(181, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 40);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar F6";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastrarOrigemMercadoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 331);
            Controls.Add(tabControl1);
            Name = "CadastrarOrigemMercadoria";
            Text = "Cadastrar Origem Mercadorias";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textNomeProd;
        private TextBox textCodBarra;
        private TextBox textCodProd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnNovo;
        private Button btnGravar;
        private Button btnCancelar;
    }
}