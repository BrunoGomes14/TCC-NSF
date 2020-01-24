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
    public partial class frmInserirProduto : Form
    {
        public frmInserirProduto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.Entity.tb_produto produto = new DataBase.Entity.tb_produto();

                produto.cd_barras = Convert.ToInt32(txtCodigoBarras.Text);
                produto.id_fornecedor = Convert.ToInt32(nudID.Value);
                produto.nm_cor = txtCor.Text;
                produto.nm_marca = txtMarca.Text;
                produto.nm_modelo = txtModelo.Text;
                produto.nm_produto = txtNome.Text;
                produto.pr_preco_lote = Convert.ToDecimal(txtLote.Text);
                produto.pr_preco_unidade = Convert.ToDecimal(txtUnitario.Text);
                produto.qtd_venda = Convert.ToInt32(nudQTD.Value);
                produto.tp_produto = txtTipo.Text;
            
                Business.ProdutoBusiness business = new Business.ProdutoBusiness();
                business.Inserir(produto);
            
                MessageBox.Show("Inserido Com Sucesso");
            }
            catch (Exception ex)
            {
            
                MessageBox.Show(ex.Message);
            }
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

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
