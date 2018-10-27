using Frei.ProjetoIntegrador.Academia.DB.FluxoDeCaixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.FluxoDeCaixa
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            dtpDia.Value = DateTime.Now;
            CarregarFluxo(DateTime.Now.ToString());
        }

        private void CarregarFluxo(string data)
        {
            data = DateTime.Parse(data).ToString("yyyy-MM-dd");

            FluxoDeCaixaBusiness fluxo = new FluxoDeCaixaBusiness();
            FluxoDeCaixaDTO dto = fluxo.PuxarDados(data);

            lblVendas.Text = $"R$ {dto.vlVendas}";
            lblCompras.Text = $"R$ {dto.vlCompras}";
            lblFolha.Text = $"R$ {dto.vlFollha}";
            lblGerais.Text = $"R$ {dto.vlGerais}";

            lblSub.Text = $"R$ {dto.vlVendas - (dto.vlCompras + dto.vlFollha + dto.vlGerais)}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime data = dtpDia.Value;
            CarregarFluxo(data.ToString());
        }
    }
}
