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
    public partial class FrmDeletarFalta : Form
    {
        public FrmDeletarFalta()
        {
            InitializeComponent();
            DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
            List<DataBase.Entity.tb_funcionario> lista = db.ListarTodos();

            cboFuncionario.DisplayMember = nameof(DataBase.Entity.tb_funcionario.nm_nome);
            cboFuncionario.ValueMember = nameof(DataBase.Entity.tb_funcionario.id_funcionario);
            cboFuncionario.DataSource = lista;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataBase.Entity.tb_falta falta = new DataBase.Entity.tb_falta();

            falta.id_funcionario = Convert.ToInt32(cboFuncionario.SelectedValue);
            falta.dt_falta = dtpFalta.Value;

            Business.FaltaBusiness bu = new Business.FaltaBusiness();
            bu.RemoverFalta(falta);
        }

        private void btnRemover_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario telas = new Menus.FrmMenuTemporario();
            telas.Show();
            Hide();
        }
    }
}
