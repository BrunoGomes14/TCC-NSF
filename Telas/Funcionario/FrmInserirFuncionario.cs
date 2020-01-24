using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas
{
    public partial class FrmInserirFuncionario : Form
    {
        public FrmInserirFuncionario()
        {
            InitializeComponent();

            try
            {
                DataBase.CargoDatabase db = new DataBase.CargoDatabase();
                List<DataBase.Entity.tb_cargo> cargos = db.ListarTodos();

                cboCargo.DisplayMember = nameof(DataBase.Entity.tb_cargo.tp_cargo);
                cboCargo.ValueMember = nameof(DataBase.Entity.tb_cargo.id_cargo);

                cboCargo.DataSource = cargos;

            }
            catch (Exception)
            {

                throw;
            }
        }

        int idfun = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Files(*.jpg)| *.jpg| PNG Files(*.png)|*.png| AllFiles(*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string foto = file.FileName.ToString();
                txtEndereco.Text = foto;
                pictureBox1.ImageLocation = foto;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.RegistroFuncionario();
                this.RegistroDesc();
                this.RegistroLogin();
                this.InserirJornada();

                MessageBox.Show("Funcionário cadastrado com sucesso");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            

        }

        private void RegistroFuncionario()
        {
            DataBase.Entity.tb_funcionario mod = new DataBase.Entity.tb_funcionario();

            mod.nm_nome = txtNome.Text;
            mod.nm_sobrenome = txtSobrenome.Text;
            mod.nr_cpf = txtCPF.Text;
            mod.nr_rg = txtRG.Text;

            if (rdnFeminino.Checked == true)
                mod.tp_genero = "F";

            if (rdnMaculino.Checked == true)
                mod.tp_genero = "M";

            mod.nr_dependentes = Convert.ToInt32(nudDependentes.Value);
            mod.dt_admissao = dtpAdmissao.Value;
            mod.id_cargo = Convert.ToInt32(cboCargo.SelectedValue);
            mod.dt_nascimento = dtpNascimento.Value;

             Business.FuncionarioBusiness DB = new Business.FuncionarioBusiness();
             DB.InserirFuncionario(mod);

            idfun = mod.id_funcionario;

        }
        private void RegistroDesc()
        {
            DataBase.Entity.tb_desc_funcionario mod = new DataBase.Entity.tb_desc_funcionario();
            mod.id_funcionario = idfun;
            mod.nm_rua = txtRua.Text;
            mod.nr_cep = txtCEP.Text;
            mod.nr_moradia = Convert.ToInt32(txtNumero.Text);
            mod.nr_telefone = txtTelefone.Text;
            mod.nr_celular = txtCelular.Text;
        }
        private void RegistroLogin()
        {
            DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();

            mod.nm_usuario = txtNome.Text;
            mod.pw_senha = txtSenha.Text;
            mod.tp_hierarquia = cboCargo.Text;
            mod.nm_dica = txtDica.Text;
            mod.id_funcionario = idfun;

            FileStream fs = new FileStream(this.txtEndereco.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] image = br.ReadBytes((int)fs.Length);

            mod.ft_usuario = image;

            Business.LoginBusiness bu = new Business.LoginBusiness();
            bu.CadastroUsuario(mod);

        }
        private void InserirJornada()
        {
            DataBase.Entity.tb_jornada jornada = new DataBase.Entity.tb_jornada();

            jornada.hr_entrada = dtpEntrada.Value.TimeOfDay;
            jornada.hr_intervalo = dtpIntervalo.Value.TimeOfDay;
            jornada.hr_volta_intervalo = dtpVoltaIntervalo.Value.TimeOfDay;
            jornada.hr_saida = dtpSaída.Value.TimeOfDay;
            jornada.id_funcionario = idfun;

            Business.JornadaBusiness bu = new Business.JornadaBusiness();
            bu.InserirJornada(jornada);


        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = true;
                e = null;
            }
  
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = true;
                e = null;
            }
        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = true;
                e = null;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

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
    }
}
