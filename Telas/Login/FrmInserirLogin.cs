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
    public partial class FrmInserirLogin : Form
    {
        public FrmInserirLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Files(*.jpg)| *.jpg| PNG Files(*.png)|*.png| AllFiles(*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string foto = file.FileName.ToString();
                txtEndereco.Text = foto;
                pictureBox2.ImageLocation = foto;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.Entity.tb_login md = new DataBase.Entity.tb_login();

                md.nm_usuario = TxtNm.Text;
                md.pw_senha = TxtPassword.Text;
                md.nm_dica = txtDiica.Text;
                md.tp_hierarquia = txtTipo.Text;

                FileStream fs = new FileStream(this.txtEndereco.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                byte[] image = br.ReadBytes((int)fs.Length);

                md.ft_usuario = image;

                Business.LoginBusiness bu = new Business.LoginBusiness();
                bu.CadastroUsuario(md);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Telas.FrmLoginOtica telas = new FrmLoginOtica();
            telas.Show();
            Hide();
        }
    }
}
