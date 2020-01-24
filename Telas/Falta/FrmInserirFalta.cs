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
    public partial class FrmInserirFalta : Form
    {
        public FrmInserirFalta()
        {
            InitializeComponent();

            DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
            List<DataBase.Entity.tb_funcionario> fun = db.ListarTodos();

            cboFuncionario.DisplayMember = nameof(DataBase.Entity.tb_funcionario.nm_nome);
            cboFuncionario.ValueMember = nameof(DataBase.Entity.tb_funcionario.id_funcionario);

        }

        private void FrmInserirFalta_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Salvar();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void Salvar()
        {
            DataBase.Entity.tb_falta falta = new DataBase.Entity.tb_falta();
            falta.id_funcionario = Convert.ToInt32(cboFuncionario.SelectedValue);
            falta.dt_falta = dtpFalta.Value;

            if (rdnSIm.Checked == true)
            {
                falta.bl_falta_justificada = true;
                falta.ds_justificativa = rtxtjustificativa.Text;
            }
            else
            {
                falta.bl_falta_justificada = false;
                falta.ds_justificativa = "-";

            }

            Business.FaltaBusiness bu = new Business.FaltaBusiness();
            bu.InserirFalta(falta);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbljustificativa.Visible = true;
            rtxtjustificativa.Visible = true;
        }

        private void rdnNop_CheckedChanged(object sender, EventArgs e)
        {
            lbljustificativa.Visible = false;
            rtxtjustificativa.Visible = false;
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
