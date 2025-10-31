using ServiTech.DbConection;
using ServiTech.Model;
using ServiTech.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarCargo : Form
    {
        private readonly DbConectionPdv dbConectionPdv;
        public CadastrarCargo(DbConectionPdv dbConectionPdv)
        {
            InitializeComponent();
            this.dbConectionPdv = dbConectionPdv;
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

            this.CarregarGridCargos();

        }



        private void CarregarGridCargos()
        {
            try
            {
                // Obtém todos os países do banco
                var cargos = dbConectionPdv.Cargos


                    .ToList();

                dataGridCargos.DataSource = cargos;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridCargos.EnableHeadersVisualStyles = false;
                dataGridCargos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridCargos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridCargos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridCargos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridCargos.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridCargos.DefaultCellStyle.BackColor = Color.White;
                dataGridCargos.DefaultCellStyle.ForeColor = Color.Black;
                dataGridCargos.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridCargos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridCargos.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridCargos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridCargos.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridCargos.Columns["Id"].HeaderText = "Código";
                dataGridCargos.Columns["Id"].Width = 80;
                dataGridCargos.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dataGridCargos.Columns["Nome"].HeaderText = "Nome";
                dataGridCargos.Columns["Nome"].Width = 250;


                // ==== COMPORTAMENTO ====
                dataGridCargos.ReadOnly = true;
                dataGridCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridCargos.MultiSelect = false;
                dataGridCargos.BorderStyle = BorderStyle.FixedSingle;
                dataGridCargos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridCargos.GridColor = Color.FromArgb(220, 220, 220);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os  cargos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNome.ReadOnly = false;
                textNome.Focus();
                textCod.Clear();
                textNome.Clear();
            }
            else if (e.KeyCode == Keys.F5)
            {

            }
        }

        private void LiberarCampos_Click(object sender, EventArgs e)
        {
            textNome.ReadOnly = false;
            textNome.Focus();
            textCod.Clear();
            textNome.Clear();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridCargos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridCargos.SelectedRows[0];
                int cargoId = (int)selectedRow.Cells["Id"].Value;
                var cargoParaEditar = dbConectionPdv.Cargos.Find(cargoId);

                this.AbrirAbaCadastro(cargoParaEditar.Id, cargoParaEditar.Nome);
            }
            else
            {
                MessageBox.Show("Selecione um cargo para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(int id, string nome)
        {
            tabControl1.SelectedTab = tabCadastro;
            textCod.Text = id.ToString();
            textNome.Text = nome;
            textNome.ReadOnly = false;

        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            textNome.ReadOnly = false;
            textNome.Focus();
            textCod.Clear();
            textNome.Clear();

        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = comboFiltros.SelectedItem?.ToString();
                string modeloPesquisa = comboModelo.SelectedItem?.ToString(); // <- alterado aqui
                string dadosBuscar = textDadosPesquisa.Text.Trim().ToLower();

                IQueryable<Model.Cargo> query = dbConectionPdv.Cargos.AsQueryable();

                if (string.IsNullOrWhiteSpace(dadosBuscar))
                {
                    CarregarGridCargos();
                    return;
                }

                if (filtro == "Por Nome")
                {
                    if (modeloPesquisa == "Inicia Com")
                    {
                        query = query.Where(c => c.Nome.ToLower().StartsWith(dadosBuscar));
                    }
                    else if (modeloPesquisa == "Contém")
                    {
                        query = query.Where(c => c.Nome.ToLower().Contains(dadosBuscar));
                    }
                    else if (modeloPesquisa == "Termina Com")
                    {
                        query = query.Where(c => c.Nome.ToLower().EndsWith(dadosBuscar));
                    }
                }
                else if (filtro == "Por Codigo")
                {
                    if (int.TryParse(dadosBuscar, out int codigo))
                    {
                        query = query.Where(c => c.Id == codigo);
                    }
                    else
                    {
                        query = Enumerable.Empty<Model.Cargo>().AsQueryable();
                    }
                }

                var resultados = query.ToList();
                dataGridCargos.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu na sua busca: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridCargos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridCargos.SelectedRows[0];
                int cargoId = (int)selectedRow.Cells["Id"].Value;
                var cargoParaExcluir = dbConectionPdv.Cargos.Find(cargoId);
                var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o cargo '{cargoParaExcluir.Nome}'?",
                                     "Confirmação de Exclusão",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        dbConectionPdv.Cargos.Remove(cargoParaExcluir);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Cargo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarGridCargos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o cargo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cargo para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarCargo();
        }

        private void GravarCargo()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("O nome do cargo não pode estar vazio.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    if (string.IsNullOrWhiteSpace(textCod.Text))
                    {
                        bool existeCargo = dbConectionPdv.Cargos.Any(c => c.Nome == textNome.Text);

                        if (existeCargo)
                        {
                            MessageBox.Show("Ja existe um cargo com esse nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }else
                        {
                            Cargo novoCargo = new Cargo
                            {
                                Nome = textNome.Text.Trim()
                            };

                            dbConectionPdv.Add(novoCargo);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Cargo cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textCod.Text = novoCargo.Id.ToString();
                            CarregarGridCargos();
                            return;

                        }
                    }else
                    {
                        int cargoId = int.Parse(textCod.Text);
                        var cargoParaEditar = dbConectionPdv.Cargos.Find(cargoId);
                        if(cargoParaEditar != null)
                        {
                            cargoParaEditar.Nome = textNome.Text.Trim();
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Cargo atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CarregarGridCargos();
                            return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cargo: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
