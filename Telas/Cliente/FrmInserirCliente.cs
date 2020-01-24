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
    public partial class FrmInserirCliente : Form
    {
        public FrmInserirCliente()
        {
            InitializeComponent();
        }

        private void FrmInserirCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DataBase.Entity.tb_cliente cliente = new DataBase.Entity.tb_cliente();

            cliente.dt_nascimento = dtpNascimento.Value;
            cliente.nm_email = txtEmail.Text;
            cliente.nm_nome = txtNome.Text;
            cliente.nm_rua = txtRua.Text;
            cliente.nm_sobrenome = txtSobrenome.Text;
            cliente.nr_celular = txtCelular.Text;
            cliente.nr_cep = txtCEP.Text;
            cliente.nr_cpf = txtCPF.Text;
            cliente.nr_moradia = txtNumero.Text;
            cliente.nr_rg = txtRG.Text;
            cliente.nr_telefone = txtTelefone.Text;


            Business.ClienteBusiness business = new Business.ClienteBusiness();
            business.InserirCliente(cliente);

            MessageBox.Show("Cliente Inserido Com Sucesso");
        }

       

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCEP.Text;
                Objetos_Auxiliares.CorreioApi correio = new Objetos_Auxiliares.CorreioApi();

                if (txtCEP.Text == "     -")
                    throw new ArgumentException("O CEP não pode estar vazio");

                string endereco = correio.Buscar(cep);

                txtRua.Text = endereco;
            }
            catch (ArgumentException ex)
            {
               MessageBox.Show(ex.Message);
            }
          

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario telas = new Menus.FrmMenuTemporario();
            telas.Show();
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

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
