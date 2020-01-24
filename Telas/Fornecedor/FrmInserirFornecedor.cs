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
    public partial class FrmInserirFornecedor : Form
    {
        public FrmInserirFornecedor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.Entity.tb_fornecedor fornecedor = new DataBase.Entity.tb_fornecedor();

                fornecedor.nm_fornecedor = txtNome.Text;
                fornecedor.nm_responsavel = txtResponsavel.Text;
                fornecedor.nr_celular = txtCelular.Text;
                fornecedor.nr_cnpj = txtCNPJ.Text;
                fornecedor.nr_tel = txtTelefone.Text;
                fornecedor.tp_fornecimento = txtTipoFornecimento.Text;

                Business.FornecedorBusiness business = new Business.FornecedorBusiness();
                business.Inserir(fornecedor);

                MessageBox.Show("Fornecedor Inserido Com Sucesso");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
            
            

          
            

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = true;
                e = null;
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
    }
}
