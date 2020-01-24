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
    public partial class FrmInserirDespesa : Form
    {
        public FrmInserirDespesa()
        {
            InitializeComponent();
        }

        private void FrmInserirDespesa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario tela = new Menus.FrmMenuTemporario();
            tela.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
