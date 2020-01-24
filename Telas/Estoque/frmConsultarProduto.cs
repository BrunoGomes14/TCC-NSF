using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas.Estoque
{
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
            this.Carregar();
        }

        public void Carregar()
        {
            Business.ProdutoBusiness business = new Business.ProdutoBusiness();
            List<DataBase.Entity.tb_produto> produtos = business.ConsultarTodos();

            cboID.DisplayMember = nameof(DataBase.Entity.tb_produto.nm_produto);
            cboID.DataSource = produtos;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Lembrar de fazer outras formas de consultas
            // Exemplo: cor, marca, tipo
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeP = cboID.Text;

            Business.ProdutoBusiness business = new Business.ProdutoBusiness();
           // DataBase.Entity.tb_produto produtos = business.ConsultarPorNome(nomeP);

           //dgvProduto.DataSource = produtos;
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
