using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarCidade : Form
    {

        private readonly DbConection.DbConectionPdv dbConectionPdv;
        public CadastrarCidade(DbConection.DbConectionPdv dbConectionPdv)
        {
            InitializeComponent();
            this.dbConectionPdv = dbConectionPdv;
        }


        private void CadastrarPais_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;

            this.CarregarGridCidades();
            this.CarregarPaisesCombo();

        }



        private void CarregarGridCidades()
        {
            try
            {
                var cidades = dbConectionPdv.Cidades
                    .OrderBy(c => c.Id)
                    .Select(c => new
                    {
                        Codigo = c.Id,
                        NomeCidade = c.Nome,
                        Pais = c.Pais.Nome
                    })
                    .ToList();

                dataGridCidade.DataSource = cidades;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridCidade.EnableHeadersVisualStyles = false;
                dataGridCidade.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridCidade.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridCidade.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridCidade.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridCidade.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridCidade.DefaultCellStyle.BackColor = Color.White;
                dataGridCidade.DefaultCellStyle.ForeColor = Color.Black;
                dataGridCidade.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridCidade.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridCidade.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridCidade.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridCidade.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridCidade.Columns["Codigo"].HeaderText = "Código";
                dataGridCidade.Columns["Codigo"].Width = 80;
                dataGridCidade.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridCidade.Columns["NomeCidade"].HeaderText = "Nome da Cidade";
                dataGridCidade.Columns["NomeCidade"].Width = 300;

                dataGridCidade.Columns["Pais"].HeaderText = "País";
                dataGridCidade.Columns["Pais"].Width = 250;

                // ==== COMPORTAMENTO ====
                dataGridCidade.ReadOnly = true;
                dataGridCidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridCidade.MultiSelect = false;
                dataGridCidade.BorderStyle = BorderStyle.FixedSingle;
                dataGridCidade.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridCidade.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cidades: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregarPaisesCombo()
        {
            var paises = dbConectionPdv.Paises.OrderBy(p => p.Nome).ToList();
            comboPaises.DataSource = paises;
            comboPaises.DisplayMember = "Nome";
            comboPaises.ValueMember = "Id";
        }




        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            comboPaises.Enabled = true;
            textNome.ReadOnly = false;
            textCodigoCidade.Clear();
            textNome.Clear();
            textNome.Focus();


        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                comboPaises.Enabled = true;
                textNome.ReadOnly = false;
                textCodigoCidade.Clear();
                textNome.Clear();
                textNome.Focus();

            }else if(e.KeyCode == Keys.F5)
            {
                this.GravarCidade();
            }
        }


        private void GravarCidade()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("O nome da cidade é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNome.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textCodigoCidade.Text))
                    {
                        // NOVO REGIDTRO
                        if (dbConectionPdv.Cidades.Any(c => c.Nome == textNome.Text && c.PaisId == (int)comboPaises.SelectedValue))
                        {
                            MessageBox.Show("Já existe uma cidade com esse nome para o país selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textNome.Focus();
                            return;
                        }
                        var novaCidade = new Model.ModelLocalidade.Cidade
                        {
                            Nome = textNome.Text,
                            PaisId = (int)comboPaises.SelectedValue
                        };
                        dbConectionPdv.Cidades.Add(novaCidade);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Cidade cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textCodigoCidade.Text = novaCidade.Id.ToString();
                        this.CarregarGridCidades();
                        return;

                    }
                    else
                    {
                        // EDIÇÃO DE REGISTRO
                        int cidadeId = int.Parse(textCodigoCidade.Text);
                        var cidadeExistente = dbConectionPdv.Cidades.Find(cidadeId);
                        if (cidadeExistente != null)
                        {

                            cidadeExistente.Nome = textNome.Text;
                            cidadeExistente.PaisId = (int)comboPaises.SelectedValue;
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Cidade atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarGridCidades();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Cidade não encontrada para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar a cidade: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarCidade();

        }



        private void BtnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridCidade.SelectedRows.Count > 0)
                {
                    int cidadeId = (int)dataGridCidade.SelectedRows[0].Cells["Codigo"].Value;
                    var cidadeParaEditar = dbConectionPdv.Cidades.Find(cidadeId);
                    if (cidadeParaEditar != null)
                    {
                        this.AbrirAbaCadastro(cidadeParaEditar.Id, cidadeParaEditar.Nome, cidadeParaEditar.PaisId);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma cidade para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cidade para edição: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirAbaCadastro(int id, string nome, int pais)
        {
            tabControl.SelectedTab = tabCadastro;
            textCodigoCidade.Text = id.ToString();
            textNome.Text = nome;
            textNome.ReadOnly = false;
            comboPaises.Enabled = true;
            comboPaises.SelectedValue = pais;

            textNome.Focus();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCidade.SelectedRows.Count > 0)
                {
                    var linhaSelecionada = dataGridCidade.SelectedRows[0];
                    var cidadeId = (int)linhaSelecionada.Cells["Codigo"].Value;
                    var cidadeParaExcluir = dbConectionPdv.Cidades.Find(cidadeId);
                    if (cidadeParaExcluir != null)
                    {
                        var confirmResult = MessageBox.Show("Tem certeza que deseja excluir a cidade selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmResult == DialogResult.Yes)
                        {
                            dbConectionPdv.Cidades.Remove(cidadeParaExcluir);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Cidade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarGridCidades();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cidade não encontrada para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma cidade para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cidade: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {
            var opcaoFiltro = comboFiltros.SelectedItem.ToString();

            if (opcaoFiltro == "Por Nome ")
            {
                var modelo = comboModelo.SelectedItem.ToString();
                var textoPesquisa = textDadosPesquisa.Text;
                IQueryable<Model.ModelLocalidade.Cidade> query = dbConectionPdv.Cidades;

                if (string.IsNullOrWhiteSpace(textoPesquisa))
                {
                    this.CarregarGridCidades();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(textoPesquisa))
                {
                    switch (modelo)
                    {
                        case "Inicia Com":
                            query = query.Where(c => c.Nome.StartsWith(textoPesquisa));
                            break;
                        case "Termina Com":
                            query = query.Where(c => c.Nome.EndsWith(textoPesquisa));
                            break;
                        case "Contem":
                            query = query.Where(c => c.Nome.Contains(textoPesquisa));
                            break;

                    }
                }
                var resultados = query.OrderBy(c => c.Id).Select(c => new
                {
                    Codigo = c.Id,
                    NomeCidade = c.Nome,
                    Pais = c.Pais.Nome
                }).ToList();
                dataGridCidade.DataSource = resultados;
            }
            else if (opcaoFiltro == "Por Codigo ")
            {
                if (int.TryParse(textDadosPesquisa.Text, out int codigo))
                {
                    var resultados = dbConectionPdv.Cidades
                        .Where(c => c.Id == codigo)
                        .OrderBy(c => c.Id)
                        .Select(c => new
                        {
                            Codigo = c.Id,
                            NomeCidade = c.Nome,
                            Pais = c.Pais.Nome
                        }).ToList();
                    dataGridCidade.DataSource = resultados;
                }
                else
                {
                    dataGridCidade.DataSource = null;
                }
            }
        }

        private void CadastrarCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnEditar_Click(this, new EventArgs());
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCadastro;
            comboPaises.Enabled = true;
            textNome.ReadOnly = false;
            textCodigoCidade.Clear();
            textNome.Clear();
            textNome.Focus();
        }
    }
}
