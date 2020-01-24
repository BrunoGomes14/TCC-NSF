using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas
{
    public partial class FrmConsultarFornecedor : Form
    {
        public FrmConsultarFornecedor()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nomeF = txtNome.Text;

            Business.FornecedorBusiness business = new Business.FornecedorBusiness();
            List<DataBase.Entity.tb_fornecedor> fornecedor = business.ConsultarPorNomeFornecedor(nomeF);

            foreach (DataBase.Entity.tb_fornecedor item in fornecedor)
            {
                

            }

           // foreach (Database.Entity.tb_ranking item in rankingList)
            //{
             //   frmRankingItem rank = new frmRankingItem(item, alternada, posicao, user);
             //   panelRanking.Controls.Add(rank);

          //  }



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario telas = new Menus.FrmMenuTemporario();
            telas.Show();
            Hide();
        }
    }
}
