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
    public partial class FrmDeletarFornecedor : Form
    {
        public FrmDeletarFornecedor()
        {
            InitializeComponent();

            dgvFornecedor.AutoGenerateColumns = false;

            this.Carregar();
        }

        public void Carregar()
        {
            Business.FornecedorBusiness businessF = new Business.FornecedorBusiness();
            List<DataBase.Entity.tb_fornecedor> fornecedores = businessF.ListarTodos();

           cboNomeForncedor.DisplayMember = nameof(DataBase.Entity.tb_fornecedor.nm_fornecedor);
           cboNomeForncedor.DataSource = fornecedores;          
        }

        private void cboNomeForncedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeF = cboNomeForncedor.Text;

            Business.FornecedorBusiness business = new Business.FornecedorBusiness();
            List<DataBase.Entity.tb_fornecedor> fornecedors = business.ConsultarPorNomeFornecedor(nomeF);

            dgvFornecedor.DataSource = fornecedors;

           

          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBase.Entity.tb_fornecedor fornecedor = dgvFornecedor.CurrentRow.DataBoundItem as DataBase.Entity.tb_fornecedor;

            txtCelular.Text = fornecedor.nr_celular;
            txtCNPJ.Text = fornecedor.nr_cnpj;
            txtNome.Text = fornecedor.nm_fornecedor;
            txtResponsavel.Text = fornecedor.nm_responsavel;
            txtTelefone.Text = fornecedor.nr_tel;
            txtTPFornecimento.Text = fornecedor.tp_fornecimento;

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DataBase.Entity.tb_fornecedor fornecedor = dgvFornecedor.CurrentRow.DataBoundItem as DataBase.Entity.tb_fornecedor;

            Business.FornecedorBusiness business = new Business.FornecedorBusiness();
            business.Remover(fornecedor);

            MessageBox.Show("Removido Com Sucesso!");


        }

        private void dgvFornecedor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataBase.Entity.tb_fornecedor fornecedor = dgvFornecedor.CurrentRow.DataBoundItem as DataBase.Entity.tb_fornecedor;

            txtCelular.Text = fornecedor.nr_celular;
            txtCNPJ.Text = fornecedor.nr_cnpj;
            txtNome.Text = fornecedor.nm_fornecedor;
            txtResponsavel.Text = fornecedor.nm_responsavel;
            txtTelefone.Text = fornecedor.nr_tel;
            txtTPFornecimento.Text = fornecedor.tp_fornecimento;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DataBase.Entity.tb_fornecedor fornecedor = dgvFornecedor.CurrentRow.DataBoundItem as DataBase.Entity.tb_fornecedor;

            txtCelular.Text = fornecedor.nr_celular;
            txtCNPJ.Text = fornecedor.nr_cnpj;
            txtNome.Text = fornecedor.nm_fornecedor;
            txtResponsavel.Text = fornecedor.nm_responsavel;
            txtTelefone.Text = fornecedor.nr_tel;
            txtTPFornecimento.Text = fornecedor.tp_fornecimento;

            Business.FornecedorBusiness business = new Business.FornecedorBusiness();
            business.AlterarFornecedor(fornecedor);

            MessageBox.Show("Alterado Com Sucesso!");
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
