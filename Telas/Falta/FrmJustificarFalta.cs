using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas.Falta
{
    public partial class FrmJustificarFalta : Form
    {
        public FrmJustificarFalta()
        {
            InitializeComponent();

            DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
            List<DataBase.Entity.tb_funcionario> lista = db.ListarTodos();

            cboFuncionario.DisplayMember = nameof(DataBase.Entity.tb_funcionario.nm_nome);
            cboFuncionario.ValueMember = nameof(DataBase.Entity.tb_funcionario.id_funcionario);
            cboFuncionario.DataSource = lista;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pcbSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboFuncionario.SelectedValue);

            DataBase.FaltaDatabase db = new DataBase.FaltaDatabase();

            bool existe = db.ExisteFaltaTotal(id);

            if (!existe)
                throw new ArgumentException("Não há faltas");

             List<DataBase.Entity.tb_falta> faltas = db.ListarTodos();

            cboFalta.DisplayMember = nameof(DataBase.Entity.tb_falta.dt_falta);
            cboFalta.DataSource = faltas;

        }

        private void cboFalta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.Entity.tb_falta falta = new DataBase.Entity.tb_falta();

            falta.id_funcionario = Convert.ToInt32(cboFuncionario.SelectedValue);
            falta.dt_falta = Convert.ToDateTime(cboFalta.Text);

            falta.ds_justificativa = rtxtjustifica.Text;

            Business.FaltaBusiness bu = new Business.FaltaBusiness();
            bu.AlterarFalta(falta);

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
