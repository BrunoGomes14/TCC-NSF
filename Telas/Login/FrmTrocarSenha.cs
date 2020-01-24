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
    public partial class FrmTrocarSenha : Form
    {
        string usuario;

        public FrmTrocarSenha(string email)
        {
            usuario = email;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha1.Text == txtSenha2.Text)
                {
                    Business.LoginBusiness bu = new Business.LoginBusiness();
                    DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();

                    mod.nm_email = usuario;
                    mod.pw_senha = txtSenha1.Text;
                    bu.AlterarSenha(mod);

                    MessageBox.Show("Senha alterada com sucesso");

                    Telas.FrmLoginOtica tela = new FrmLoginOtica();
                    tela.Show();
                    Hide();
                }
                else
                {
                    throw new ArgumentException("As senhas não conferem");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha1.Text == txtSenha2.Text)
                {
                    Business.LoginBusiness bu = new Business.LoginBusiness();
                    DataBase.Entity.tb_login mod = new DataBase.Entity.tb_login();

                    mod.nm_email = usuario;
                    mod.pw_senha = txtSenha1.Text;
                    bu.AlterarSenha(mod);

                    MessageBox.Show("Senha alterada com sucesso");

                    Telas.FrmLoginOtica tela = new FrmLoginOtica();
                    tela.Show();
                    Hide();
                }
                else
                {
                    throw new ArgumentException("As senhas não conferem");
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.FrmLoginOtica telas = new FrmLoginOtica();
            telas.Show();
            Hide();
        }
    } }
