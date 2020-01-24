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
    public partial class FrmInserirVenda : Form
    {
        public FrmInserirVenda()
        {
            InitializeComponent();
        }

        decimal tot = 0;

        decimal total = 0;

        public void ConsultaProduto()
        {
            dgvProd.AutoGenerateColumns = false;

            Business.VendaBusiness bu = new Business.VendaBusiness();

            int cod = Convert.ToInt32(txtCodigo.Text);

            DataBase.Entity.tb_produto pro = new DataBase.Entity.tb_produto();
            pro.cd_barras = cod;

            

            if (dgvProd.DataSource == null)
            {
                List<DataBase.Entity.tb_produto> prod = bu.ConsultarParaVenda(pro);

                dgvProd.DataSource = prod;
                
                foreach (DataBase.Entity.tb_produto c in prod)
                {
                    c.qtd_venda = Convert.ToInt32(nudqtd.Value);
                   tot = Convert.ToDecimal(c.pr_preco_unidade * c.qtd_venda);

                    total = tot;
                }

                lblvalordavenda.Text = Convert.ToString(total);
                nudqtd.Focus();
            }
            else
            {
                List<DataBase.Entity.tb_produto> produtinhos = dgvProd.DataSource as List<DataBase.Entity.tb_produto>;

                List<DataBase.Entity.tb_produto> result = bu.ConsultarParaVenda(pro);

                DataBase.Entity.tb_produto verif = bu.ConsultaCodBarras(pro);
                
                
                result.AddRange(produtinhos);
                
                foreach (DataBase.Entity.tb_produto c in result)
                {
                    if(c.cd_barras == verif.cd_barras )
                    {
                        c.qtd_venda = Convert.ToInt32(nudqtd.Value);
                    }

                    tot = tot + Convert.ToDecimal(c.pr_preco_unidade * c.qtd_venda) ;

                    total = tot;

                 lblvalordavenda.Text = Convert.ToString(tot);
                }

                dgvProd.DataSource = result;
                txtCodigo.Text = null;
                nudqtd.Focus();

             

            }
         

        }
        public void Troco()
        {
            decimal recebido = nudrecb.Value;

            decimal troco = Math.Round(recebido - total, 2);

            if (troco < 0)
            {
                throw new ArgumentException("Valor insuficiente");
            }

            lbltroco.Text = Convert.ToString(troco);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.SalvarVendaBanco();
                this.LimparCampos();


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void LimparCampos()
        {
            DataBase.ProdutoDatabase db = new DataBase.ProdutoDatabase();
            DataBase.Entity.tb_produto ss = db.ConsultarPorModelo("bruno");
            dgvProd.DataSource = ss;
            lblvalordavenda.Text = "0,00";
            lbltroco.Text = "0,00";
            txtCodigo.Text = null;
            nudrecb.Value = 0;
            nudqtd.Value = 1;

            nudqtd.Focus();
        }

        public void SalvarVendaBanco()
        {
            DataBase.Entity.tb_venda_registro venda = new DataBase.Entity.tb_venda_registro();

            venda.vl_venda = Convert.ToDecimal(lblvalordavenda.Text);
            venda.dt_venda = DateTime.Now.Date;

            Business.VendaBusiness bu = new Business.VendaBusiness();
            
            int id = venda.id_venda;

            DataBase.Entity.tb_desc_venda desc = new DataBase.Entity.tb_desc_venda();

            DataBase.Entity.VenderModel ModVenda = new DataBase.Entity.VenderModel();

            List<DataBase.Entity.VenderModel> vd = dgvProd.CurrentRow.DataBoundItem as List<DataBase.Entity.VenderModel>;

            DataBase.Entity.tb_desc_venda dv = new DataBase.Entity.tb_desc_venda();

            foreach (DataBase.Entity.VenderModel dgvn in vd)
            {
                dv.id_produto = id;
                dv.qtd_vendido = dgvn.qtd_produto;

                DataBase.VendaDatabase db = new DataBase.VendaDatabase();

                db.InserirVendaDesc(dv);
            }
            

            MessageBox.Show("Informações de venda salvas");
        }


        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.ConsultaProduto();
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario telas = new Menus.FrmMenuTemporario();
            telas.Show();
            Hide();
        }

        private void nudrecb_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.Troco();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
