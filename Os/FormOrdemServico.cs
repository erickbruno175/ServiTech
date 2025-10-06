using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Os
{
    public partial class FormOrdemServico : Form
    {

        private readonly System.Windows.Forms.Timer timer;

        public FormOrdemServico()
        {
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 100;
            this.timer.Tick += Time_Tick;
            this.timer.Start();
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void textPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void Time_Tick(object sender, EventArgs e)
        {
            textDataAtual.Text = DateTime.Now.ToString("dd/MM/yyyy ");
            textDataPrevista.Text = DateTime.Now.ToString("dd/MM/yyyy ");
            textTempoGasto.Text = DateTime.Now.ToString("HH:mm:ss");
            labelDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            textDataEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy ");
            textDataGarantia.Text = DateTime.Now.ToString("dd/MM/yyyy ");

        }

        private void FormOrdemServico_Load(object sender, EventArgs e)
        {
            comboPrioridade.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;

        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
