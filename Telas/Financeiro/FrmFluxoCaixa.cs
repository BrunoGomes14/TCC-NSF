using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas.Financeiro
{
    public partial class FrmFluxoCaixa : Form
    {
        public FrmFluxoCaixa()
        {
            InitializeComponent();

            DataBase.FluxoCaixa db = new DataBase.FluxoCaixa();
            List<DataBase.Entity.fluxo_otica> fluxo = db.FluxoTotal();

            dtpFluxo.DataSource = fluxo;

            cboOperacao.SelectedIndex = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario telas = new Menus.FrmMenuTemporario();
            telas.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.Entity.fluxo_otica vw = new DataBase.Entity.fluxo_otica();
                vw.tp_operacao = cboOperacao.Text;
                DateTime mes1 = dtpMes.Value;
                DateTime mes2 = dtpmes2.Value;

                Business.FluxoCaixaBusiness bu = new Business.FluxoCaixaBusiness();
                List<DataBase.Entity.fluxo_otica> list = bu.Fluxo(vw, mes1, mes2);

                dtpFluxo.DataSource = list;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            


        }
    }
}
