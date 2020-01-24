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
    public partial class FrmLoginOtica : Form
    {
        public FrmLoginOtica()
        {
            InitializeComponent();



        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            try
            {
                pcbFtoUser.Image = null;

                DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();
                mod.nm_email = txtUsuario.Text;
                

                Business.LoginBusiness lo = new Business.LoginBusiness();
                DataBase.LoginDatabase db = new DataBase.LoginDatabase();

                bool existe = db.ConsultarExistencia(mod.nm_email);

                if (!existe)
                {
                    lblDica.Visible = false;

                    throw new ArgumentException("E-mail não cadastrado no sistema"); 
                }
               

                byte[] fto = lo.ConsultarFoto(mod);

                MemoryStream mst = new MemoryStream(fto);


                pcbFtoUser.Image = System.Drawing.Image.FromStream(mst);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Business.LoginBusiness bu = new Business.LoginBusiness();
            DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();

            mod.nm_email = txtUsuario.Text;
            mod.pw_senha = txtSenha.Text;

            bu.EfetuarLogin(mod);


            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Telas.FrmEsqueciSenha tela = new FrmEsqueciSenha();
            tela.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string EmailPassando;
        int ContadorDeErros = 0;

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

            this.ExecutarLogin();
        }


        private void pcbFtoUser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "admin@gmail.com";
            txtSenha.Text = "admin";
        }

        private void ExecutarLogin()
        {

            try
            {
                Business.LoginBusiness bu = new Business.LoginBusiness();
                DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();
                DataBase.LoginDatabase db = new DataBase.LoginDatabase();

                mod.nm_email = txtUsuario.Text;
                mod.pw_senha = txtSenha.Text;

                if (mod.nm_email != EmailPassando)
                {
                    lblDica.Visible = false;
                    ContadorDeErros = 0;
                    EmailPassando = "nada";
                }
                if (mod.nm_email == EmailPassando)
                {
                    ContadorDeErros = ContadorDeErros + 1;
                }

                if (ContadorDeErros >= 4)
                {
                    bool existe = db.ConsultarExistencia(mod.nm_email);

                    if (existe)
                    {
                        string dica = db.ConsultarDicaUsuario(mod.nm_email);
                        lblDica.Text = "Dica: " + dica;

                        lblDica.Visible = true;
                    }

                }

                EmailPassando = mod.nm_email;
                bu.EfetuarLogin(mod);

                Hide();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==  13)
            {
                this.ExecutarLogin();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

            
        }
    }
}
