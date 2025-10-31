using ServiTech.DbConection;
using ServiTech.Enumeradores;
using ServiTech.Model;
using ServiTech.Model.ModelLocalidade;
using ServiTech.Model.ModelTransportadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarTransportadora : Form
    {
        private readonly DbConection.DbConectionPdv dbConectionPdv;
        public CadastrarTransportadora(DbConectionPdv dbConectionPdv)
        {
            this.dbConectionPdv = dbConectionPdv;
            InitializeComponent();
        }



        private void LiberarCamposParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    HabilitarControles(tab.Controls);
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.GravarTransportadora();

            }
        }

        private void HabilitarControles(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        this.textCod.ReadOnly = true; // seu campo específico
                        this.textRazaoSocial.Focus();
                        textBox.Clear();
                        textBox.ReadOnly = false;

                        break;

                    case ComboBox comboBox:
                        comboBox.Enabled = true;
                        comboTipoInscricao.SelectedIndex = -1; // Nenhum item selecionado
                        comboPaises.SelectedIndex = -1; // Nenhum país selecionado inicialmente
                        comboCidades.SelectedIndex = -1; // Nenhum item selecionado
                        comboBairros.SelectedIndex = -1; // Nenhum item selecionado
                        comboBoxUf.SelectedIndex = -1; // Nenhum item selecionado
                        comboBoxAtividade.SelectedIndex = -1;
                        comboTipoTransportadora.SelectedIndex = -1;
                        comboTipoVeiculo.SelectedIndex = -1;
                        comboUfsVeiculo.SelectedIndex = -1;
                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.ReadOnly = false;
                        maskedTextBox.Clear();
                        textDataCadastro.ReadOnly = true;
                        textUltimaAtualizacao.ReadOnly = true;
                        break;

                    case RadioButton radioButton:
                        radioButton.Enabled = true;
                        break;

                    case Button button:
                        button.Enabled = true;
                        break;

                }

                // Se o controle tiver filhos (como GroupBox, Panel, etc.), chama de novo
                if (control.HasChildren)
                {
                    HabilitarControles(control.Controls);
                }
            }
        }





        private void LiberarCamposParaCadastro_Click(object sender, EventArgs e)
        {


            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }

        }

        private void DefinirMascaraCpfCnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPessaoJuridica.Checked)
            {
                textCpfCnpj.Mask = "00.000.000/0000-00";
                labelCpfCnpj.Text = "CNPJ";
                textTipoPessoa.Text = "Juridica";
            }
            if (radioButtonPessoaFisica.Checked)
            {
                textCpfCnpj.Mask = "000.000.000-00";
                labelCpfCnpj.Text = "CPF";
                textTipoPessoa.Text = "Fisica";
            }

        }



        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome Fantasia ");
            comboFiltros.Items.Add("Por Codigo ");
            comboFiltros.Items.Add("Por Cpf ou Cnpj ");
            comboFiltros.Items.Add("Por Razão Social ");


            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;
            CarregarTransportadoras();
            CarregarPaisesCombo();
            this.CarregarAtividadesCombo();

        }



        private void CarregarAtividadesCombo()
        {
            var atividades = dbConectionPdv.AtividadeEconomicas.OrderBy(ae => ae.Nome).ToList();
            comboBoxAtividade.DataSource = atividades;
            comboBoxAtividade.DisplayMember = "Nome";
            comboBoxAtividade.ValueMember = "Id";
        }

        private void CarregarPaisesCombo()
        {
            var paises = dbConectionPdv.Paises.OrderBy(p => p.Nome).ToList();
            comboPaises.DataSource = paises;
            comboPaises.DisplayMember = "Nome";
            comboPaises.ValueMember = "Id";
            comboPaises.SelectedIndex = 5; // Nenhum país selecionado inicialmente


        }

        private void LiberarCampos_Click(object sender, EventArgs e)
        {

            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }
        }


        private void CarregarTransportadoras()
        {
            var transportadora = dbConectionPdv.Transportadoras.ToList();

            labelTotalRegistro.Text = "Total Registros : " + transportadora.Count;

            dataGridTranspor.DataSource = transportadora;


            // ==== ESTILO DO CABEÇALHO ====
            dataGridTranspor.EnableHeadersVisualStyles = false;
            dataGridTranspor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
            dataGridTranspor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridTranspor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold); // Fonte menor
            dataGridTranspor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridTranspor.ColumnHeadersHeight = 32; // Altura levemente menor

            // ==== ESTILO DAS LINHAS ====
            dataGridTranspor.DefaultCellStyle.BackColor = Color.White;
            dataGridTranspor.DefaultCellStyle.ForeColor = Color.Black;
            dataGridTranspor.DefaultCellStyle.Font = new Font("Segoe UI", 8F); // Fonte menor
            dataGridTranspor.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
            dataGridTranspor.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridTranspor.RowHeadersVisible = false;
            dataGridTranspor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dataGridTranspor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // ==== CONFIGURAÇÃO DAS COLUNAS ====
            dataGridTranspor.Columns["Id"].HeaderText = "Código";
            dataGridTranspor.Columns["Id"].Width = 70;

            dataGridTranspor.Columns["TipoPessoa"].HeaderText = "Tipo Pessoa";
            dataGridTranspor.Columns["TipoPessoa"].Width = 150;

            dataGridTranspor.Columns["CnpjCpf"].HeaderText = "Cnpj Ou Cpf";
            dataGridTranspor.Columns["CnpjCpf"].Width = 150;


            dataGridTranspor.Columns["RazaoSocial"].HeaderText = "Razão Social";
            dataGridTranspor.Columns["RazaoSocial"].Width = 300;



            dataGridTranspor.Columns["NomeFantasia"].HeaderText = "Nome Fantasia";
            dataGridTranspor.Columns["NomeFantasia"].Width = 300;


            dataGridTranspor.Columns["InscricaoEstadual"].HeaderText = "Inscrição Estadual";
            dataGridTranspor.Columns["InscricaoEstadual"].Width = 300;

            dataGridTranspor.Columns["InscricaoMunicipal"].HeaderText = "Inscrição Municipal";
            dataGridTranspor.Columns["InscricaoMunicipal"].Width = 300;



            dataGridTranspor.Columns["TipoInscricao"].HeaderText = "Tipo de Inscrição";
            dataGridTranspor.Columns["TipoInscricao"].Width = 300;

            dataGridTranspor.Columns["TelefoneFixo"].HeaderText = "Telefone Fixo";
            dataGridTranspor.Columns["TelefoneFixo"].Width = 300;



            dataGridTranspor.Columns["Endereco"].HeaderText = "Endereço";
            dataGridTranspor.Columns["Endereco"].Width = 300;


            dataGridTranspor.Columns["TipoModalidadeFrete"].HeaderText = "Tipo de Modalidade De Frete";
            dataGridTranspor.Columns["TipoModalidadeFrete"].Width = 300;

            dataGridTranspor.Columns["TipoVeiculo"].HeaderText = "Tipo de Veiculo";
            dataGridTranspor.Columns["TipoVeiculo"].Width = 300;



            dataGridTranspor.Columns["TipoTransportadora"].HeaderText = "Tipo de Transportadora";
            dataGridTranspor.Columns["TipoTransportadora"].Width = 300;



            dataGridTranspor.Columns["UfVeiculo"].HeaderText = "Uf do Veiculo";
            dataGridTranspor.Columns["UfVeiculo"].Width = 300;


            dataGridTranspor.Columns["PlacaVeiculo"].HeaderText = "Placa do Veiculo";
            dataGridTranspor.Columns["PlacaVeiculo"].Width = 300;


            dataGridTranspor.Columns["CpfMotorista"].HeaderText = "Cpf do Motorista";
            dataGridTranspor.Columns["CpfMotorista"].Width = 300;

            dataGridTranspor.Columns["Observacao"].HeaderText = "Observação";
            dataGridTranspor.Columns["Observacao"].Width = 300;



            dataGridTranspor.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
            dataGridTranspor.Columns["DataCadastro"].Width = 200;


            dataGridTranspor.Columns["DataUltimaAtualizacao"].HeaderText = "Data de Ultima Atualização";
            dataGridTranspor.Columns["DataUltimaAtualizacao"].Width = 200;

            dataGridTranspor.Columns["Segmento"].HeaderText = "Atividade Economica";
            dataGridTranspor.Columns["Segmento"].Width = 300;

            dataGridTranspor.Columns["Email"].HeaderText = "Email Comercial";
            dataGridTranspor.Columns["Email"].Width = 350;

            dataGridTranspor.GridColor = Color.FromArgb(220, 220, 220);
            dataGridTranspor.BorderStyle = BorderStyle.FixedSingle;
            dataGridTranspor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridTranspor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

        }

        private void textDadoPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtroSelecionado = comboFiltros.SelectedItem.ToString();
            var modeloSelecionado = comboModelo.SelectedItem.ToString();
            var termoPesquisa = textDadoPesquisa.Text.Trim().ToLower();

            try
            {
                IQueryable<ServiTech.Model.ModelTransportadora.Transportadora> query = dbConectionPdv.Transportadoras;

                if (string.IsNullOrEmpty(termoPesquisa))
                {
                    this.CarregarTransportadoras();
                    return;
                }


                if (filtroSelecionado == "Por Nome Fantasia ")
                {
                    if (modeloSelecionado == "Inicia Com")
                        query = query.Where(t => t.NomeFantasia.ToLower().StartsWith(termoPesquisa));
                    else if (modeloSelecionado == "Termina Com")
                        query = query.Where(t => t.NomeFantasia.ToLower().EndsWith(termoPesquisa));
                    else if (modeloSelecionado == "Contem")
                        query = query.Where(t => t.NomeFantasia.ToLower().Contains(termoPesquisa));
                }
                else if (filtroSelecionado == "Por Codigo ")
                {
                    if (int.TryParse(termoPesquisa, out int codigo))
                        query = query.Where(t => t.Id == codigo);
                    else
                        query = query.Where(t => false); // não retorna nada se não for número
                }

                else if (filtroSelecionado == "Por Cpf ou Cnpj ")
                {
                    if (modeloSelecionado == "Inicia Com")
                        query = query.Where(t => t.CnpjCpf.ToLower().StartsWith(termoPesquisa));
                    else if (modeloSelecionado == "Termina Com")
                        query = query.Where(t => t.CnpjCpf.ToLower().EndsWith(termoPesquisa));
                    else if (modeloSelecionado == "Contem")
                        query = query.Where(t => t.CnpjCpf.ToLower().Contains(termoPesquisa));
                }

                else if (filtroSelecionado == "Por Razão Social ")
                {
                    if (modeloSelecionado == "Inicia Com")
                        query = query.Where(f => f.RazaoSocial.ToLower().StartsWith(termoPesquisa));
                    else if (modeloSelecionado == "Termina Com")
                        query = query.Where(f => f.RazaoSocial.ToLower().EndsWith(termoPesquisa));
                    else if (modeloSelecionado == "Contem")
                        query = query.Where(f => f.RazaoSocial.ToLower().Contains(termoPesquisa));

                }

                var resultado = query.ToList();
                if (resultado.Count == 0)
                {
                    this.labelTotalRegistro.Text = $"Nenhum resultado: 0";
                }
                else
                {
                    this.labelTotalRegistro.Text = $"Total de Registros: {resultado.Count}";
                }
                dataGridTranspor.DataSource = resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na sua busca: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridTranspor.SelectedRows.Count > 0)
                {
                    int transportadoraId = (int)dataGridTranspor.SelectedRows[0].Cells[0].Value;

                    Transportadora transportadoraParaEdicao = dbConectionPdv.Transportadoras.Find(transportadoraId);
                    this.AbrirAbaCadastro(transportadoraParaEdicao);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na sua ao selecionar o valor :" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AbrirAbaCadastro(Transportadora transportadora)
        {
            tabControl1.SelectedTab = tabCadastro;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }

            if (transportadora.CnpjCpf != null && transportadora.CnpjCpf.Length == 11)
            {
                radioButtonPessoaFisica.Checked = true;

                textTipoPessoa.Text = "Fisica";

            }
            else if (transportadora.CnpjCpf != null && transportadora.CnpjCpf.Length == 14)
            {
                radioButtonPessaoJuridica.Checked = true;
                textTipoPessoa.Text = "Juridica";


            }

            textCod.Text = transportadora.Id.ToString();
            textCpfCnpj.Text = transportadora.CnpjCpf;
            textNomeFantasia.Text = transportadora.NomeFantasia;
            textRazaoSocial.Text = transportadora.RazaoSocial;
            textCpfMotorista.Text = transportadora.CpfMotorista;
            textEmail.Text = transportadora.Email;
            textInscriEstadual.Text = transportadora.InscricaoEstadual;
            textInscriMunicipal.Text = transportadora.InscricaoMunicipal;
            textTipoPessoa.Text = transportadora.TipoPessoa;
            textEndereco.Text = transportadora.Endereco;
            comboBairros.Text = transportadora.Bairro.ToString();
            comboBoxUf.Text = transportadora.Uf.ToString();
            comboCidades.Text = transportadora.Cidade.ToString();
            comboPaises.Text = transportadora.Pais.ToString();
            comboTipoInscricao.Text = transportadora.TipoInscricao;
            textRntrc.Text = transportadora.RNTRC.ToString();
            comboTipoTransportadora.Text = transportadora.TipoTransportadora;
            comboTipoVeiculo.Text = transportadora.TipoVeiculo;
            comboUfsVeiculo.Text = transportadora.UfVeiculo;
            comboBoxAtividade.Text = transportadora.Segmento;
            checkAtivo.Checked = transportadora.Ativo;
            comboModalidadeFrete.Text = transportadora.TipoModalidadeFrete;
            textPlacaVeiculo.Text = transportadora.PlacaVeiculo;
            textTelefoneFixo.Text = transportadora.TelefoneFixo;
            textWhatsApp.Text = transportadora.WhatsApp;
            textNomeMotorista.Text = transportadora.Motorista;
            textObservacao.Text = transportadora.Observacao;
            textDataCadastro.Text = transportadora.DataCadastro.ToString("dd/MM/yyyy");
            textUltimaAtualizacao.Text = transportadora.DataUltimaAtualizacao.ToString("dd/MM/yyyy");
        }

        private void comboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboPaises.SelectedItem is ServiTech.Model.ModelLocalidade.Pais paisSelecionado)
            {
                var cidades = dbConectionPdv.Cidades
                    .Where(c => c.PaisId == paisSelecionado.Id)
                    .OrderBy(c => c.Nome)
                    .ToList();
                comboCidades.DataSource = cidades;
                comboCidades.DisplayMember = "Nome";
                comboCidades.ValueMember = "Id";
                if (cidades.Count > 0)
                {
                    comboCidades.SelectedIndex = 0; // Seleciona a primeira cidade por padrão
                }
                else
                {
                    comboCidades.SelectedIndex = -1; // Nenhuma cidade disponível
                }
            }
        }


        private void comboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboCidades.SelectedItem is ServiTech.Model.ModelLocalidade.Cidade cidadeSelecionada)
            {
                var bairros = dbConectionPdv.Bairro
                    .Where(b => b.CidadeId == cidadeSelecionada.Id)
                    .OrderBy(b => b.Nome)
                    .ToList();
                comboBairros.DataSource = bairros;
                comboBairros.DisplayMember = "Nome";
                comboBairros.ValueMember = "Id";
                if (bairros.Count > 0)
                {
                    comboBairros.SelectedIndex = 0; // Seleciona o primeiro bairro por padrão
                }
                else
                {
                    comboBairros.SelectedIndex = -1; // Nenhum bairro disponível
                }

            }
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridTranspor.Rows.Count > 0)
            {
                var linhaSeleciionada = dataGridTranspor.SelectedRows[0];
                int transportadoraId = int.Parse(linhaSeleciionada.Cells["Id"].Value.ToString());
                Transportadora transportadora = dbConectionPdv.Transportadoras.FirstOrDefault(t => t.Id == transportadoraId);
                if (transportadora != null)
                {
                    var confirmResult = MessageBox.Show("Tem certeza que deseja excluir  Transportadora selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            dbConectionPdv.Transportadoras.Remove(transportadora);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Transportadora excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarTransportadoras();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir Transportadora: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Transportadora não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma Transportadora selecionado para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            this.GravarTransportadora();
        }

        private void GravarTransportadora()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textNomeFantasia.Text)
                  || string.IsNullOrWhiteSpace(textRazaoSocial.Text)
                  || string.IsNullOrWhiteSpace(textCpfCnpj.Text)
                  || string.IsNullOrWhiteSpace(textInscriEstadual.Text)
                  || string.IsNullOrWhiteSpace(textInscriMunicipal.Text)
                  || string.IsNullOrWhiteSpace(textEndereco.Text)
                  || string.IsNullOrWhiteSpace(comboBairros.Text)
                  || string.IsNullOrWhiteSpace(comboBoxAtividade.Text)
                  || string.IsNullOrWhiteSpace(comboCidades.Text)
                  || string.IsNullOrWhiteSpace(comboBoxUf.Text)
                  || string.IsNullOrWhiteSpace(comboPaises.Text)
                  || string.IsNullOrWhiteSpace(comboTipoInscricao.Text)
                  || string.IsNullOrWhiteSpace(comboTipoTransportadora.Text)
                  || string.IsNullOrWhiteSpace(comboModelo.Text)
                  || string.IsNullOrWhiteSpace(comboUfsVeiculo.Text)
                  || string.IsNullOrWhiteSpace(textNomeMotorista.Text)
                  || string.IsNullOrWhiteSpace(textCpfMotorista.Text)
                  || string.IsNullOrWhiteSpace(textTelefoneFixo.Text)
                  || string.IsNullOrWhiteSpace(textEmail.Text)
                  || string.IsNullOrWhiteSpace(comboTipoVeiculo.Text)
                  || string.IsNullOrWhiteSpace(comboModalidadeFrete.Text)
                  || string.IsNullOrWhiteSpace(textRntrc.Text))

                {

                    MessageBox.Show("Atenção campos devem ser prechidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (string.IsNullOrWhiteSpace(textCod.Text))
                {
                    string cpfCnpjValor = textCpfCnpj.Text;
                    string cpfCnpjFormatado = new string(cpfCnpjValor.Where(char.IsDigit).ToArray());
                    // verifica se ja existe esse registros
                    bool jaExisteTransportadora = dbConectionPdv.Transportadoras.Any(t => t.CnpjCpf == cpfCnpjFormatado);
                    if (jaExisteTransportadora)
                    {
                        MessageBox.Show("Atenção essa transportadora ja existe na base de dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Transportadora transportadora = new Transportadora
                        {
                            NomeFantasia = textNomeFantasia.Text,
                            RazaoSocial = textRazaoSocial.Text,
                            Ativo = checkAtivo.Checked,
                            CpfMotorista = new string(textCpfMotorista.Text.Where(char.IsDigit).ToArray()),// 
                            CnpjCpf = cpfCnpjFormatado,
                            Bairro = comboBairros.Text,
                            Cidade = comboCidades.Text,
                            Pais = comboPaises.Text,
                            Uf = comboBoxUf.Text,
                            UfVeiculo = comboUfsVeiculo.Text,
                            Segmento = comboBoxAtividade.Text,
                            Email = textEmail.Text,
                            Endereco = textEndereco.Text,
                            InscricaoEstadual = textInscriEstadual.Text,
                            InscricaoMunicipal = textInscriMunicipal.Text,
                            RNTRC = textRntrc.Text,
                            PlacaVeiculo = textPlacaVeiculo.Text,
                            Observacao = textObservacao.Text,
                            TelefoneFixo = new string(textTelefoneFixo.Text.Where(char.IsDigit).ToArray()),
                            WhatsApp = new string(textWhatsApp.Text.Where(char.IsDigit).ToArray()),
                            TipoPessoa = textTipoPessoa.Text,
                            TipoModalidadeFrete = comboModalidadeFrete.Text,
                            TipoTransportadora = comboTipoInscricao.Text,
                            TipoVeiculo = comboTipoVeiculo.Text,
                            Motorista = textNomeMotorista.Text,
                            TipoInscricao = comboTipoInscricao.Text,
                            DataCadastro = DateTime.Now,


                        };
                        dbConectionPdv.Add(transportadora);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Transportadora cadastrado com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textCod.Text = transportadora.Id.ToString();
                        CarregarTransportadoras();
                        return;

                    }
                }
                else
                {
                    // e update
                    int trasnportadoraId = int.Parse(textCod.Text);
                    var transportadoraEdicao = dbConectionPdv.Transportadoras.Find(trasnportadoraId);

                    if (transportadoraEdicao != null)
                    {
                        Transportadora transportadoraUpdate = new Transportadora
                        {
                            NomeFantasia = textNomeFantasia.Text,
                            RazaoSocial = textRazaoSocial.Text,
                            Ativo = checkAtivo.Checked,
                            CpfMotorista = new string(textCpfMotorista.Text.Where(char.IsDigit).ToArray()),// 
                            CnpjCpf = new string(textCpfCnpj.Text.Where(char.IsDigit).ToArray()),// 
                            Bairro = comboBairros.Text,
                            Cidade = comboCidades.Text,
                            Pais = comboPaises.Text,
                            Uf = comboBoxUf.Text,
                            UfVeiculo = comboUfsVeiculo.Text,
                            Segmento = comboBoxAtividade.Text,
                            Email = textEmail.Text,
                            Endereco = textEndereco.Text,
                            InscricaoEstadual = textInscriEstadual.Text,
                            InscricaoMunicipal = textInscriMunicipal.Text,
                            RNTRC = textRntrc.Text,
                            PlacaVeiculo = textPlacaVeiculo.Text,
                            Observacao = textObservacao.Text,
                            TelefoneFixo = new string(textTelefoneFixo.Text.Where(char.IsDigit).ToArray()),
                            WhatsApp = new string(textWhatsApp.Text.Where(char.IsDigit).ToArray()),
                            TipoPessoa = textTipoPessoa.Text,
                            TipoModalidadeFrete = comboModalidadeFrete.Text,
                            TipoTransportadora = comboTipoInscricao.Text,
                            TipoVeiculo = comboTipoVeiculo.Text,
                            Motorista = textNomeMotorista.Text,
                            TipoInscricao = comboTipoInscricao.Text,
                            DataCadastro = DateTime.Parse(textDataCadastro.Text),
                            DataUltimaAtualizacao = DateTime.Now,
                            Id = transportadoraEdicao.Id,


                        };
                        dbConectionPdv.Entry(transportadoraEdicao).CurrentValues.SetValues(transportadoraUpdate);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Transportadora atualizado  com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CarregarTransportadoras();
                        return;

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um  erro no cadastro " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}

