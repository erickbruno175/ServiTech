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

            this.CaregarGridCidades();
            this.CarregarPaisesCombo();

        }



        private void CaregarGridCidades()
        {
            try
            {
                var cidades = dbConectionPdv.Cidades.
                    OrderBy(c => c.Id).Select(c => new
                    {
                        Codigo = c.Id,
                        NomeCidade = c.Nome,
                        Pais = c.Pais.Nome

                    }).ToList();
                dataGridCidade.DataSource = cidades;
                dataGridCidade.Columns["NomeCidade"].HeaderText = "Nome da Cidade";
                dataGridCidade.Columns["NomeCidade"].Width = 300;
                dataGridCidade.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarPaisesCombo()
        {
            var paises = dbConectionPdv.Paises.OrderBy(p => p.Nome).ToList();
            comboPaises.DataSource = paises;
            comboPaises.DisplayMember = "Nome";
            comboPaises.ValueMember = "Id";
        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(this.groupBox2.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);
            checkBoxTodos.Location = new Point(this.groupBox2.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);

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

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
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
                        textCodigoCidade.Text = novaCidade.Id.ToString();
                        this.CaregarGridCidades();
                        MessageBox.Show("Cidade cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        // EDIÇÃO DE REGISTRO
                        int cidadeId = int.Parse(textCodigoCidade.Text);
                        var cidadeExistente = dbConectionPdv.Cidades.Find(cidadeId);
                        if (cidadeExistente != null)
                        {
                            if (dbConectionPdv.Cidades.Any(c => c.Nome == textNome.Text && c.PaisId == (int)comboPaises.SelectedValue && c.Id != cidadeId))
                            {
                                MessageBox.Show("Já existe uma cidade com esse nome para o país selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textNome.Focus();
                                return;
                            }
                            cidadeExistente.Nome = textNome.Text;
                            cidadeExistente.PaisId = (int)comboPaises.SelectedValue;
                            dbConectionPdv.SaveChanges();
                            this.CaregarGridCidades();
                            MessageBox.Show("Cidade atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tabControl1.SelectedTab = tabPage1;
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
                            this.CaregarGridCidades();
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

            if(opcaoFiltro == "Por Nome ")
            {
                var modelo = comboModelo.SelectedItem.ToString();
                var textoPesquisa = textDadosPesquisa.Text;
                IQueryable<Model.ModelLocalidade.Cidade> query = dbConectionPdv.Cidades;
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
            else if(opcaoFiltro == "Por Codigo ")
            {
                if(int.TryParse( textDadosPesquisa.Text, out int codigo))
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
    }
}
