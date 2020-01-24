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
    public partial class FrmDeletarCliente : Form
    {
        public FrmDeletarCliente()
        {
            InitializeComponent();
            this.Carregar();
        }

        public void Carregar()
        {
            Business.ClienteBusiness businessC = new Business.ClienteBusiness();
            List<DataBase.Entity.tb_cliente> clientes = businessC.ListarTodos();

            cboCliente.DisplayMember = nameof(DataBase.Entity.tb_cliente.nm_nome);
            cboCliente.DataSource = clientes;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeC = cboCliente.Text;

            Business.ClienteBusiness business = new Business.ClienteBusiness();

            List<DataBase.Entity.tb_cliente> clientes = business.ConsultarPorNomeCliente(nomeC);

            dataGridView1.DataSource = clientes;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBase.Entity.tb_cliente clientes = dataGridView1.CurrentRow.DataBoundItem as DataBase.Entity.tb_cliente;

            dtpNascimento.Value = Convert.ToDateTime(clientes.dt_nascimento) ;
            txtEmail.Text = clientes.nm_email;
            txtNome.Text = clientes.nm_nome ;
            txtRua.Text = clientes.nm_rua;
            txtSobrenome.Text  = clientes.nm_sobrenome;
            txtCelular.Text = clientes.nr_celular;
            txtCEP.Text  = clientes.nr_cep;
             txtCPF.Text  = clientes.nr_cpf;
            txtNumero.Text = clientes.nr_moradia;
            txtRG.Text = clientes.nr_rg;
            txtTelefone.Text = clientes.nr_telefone;

            dataGridView1.AutoGenerateColumns = false;

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DataBase.Entity.tb_cliente clientes = dataGridView1.CurrentRow.DataBoundItem as DataBase.Entity.tb_cliente;

            Business.ClienteBusiness business = new Business.ClienteBusiness();
            business.removercliente(clientes);

            MessageBox.Show("Cliente Removido Com Sucesso");
            this.Carregar();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           




        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario tela = new Menus.FrmMenuTemporario();
            tela.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            DataBase.Entity.tb_cliente clientes = dataGridView1.CurrentRow.DataBoundItem as DataBase.Entity.tb_cliente;

            clientes.dt_nascimento = dtpNascimento.Value;
            clientes.nm_email = txtEmail.Text;
            clientes.nm_nome = txtNome.Text;
            clientes.nm_rua = txtRua.Text;
            clientes.nm_sobrenome = txtSobrenome.Text;
            clientes.nr_celular = txtCelular.Text;
            clientes.nr_cep = txtCEP.Text;
            clientes.nr_cpf = txtCPF.Text;
            clientes.nr_moradia = txtNumero.Text;
            clientes.nr_rg = txtRG.Text;
            clientes.nr_telefone = txtTelefone.Text;

            Business.ClienteBusiness cliente = new Business.ClienteBusiness();
            cliente.AlterarCliente(clientes);

            MessageBox.Show("Cliente Alterado Com Sucesso");
        }
    }
}
