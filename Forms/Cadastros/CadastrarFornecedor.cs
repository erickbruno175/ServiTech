using Microsoft.EntityFrameworkCore;
using ServiTech.DbConection;
using ServiTech.Model;
using ServiTech.Model.ModelLocalidade;
using System.Data;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarFornecedor : Form
    {

        private readonly DbConectionPdv dbConection;
        public CadastrarFornecedor(DbConectionPdv dbConectionPdv)
        {
            InitializeComponent();
            dbConection = dbConectionPdv;
        }



        private void LiberarCamposParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    HabilitarControles(tab.Controls);
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.GravarFornecedor();
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
                        radioButtonPessaoJuridica.Checked = true;
                        textBox.ReadOnly = false;
                        break;

                    case ComboBox comboBox:
                        comboBox.Enabled = true;
                        comboBoxTipoConta.SelectedIndex = -1; // Nenhum item selecionado
                        comboTipoFornecedor.SelectedIndex = -1; // Nenhum item selecionado
                        comboTipoInscricao.SelectedIndex = -1; // Nenhum item selecionado
                        comboPaises.SelectedIndex = -1; // Nenhum país selecionado inicialmente
                        comboCidades.SelectedIndex = -1; // Nenhum item selecionado
                        comboBairros.SelectedIndex = -1; // Nenhum item selecionado
                        comboBoxNomeBanco.SelectedIndex = -1; // Nenhum item selecionado
                        comboBoxUf.SelectedIndex = -1; // Nenhum item selecionado
                        comboBoxTipoConta.SelectedIndex = -1; // Nenhum item selecionado

                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.ReadOnly = false;
                        maskedTextBox.Clear();

                        textDataCadastro.ReadOnly = true;
                        textUltimaAtualizacao.ReadOnly = true;
                        break;

                    case CheckBox checkBox:
                        checkBox.Enabled = true;
                        break;

                    case Button button:
                        button.Enabled = true;
                        break;


                    case RadioButton radioButton:
                        radioButton.Enabled = true;
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


            foreach (TabPage tab in tabControl.TabPages)
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

            this.CarregarPaisesCombo();
            this.CarregarGridFornecedores();
            this.CarregarAtividadesCombo();
            this.CarregarCargosCombo();
        }


        private void CarregarCargosCombo()
        {
            var cargos = dbConection.Cargos.OrderBy(c => c.Nome).ToList();
            comboBoxCargoContato.DataSource = cargos;
            comboBoxCargoContato.DisplayMember = "Nome";
            comboBoxCargoContato.ValueMember = "Id";
        }
        private void CarregarAtividadesCombo()
        {
            var atividades = dbConection.AtividadeEconomicas.OrderBy(ae => ae.Nome).ToList();
            comboBoxAtividade.DataSource = atividades;
            comboBoxAtividade.DisplayMember = "Nome";
            comboBoxAtividade.ValueMember = "Id";
        }

        private void LiberarCampos_Click(object sender, EventArgs e)
        {

            foreach (TabPage tab in tabControl.TabPages)
            {
                HabilitarControles(tab.Controls);
            }
        }

        private void CarregarPaisesCombo()
        {
            var paises = dbConection.Paises.OrderBy(p => p.Nome).ToList();
            comboPaises.DataSource = paises;
            comboPaises.DisplayMember = "Nome";
            comboPaises.ValueMember = "Id";
            comboPaises.SelectedIndex = 5; // Nenhum país selecionado inicialmente


        }

        private void CarregarGridFornecedores()
        {

            var fornecedores = dbConection.Fornecedores.Select(f => new
            {
                f.Id,
                f.Nomefantasia,
                f.CnpjCpf,
                f.InscricaoEstadual,
                f.InscricaoMunicipal,
                f.Telefone,
                f.TelefoneContato,
                f.TipoConta,
                f.DataCadastro,
                f.DataAtualizacao,
                f.ChavePix,
                f.Observacoes,
                f.EmailContato,
                f.NomeContato,
                f.RazaoSocial,
                f.CargoContato,
                f.RamoAtividade,
                f.TipoInscricao,
                f.TipoFornecedor,
                f.Email,
                f.Endereco,
                f.Cidade,
                f.Banco,
                f.Ativo,
                f.TipoPessoa,
                f.Agencia,
                f.Conta,
                f.Uf,
                f.Pais,

            }).ToList();


            labelTotalRegistro.Text = "Total Registros : " + fornecedores.Count;
            gridFornecedores.DataSource = fornecedores;

            // ==== ESTILO DO CABEÇALHO ====
            gridFornecedores.EnableHeadersVisualStyles = false;
            gridFornecedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
            gridFornecedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridFornecedores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold); // Fonte menor
            gridFornecedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridFornecedores.ColumnHeadersHeight = 32; // Altura levemente menor

            // ==== ESTILO DAS LINHAS ====
            gridFornecedores.DefaultCellStyle.BackColor = Color.White;
            gridFornecedores.DefaultCellStyle.ForeColor = Color.Black;
            gridFornecedores.DefaultCellStyle.Font = new Font("Segoe UI", 8F); // Fonte menor
            gridFornecedores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
            gridFornecedores.DefaultCellStyle.SelectionForeColor = Color.White;
            gridFornecedores.RowHeadersVisible = false;
            gridFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            gridFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // ==== CONFIGURAÇÃO DAS COLUNAS ====
            gridFornecedores.Columns["Id"].HeaderText = "Código";
            gridFornecedores.Columns["Id"].Width = 70;

            gridFornecedores.Columns["NomeFantasia"].HeaderText = "Nome Fantasia";
            gridFornecedores.Columns["NomeFantasia"].Width = 350;

            gridFornecedores.Columns["CnpjCpf"].HeaderText = "CNPJ / CPF";
            gridFornecedores.Columns["CnpjCpf"].Width = 180;

            gridFornecedores.Columns["InscricaoEstadual"].HeaderText = "Inscrição Estadual";
            gridFornecedores.Columns["InscricaoEstadual"].Width = 180;

            gridFornecedores.Columns["InscricaoMunicipal"].HeaderText = "Inscrição Municipal";
            gridFornecedores.Columns["InscricaoMunicipal"].Width = 180;

            gridFornecedores.Columns["Telefone"].HeaderText = "Telefone";
            gridFornecedores.Columns["Telefone"].Width = 170;


            gridFornecedores.Columns["TelefoneContato"].HeaderText = "Telefone do Contato";
            gridFornecedores.Columns["TelefoneContato"].Width = 170;

            gridFornecedores.Columns["TipoConta"].HeaderText = "Tipo de Conta";
            gridFornecedores.Columns["TipoConta"].Width = 170;


            gridFornecedores.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
            gridFornecedores.Columns["DataCadastro"].Width = 170;

            gridFornecedores.Columns["DataAtualizacao"].HeaderText = "Data de Atualização";
            gridFornecedores.Columns["DataAtualizacao"].Width = 170;


            gridFornecedores.Columns["ChavePix"].HeaderText = "Chave Pix";
            gridFornecedores.Columns["ChavePix"].Width = 250;


            gridFornecedores.Columns["Observacoes"].HeaderText = "Observações";
            gridFornecedores.Columns["Observacoes"].Width = 300;

            gridFornecedores.Columns["EmailContato"].HeaderText = "Email Contato";
            gridFornecedores.Columns["EmailContato"].Width = 350;

            gridFornecedores.Columns["NomeContato"].HeaderText = "Nome Contato";
            gridFornecedores.Columns["NomeContato"].Width = 350;

            gridFornecedores.Columns["RazaoSocial"].HeaderText = "Razão Social";
            gridFornecedores.Columns["RazaoSocial"].Width = 350;

            gridFornecedores.Columns["CargoContato"].HeaderText = "Cargo do Contato";
            gridFornecedores.Columns["CargoContato"].Width = 180;

            gridFornecedores.Columns["RamoAtividade"].HeaderText = "Ramo de Atividade";
            gridFornecedores.Columns["RamoAtividade"].Width = 180;

            gridFornecedores.Columns["TipoInscricao"].HeaderText = "Tipo de Inscrição";
            gridFornecedores.Columns["TipoInscricao"].Width = 180;

            gridFornecedores.Columns["TipoFornecedor"].HeaderText = "Tipo de Fornecedor";
            gridFornecedores.Columns["TipoFornecedor"].Width = 180;

            gridFornecedores.Columns["Email"].HeaderText = "Email do Comercial";
            gridFornecedores.Columns["Email"].Width = 300;

            gridFornecedores.Columns["Endereco"].HeaderText = "Endereço";
            gridFornecedores.Columns["Endereco"].Width = 350;

            gridFornecedores.Columns["Cidade"].HeaderText = "Cidade";
            gridFornecedores.Columns["Cidade"].Width = 250;


            gridFornecedores.Columns["TipoPessoa"].HeaderText = "Tipo de Pessoa";
            gridFornecedores.Columns["TipoPessoa"].Width = 150;


            gridFornecedores.Columns["RamoAtividade"].HeaderText = "Atividade Economica";
            gridFornecedores.Columns["RamoAtividade"].Width = 300;


            gridFornecedores.Columns["Banco"].Width = 250;


            // ==== AJUSTE VISUAL FINAL ====
            gridFornecedores.GridColor = Color.FromArgb(220, 220, 220);
            gridFornecedores.BorderStyle = BorderStyle.FixedSingle;
            gridFornecedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridFornecedores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.labelTotalRegitros.Text = $"Total de Registros: {gridFornecedores.Rows.Count}";

        }



        private void textDadoPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtroSelecionado = comboFiltros.SelectedItem?.ToString();
            var modeloSelecionado = comboModelo.SelectedItem?.ToString();
            var termoPesquisa = textDadoPesquisa.Text.Trim().ToLower();
            try
            {

                IQueryable<ServiTech.Model.Fornecedor> query = dbConection.Fornecedores;

                if (string.IsNullOrEmpty(termoPesquisa))
                {
                    this.CarregarGridFornecedores();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(filtroSelecionado))
                {
                    if (filtroSelecionado == "Por Nome Fantasia ")
                    {
                        if (modeloSelecionado == "Inicia Com")
                            query = query.Where(f => f.Nomefantasia.ToLower().StartsWith(termoPesquisa));
                        else if (modeloSelecionado == "Termina Com")
                            query = query.Where(f => f.Nomefantasia.ToLower().EndsWith(termoPesquisa));
                        else if (modeloSelecionado == "Contem")
                            query = query.Where(f => f.Nomefantasia.ToLower().Contains(termoPesquisa));

                    }
                    else if (filtroSelecionado == "Por Codigo ")
                    {
                        if (int.TryParse(termoPesquisa, out int codigo))
                            query = query.Where(f => f.Id == codigo);
                        else
                            query = query.Where(f => false); // não retorna nada se não for número
                    }

                    else if (filtroSelecionado == "Por Cpf ou Cnpj ")
                    {
                        if (modeloSelecionado == "Inicia Com")
                            query = query.Where(f => f.CnpjCpf.ToLower().StartsWith(termoPesquisa));
                        else if (modeloSelecionado == "Termina Com")
                            query = query.Where(f => f.CnpjCpf.ToLower().EndsWith(termoPesquisa));
                        else if (modeloSelecionado == "Contem")
                            query = query.Where(f => f.CnpjCpf.ToLower().Contains(termoPesquisa));

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

                    var resultado = query.Select(f => new
                    {
                        f.Id,
                        f.Nomefantasia,
                        f.CnpjCpf,
                        f.InscricaoEstadual,
                        f.InscricaoMunicipal,
                        f.Telefone,
                        f.TelefoneContato,
                        f.TipoConta,
                        f.DataCadastro,
                        f.DataAtualizacao,
                        f.ChavePix,
                        f.Observacoes,
                        f.EmailContato,
                        f.NomeContato,
                        f.RazaoSocial,
                        f.CargoContato,
                        f.RamoAtividade,
                        f.TipoInscricao,
                        f.TipoFornecedor,
                        f.Email,
                        f.Endereco,
                        f.Cidade,
                        f.Banco,
                        f.Ativo,
                        f.TipoPessoa,
                        f.Agencia,
                        f.Conta,
                        f.Uf,
                        f.Pais,

                    }).ToList();
                    if (resultado.Count == 0)
                    {
                        this.labelTotalRegistro.Text = $"Nenhum resultado: 0";
                    }
                    else
                    {
                        this.labelTotalRegistro.Text = $"Total de Registros: {resultado.Count}";
                    }
                    gridFornecedores.DataSource = resultado;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na sua busca: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (gridFornecedores.Rows.Count > 0)
            {
                var linhaSeleciionada = gridFornecedores.SelectedRows[0];
                int fornecedorId = int.Parse(linhaSeleciionada.Cells["Id"].Value.ToString());

                Fornecedor fornecedor = dbConection.Fornecedores.FirstOrDefault(f => f.Id == fornecedorId);

                if (fornecedor != null)
                {
                    this.AbaCadastroFornecedor(fornecedor);
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum fornecedor selecionado para edição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void AbaCadastroFornecedor(Fornecedor fornecedor)
        {
            tabControl.SelectedTab = tabCadastro;
            LiberarCamposParaCadastro_KeyDown(this, new KeyEventArgs(Keys.F4));
            textCod.Text = fornecedor.Id.ToString();
            textRazaoSocial.Text = fornecedor.RazaoSocial;
            textNomeFantasia.Text = fornecedor.Nomefantasia;

            if (fornecedor.CnpjCpf != null && fornecedor.CnpjCpf.Length == 11)
            {
                radioButtonPessoaFisica.Checked = true;
                textTipoPessoa.Text = "Fisica";


            }
            else if (fornecedor.CnpjCpf != null && fornecedor.CnpjCpf.Length == 14)
            {
                radioButtonPessaoJuridica.Checked = true;
                textTipoPessoa.Text = "Juridica";



            }
            textCpfCnpj.Text = fornecedor.CnpjCpf;
            textInscriEstadual.Text = fornecedor.InscricaoEstadual;
            textInscriMunicipal.Text = fornecedor.InscricaoMunicipal;
            textNomeContato.Text = fornecedor.NomeContato;
            textTelContato.Text = fornecedor.TelefoneContato;
            textEmailContato.Text = fornecedor.EmailContato;
            comboBoxCargoContato.Text = fornecedor.CargoContato;
            comboBoxAtividade.Text = fornecedor.RamoAtividade;
            comboTipoInscricao.Text = fornecedor.TipoInscricao;
            comboTipoFornecedor.Text = fornecedor.TipoFornecedor;
            textTelefoneFixo.Text = fornecedor.Telefone;
            checkedAtivo.Checked = (bool)fornecedor.Ativo;
            textEmail.Text = fornecedor.Email;
            textEndeco.Text = fornecedor.Endereco;
            textCelContato.Text = fornecedor.TelefoneContato;
            textUltimaAtualizacao.Text = fornecedor.DataAtualizacao?.ToString("dd/MM/yyyy") ?? "";
            textDataCadastro.Text = fornecedor.DataCadastro?.ToString("dd/MM/yyyy") ?? "";


            textObservacao.Text = fornecedor.Observacoes;
            comboPaises.Text = fornecedor.Pais;
            comboCidades.Text = fornecedor.Cidade;
            comboBairros.Text = fornecedor.Bairro;
            comboBoxNomeBanco.Text = fornecedor.Banco;
            textCodAgencia.Text = fornecedor.Agencia;
            comboBoxTipoConta.Text = fornecedor.TipoConta;
            comboBoxUf.Text = fornecedor.Uf;
            textWhatsApp.Text = fornecedor.Whatsapp;
            textCodBanco.Text = fornecedor.CodigoBanco;
            textChavePix.Text = fornecedor.ChavePix;
            textConta.Text = fornecedor.Conta;
            textWhatsAppContato.Text = fornecedor.WhatsappContato;

        }

        private void comboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboPaises.SelectedItem is ServiTech.Model.ModelLocalidade.Pais paisSelecionado)
            {
                var cidades = dbConection.Cidades
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
                var bairros = dbConection.Bairro
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

        private void GravarFornecedor()
        {
            try
            {
                // Limpa CPF/CNPJ para salvar só os números
                string cpfCnpjValor = textCpfCnpj.Text;
                string cpfCnpjFormatado = new string(cpfCnpjValor.Where(char.IsDigit).ToArray());

                // Valida campos obrigatórios
                if (string.IsNullOrWhiteSpace(textNomeFantasia.Text) ||
                    string.IsNullOrWhiteSpace(textRazaoSocial.Text) ||
                    string.IsNullOrWhiteSpace(textCpfCnpj.Text)
                    || string.IsNullOrWhiteSpace(textInscriEstadual.Text)
                    || string.IsNullOrWhiteSpace(textInscriMunicipal.Text)
                    || string.IsNullOrWhiteSpace(comboTipoInscricao.Text)
                    || string.IsNullOrWhiteSpace(comboTipoFornecedor.Text))
                {
                    MessageBox.Show("Campos  são obrigatórios.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNomeFantasia.Focus();
                    return;
                }



                // Se for novo fornecedor
                if (string.IsNullOrWhiteSpace(textCod.Text))
                {
                    // Verifica duplicidade
                    if (dbConection.Fornecedores.Any(f => f.CnpjCpf == cpfCnpjFormatado))
                    {
                        MessageBox.Show("Já existe um fornecedor cadastrado com este CNPJ/CPF.", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textCpfCnpj.Focus();
                        return;
                    }

                    // Cria e preenche o fornecedor


                    Fornecedor novoFornecedor = new Fornecedor
                    {
                        Nomefantasia = textNomeFantasia.Text.Trim(),
                        RazaoSocial = textRazaoSocial.Text.Trim(),
                        InscricaoEstadual = textInscriEstadual.Text.Trim(),
                        InscricaoMunicipal = textInscriMunicipal.Text.Trim(),
                        NomeContato = textNomeContato.Text.Trim(),
                        EmailContato = textEmailContato.Text.Trim(),
                        CargoContato = comboBoxCargoContato.Text.Trim(),
                        RamoAtividade = comboBoxAtividade.Text.Trim(),
                        TipoInscricao = comboTipoInscricao.Text,
                        TipoFornecedor = comboTipoFornecedor.Text,
                        CnpjCpf = cpfCnpjFormatado,
                        Email = textEmail.Text.Trim(),
                        Endereco = textEndeco.Text.Trim(),
                        Uf = comboBoxUf.Text,
                        Banco = comboBoxNomeBanco.Text,
                        Agencia = textCodAgencia.Text.Trim(),
                        TipoConta = comboBoxTipoConta.Text,
                        CodigoBanco = textCodBanco.Text.Trim(),
                        ChavePix = textChavePix.Text.Trim(),
                        Observacoes = textObservacao.Text.Trim(),
                        Telefone = new string(textTelefoneFixo.Text.Where(char.IsDigit).ToArray()),
                        TelefoneContato = new string(textTelContato.Text.Where(char.IsDigit).ToArray()),
                        Whatsapp = new string(textWhatsApp.Text.Where(char.IsDigit).ToArray()),
                        WhatsappContato = new string(textWhatsAppContato.Text.Where(char.IsDigit).ToArray()),
                        DataCadastro = DateTime.Now,
                        DataAtualizacao = DateTime.Now,
                        Conta = textConta.Text.Trim(),
                        Ativo = checkedAtivo.Checked,
                        Pais = comboPaises.Text,
                        Cidade = comboCidades.Text,
                        Bairro = comboBairros.Text,
                        TipoPessoa = textTipoPessoa.Text



                    };

                    dbConection.Fornecedores.Add(novoFornecedor);
                    dbConection.SaveChanges();

                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textCod.Text = novoFornecedor.Id.ToString();

                    CarregarGridFornecedores();
                    return;
                }
                else // Atualiza fornecedor existente
                {
                    int fornecedorId = int.Parse(textCod.Text);
                    var fornecedor = dbConection.Fornecedores.Find(fornecedorId);

                    if (fornecedor != null)
                    {
                        fornecedor.Nomefantasia = textNomeFantasia.Text.Trim();
                        fornecedor.RazaoSocial = textRazaoSocial.Text.Trim();
                        fornecedor.InscricaoEstadual = textInscriEstadual.Text.Trim();
                        fornecedor.InscricaoMunicipal = textInscriMunicipal.Text.Trim();
                        fornecedor.NomeContato = textNomeContato.Text.Trim();
                        fornecedor.EmailContato = textEmailContato.Text.Trim();
                        fornecedor.CargoContato = comboBoxCargoContato.Text.Trim();
                        fornecedor.RamoAtividade = comboBoxAtividade.Text.Trim();
                        fornecedor.TipoInscricao = comboTipoInscricao.Text;
                        fornecedor.TipoFornecedor = comboTipoFornecedor.Text;
                        fornecedor.CnpjCpf = cpfCnpjFormatado;
                        fornecedor.Email = textEmail.Text.Trim();
                        fornecedor.Endereco = textEndeco.Text.Trim();
                        fornecedor.Uf = comboBoxUf.Text;
                        fornecedor.Banco = comboBoxNomeBanco.Text;
                        fornecedor.Agencia = textCodAgencia.Text.Trim();
                        fornecedor.TipoConta = comboBoxTipoConta.Text;
                        fornecedor.CodigoBanco = textCodBanco.Text.Trim();
                        fornecedor.ChavePix = textChavePix.Text.Trim();
                        fornecedor.Observacoes = textObservacao.Text.Trim();
                        fornecedor.Telefone = new string(textTelefoneFixo.Text.Where(char.IsDigit).ToArray());
                        fornecedor.TelefoneContato = new string(textTelContato.Text.Where(char.IsDigit).ToArray());
                        fornecedor.Whatsapp = new string(textWhatsApp.Text.Where(char.IsDigit).ToArray());
                        fornecedor.WhatsappContato = new string(textWhatsAppContato.Text.Where(char.IsDigit).ToArray());
                        fornecedor.DataAtualizacao = DateTime.Now;
                        fornecedor.DataCadastro = DateTime.Parse(textDataCadastro.Text);
                        fornecedor.Conta = textConta.Text.Trim();
                        fornecedor.Ativo = checkedAtivo.Checked;
                        fornecedor.Pais = comboPaises.Text;
                        fornecedor.Cidade = comboCidades.Text;
                        fornecedor.Bairro = comboBairros.Text;
                        fornecedor.TipoPessoa = textTipoPessoa.Text.Trim();

                        dbConection.SaveChanges();

                        MessageBox.Show("Fornecedor atualizado com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregarGridFornecedores();
                        return;
                    }

                   
                }

                // Atualiza o grid

                this.CarregarGridFornecedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar fornecedor: " + ex.InnerException?.Message ?? ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarFornecedor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            if (gridFornecedores.Rows.Count > 0)
            {
                var linhaSeleciionada = gridFornecedores.SelectedRows[0];
                int fornecedorId = int.Parse(linhaSeleciionada.Cells["Id"].Value.ToString());
                Fornecedor fornecedor = dbConection.Fornecedores.FirstOrDefault(f => f.Id == fornecedorId);
                if (fornecedor != null)
                {
                    var confirmResult = MessageBox.Show("Tem certeza que deseja excluir o fornecedor selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            dbConection.Fornecedores.Remove(fornecedor);
                            dbConection.SaveChanges();
                            MessageBox.Show("Fornecedor excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarGridFornecedores();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum fornecedor selecionado para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }



        private void bntNovo_Click(object sender, EventArgs e)
        {

            tabControl.SelectedTab = tabCadastro;
            LiberarCamposParaCadastro_Click(this, EventArgs.Empty);

        }
    }
}


