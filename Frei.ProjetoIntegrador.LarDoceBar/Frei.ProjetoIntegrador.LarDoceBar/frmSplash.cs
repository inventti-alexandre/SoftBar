using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();

            // Inicia contagem para término da Splash Screen
            Task.Factory.StartNew(() =>
            {
                // Espera 2 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(6000);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    Hide();
                }));
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
