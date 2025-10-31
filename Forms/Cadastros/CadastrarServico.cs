using Microsoft.EntityFrameworkCore;
using ServiTech.DbConection;
using ServiTech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarServico : Form
    {
        private readonly DbConectionPdv dbConectionPdv;
        public CadastrarServico(DbConectionPdv dbConectionPdv)
        {
            this.dbConectionPdv = dbConectionPdv;
            InitializeComponent();

        }



        private void CadastrarPais_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome");
            comboFiltros.Items.Add("Por Codigo");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;

            CarregarGridServicos();

        }



        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {
            textNomeServico.ReadOnly = false;
            textNomeServico.Focus();
            textPreco.ReadOnly = false;
            textNomeServico.Clear();
            textPreco.Clear();
            textId.Clear();

        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNomeServico.ReadOnly = false;
                textNomeServico.Focus();
                textPreco.ReadOnly = false;
                textNomeServico.Clear();
                textPreco.Clear();
                textId.Clear();

            }


        }


        private void CarregarGridServicos()
        {
            try
            {
                // Obtém todos os países do banco
                var servicos = dbConectionPdv.Servicos


                    .ToList();

                dataGridServicos.DataSource = servicos;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridServicos.EnableHeadersVisualStyles = false;
                dataGridServicos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridServicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridServicos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridServicos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridServicos.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridServicos.DefaultCellStyle.BackColor = Color.White;
                dataGridServicos.DefaultCellStyle.ForeColor = Color.Black;
                dataGridServicos.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridServicos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridServicos.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridServicos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridServicos.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridServicos.Columns["Id"].HeaderText = "Código";
                dataGridServicos.Columns["Id"].Width = 80;
                dataGridServicos.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridServicos.Columns["Nome"].HeaderText = "Descrição";
                dataGridServicos.Columns["Nome"].Width = 300;



                dataGridServicos.Columns["Preco"].HeaderText = "Valor do Serviço";
                dataGridServicos.Columns["Preco"].Width = 250;





                // ==== COMPORTAMENTO ====
                dataGridServicos.ReadOnly = true;
                dataGridServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridServicos.MultiSelect = false;
                dataGridServicos.BorderStyle = BorderStyle.FixedSingle;
                dataGridServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridServicos.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar serviços : " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void MskararCampoMoeda_Changed(object sender, EventArgs e)
        {

            TextBox textBox = sender as TextBox;


            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string newText = new string(textBox.Text.Where(c => char.IsDigit(c)).ToArray());// Remove todos os caracteres que não são dígitos
                textBox.Text = newText;// Atualiza o texto da TextBox
                textBox.SelectionStart = textBox.Text.Length; // Coloca o cursor no final do texto
            }


            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string texto = textBox.Text.Replace("R$", "")
                                   .Replace(".", "")
                                   .Replace(",", "")
                                   .Trim();
                if (decimal.TryParse(texto, out decimal valor)) // tenta converter o texto para decimal
                {
                    textBox.TextChanged -= MskararCampoMoeda_Changed; // evita loop
                    textBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", valor / 100);// formata para moeda BRL
                    textBox.SelectionStart = textBox.Text.Length; // cursor no fim
                    textBox.TextChanged += MskararCampoMoeda_Changed; // reativa o evento
                }
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            textNomeServico.ReadOnly = false;
            textNomeServico.Focus();
            textPreco.ReadOnly = false;
            textNomeServico.Clear();
            textId.Clear();
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {

            string filtro = comboFiltros.SelectedItem?.ToString();
            string modelo = comboModelo.SelectedItem?.ToString();
            string valorPesquisado = textDadosPesquisa.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(valorPesquisado))
            {
                CarregarGridServicos();
                return;
            }



            IQueryable<Model.Servico> query = dbConectionPdv.Servicos.AsQueryable();


            if (filtro == "Por Nome")
            {
                if (modelo == "Inicia Com")
                {
                    query = query.Where(s => s.Nome.ToLower().StartsWith(valorPesquisado));
                }
                else if (modelo == "Termina Com")
                {
                    query = query.Where(s => s.Nome.ToLower().EndsWith(valorPesquisado));

                }
                else if (modelo == "Contem")
                {
                    query = query.Where(s => s.Nome.ToLower().Contains(valorPesquisado));

                }
            }
            else
            {
                if (int.TryParse(valorPesquisado, out int id))
                {
                    query = query.Where(s => s.Id == id);


                }
                else
                {
                    query = Enumerable.Empty<Model.Servico>().AsQueryable();
                }
            }

            var resultado = query.ToList();
            dataGridServicos.DataSource = resultado;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridServicos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridServicos.SelectedRows[0];
                int servicoId = (int)selectedRow.Cells["Id"].Value;
                var servicoParaExcluir = dbConectionPdv.Servicos.Find(servicoId);
                var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o serviço '{servicoParaExcluir.Nome}'?",
                                     "Confirmação de Exclusão",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        dbConectionPdv.Servicos.Remove(servicoParaExcluir);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Serviço excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarGridServicos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um serviço para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridServicos.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridServicos.SelectedRows[0];
                    int servicoId = (int)selectedRow.Cells["Id"].Value;
                    var servicoParaEdicao = dbConectionPdv.Servicos.Find(servicoId);
                    AbrirAbaCadastroServico(servicoParaEdicao);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu  um erro ao realizar a consultar ." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void AbrirAbaCadastroServico(Model.Servico servico)
        {
            tabControl1.SelectedTab = tabCadastro;
            textNomeServico.ReadOnly = false;
            textNomeServico.Focus();
            textPreco.ReadOnly = false;

            checkAtivo.Checked = servico.Ativo;
            textId.Text = servico.Id.ToString();
            textNomeServico.Text = servico.Nome.ToString();
            textPreco.Text = servico.Preco.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "0,00";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            this.GravarServico();
        }


        private void GravarServico()
        {
            if (string.IsNullOrWhiteSpace(textNomeServico.Text) || string.IsNullOrWhiteSpace(textPreco.Text))
            {
                MessageBox.Show("Atenção campos obrigatorio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textId.Text))
                {
                    bool jaExisteServico = dbConectionPdv.Servicos.Any(s => s.Nome == textNomeServico.Text);
                    if (jaExisteServico)
                    {
                        MessageBox.Show("Atenção esse serviços ja existe ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    var servico = new Model.Servico
                    {
                     Nome = textNomeServico.Text,
                     Preco = decimal.Parse(textPreco.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture),
                     Ativo = checkAtivo.Checked,

                    };

                    dbConectionPdv.Add(servico);
                    dbConectionPdv.SaveChanges();

                    MessageBox.Show("Serviço cadastradp com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textId.Text = servico.Id.ToString();
                    CarregarGridServicos();
                    return;
                }else
                {
                    if(int.TryParse(textId.Text , out int id))
                    {
                        var servicoEdicao = dbConectionPdv.Servicos.Find(id);

                        servicoEdicao.Nome = textNomeServico.Text;
                        servicoEdicao.Preco = decimal.Parse(textPreco.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture);
                        servicoEdicao.Ativo = checkAtivo.Checked;
                        dbConectionPdv.SaveChanges();

                        MessageBox.Show("Serviço atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CarregarGridServicos();
                        return;
                    }
                }
            }
        }
    }
}
