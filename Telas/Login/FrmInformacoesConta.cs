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

namespace TCC.Telas.Login
{
    public partial class FrmInformacoesConta : Form
    {
        public FrmInformacoesConta()
        {
            InitializeComponent();

            byte[] fto = DataBase.Entity.UsuarioLogadoModel.login.ft_usuario;

            MemoryStream mst = new MemoryStream(fto);

            pcbFoto.Image = System.Drawing.Image.FromStream(mst);

            //lblUsuario.Text = DataBase.Entity.UsuarioLogadoModel.login.nm_usuario;

            string funcionario = "-";

            if(DataBase.Entity.UsuarioLogadoModel.login.id_funcionario > 0)
            {
                DataBase.LoginDatabase db = new DataBase.LoginDatabase();
                funcionario = db.ConsultaId(Convert.ToInt32(DataBase.Entity.UsuarioLogadoModel.login.id_funcionario));
                
            }

            lblFuncionario.Text = funcionario;
        }

        private void FrmInformacoesConta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide(); 
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

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
