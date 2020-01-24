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
    public partial class FrmEsqueciSenha : Form
    {
        public FrmEsqueciSenha()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
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
                DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();
                mod.nm_email = txtUsuario.Text;

                Business.LoginBusiness bu = new Business.LoginBusiness();

                bool certo = bu.GerarCodigoRecuperarSenha(mod.nm_email);

                if (certo == true)
                {
                    Telas.FrmConferirCodigo tela = new Telas.FrmConferirCodigo(mod.nm_email);
                    tela.Show();
                    Hide();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Hide();
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
