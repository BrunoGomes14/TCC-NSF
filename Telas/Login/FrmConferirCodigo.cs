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
    public partial class FrmConferirCodigo : Form
    {
        string usuario;

        public FrmConferirCodigo(string usuariotrocando)
        {
            InitializeComponent();

            usuario = usuariotrocando;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                Business.LoginBusiness bu = new Business.LoginBusiness();
                DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();

                mod.nm_email = usuario;
                mod.cd_recuperacao = txtCodigo.Text;

                bool conferer = bu.ConferirCodigo(mod);

                if(conferer)
                {
                    Telas.FrmTrocarSenha tela = new FrmTrocarSenha(usuario);
                    tela.Show();
                    Hide();
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void FrmConferirCodigo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            try
            {
                Business.LoginBusiness bu = new Business.LoginBusiness();
                DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();

                mod.nm_email = usuario;
                mod.cd_recuperacao = txtCodigo.Text;

                bool conferer = bu.ConferirCodigo(mod);

                if (conferer)
                {
                    Telas.FrmTrocarSenha tela = new FrmTrocarSenha(usuario);
                    tela.Show();
                    Hide();
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.FrmLoginOtica telas = new FrmLoginOtica();
            telas.Show();
            Hide();
        }
    }
}
