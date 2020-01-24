using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas.Funcionario
{
    public partial class FrmConsultarFuncionario : Form
    {
        public FrmConsultarFuncionario()
        {
            InitializeComponent();

            DataBase.FuncionarioDataBase funcionario = new DataBase.FuncionarioDataBase();

            List<DataBase.Entity.tb_funcionario> fun = funcionario.ListarTodos();

            dtpFuncionario.AutoGenerateColumns = false;

            dtpFuncionario.DataSource = fun;



        }

        private void pcbBuscar_Click(object sender, EventArgs e)
        {
            //string funcionario = txtfun.Text;

            //DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
            //List<DataBase.Entity.tb_funcionario> lista = db.ConsultarPorNomeFuncionario(funcionario);

            //dtpFuncionario.DataSource = lista;

            dtpFuncionario.AutoGenerateColumns = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario telas = new Menus.FrmMenuTemporario();
            telas.Show();
            Hide();
        }

        private void FrmConsultarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
