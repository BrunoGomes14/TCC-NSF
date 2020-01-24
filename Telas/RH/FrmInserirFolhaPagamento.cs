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
    public partial class FrmInserirFolhaPagamento : Form
    {
        List<DataBase.Entity.tb_funcionario> fun;

        public FrmInserirFolhaPagamento()
        {
            InitializeComponent();

            Business.FolhaPagamentoBusiness bu = new Business.FolhaPagamentoBusiness();
             fun = bu.ConsultarFuncionarios();

            cboFuncionario.DisplayMember = nameof(DataBase.Entity.tb_funcionario.nm_nome);
            cboFuncionario.ValueMember = nameof(DataBase.Entity.tb_funcionario.id_funcionario);

            cboFuncionario.DataSource = fun;
            

        }

        int funcionario = 0;
         decimal cal_extra = 0;
        decimal inss = 0;
        decimal vt = 0;
        int falta = 0;
        decimal descfalt = 0;
        decimal ir = 0;
        decimal sfamily = 0;
        decimal salario = 0;
        decimal salarioliquido = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ExibirInformacoes();
        }
        public void ExibirInformacoes()
        {
            try
            {
                DataBase.Entity.tb_funcionario mod = new DataBase.Entity.tb_funcionario();

                funcionario = Convert.ToInt32(cboFuncionario.SelectedValue);
                DateTime mes = dtpMes.Value;

                Business.FolhaPagamentoBusiness bu = new Business.FolhaPagamentoBusiness();
                salario = bu.ConsultaSalario(funcionario);

                Business.PontoBusiness bu2 = new Business.PontoBusiness();
                decimal hra_extra = Convert.ToDecimal( bu2.CalcularHorasExtras(funcionario, mes));
                cal_extra = bu.HoraExtra50(salario, hra_extra);
                lblExtra50.Text = Convert.ToString(cal_extra);
                lblExtra50.Visible = true;

                lblBruto.Text = Convert.ToString(salario) + " R$";
                lblBruto.Visible = true;

                inss = bu.CalcularInss(salario);
                lblINSS.Text = Convert.ToString(inss) + " R$"; 
                lblINSS.Visible = true;

                vt = bu.CalculoVT(salario);
                lblVT.Text = Convert.ToString(vt) + " R$";
                lblVT.Visible = true;

                falta = bu.Faltas(funcionario, mes);
                descfalt = bu.DescontoFalta(falta, salario);
                lblFalta.Text = Convert.ToString(falta) + "x" + " (" + Convert.ToString(descfalt) + " R$ )";
                lblFalta.Visible = true;

                ir = bu.CalculoIR(salario);
                lblIR.Text = Convert.ToString(ir) + " R$";
                lblIR.Visible = true;

                decimal tdesc = inss + vt + descfalt + ir;
                lblDescontoTotal.Text = Convert.ToString(tdesc) + " R$";
                lblDescontoTotal.Visible = true;

                sfamily = bu.SalarioFamilia(salario, funcionario);
                lblFamilia.Text = Convert.ToString(sfamily) + " R$";
                lblFamilia.Visible = true;
                    
                decimal plr = nudPLR.Value;

                decimal totbenf = plr + cal_extra + sfamily;
                lblBeneficio.Text = Convert.ToString(totbenf) + " R$";
                lblBeneficio.Visible = true;

                salarioliquido = (salario - tdesc) + totbenf;

                lblLiquido.Text = Convert.ToString(salarioliquido);
                lblLiquido.Visible = true;
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SalvarFolhaBanco() 
        {
            try
            {
                DataBase.Entity.tb_folha_pagamento model = new DataBase.Entity.tb_folha_pagamento();

                DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
                DataBase.Entity.tb_funcionario md = db.FuncionarioId(funcionario);

                model.id_funcionario = funcionario;
                model.tp_cargo = Convert.ToString(md.id_cargo);
                model.vl_vt = vt;
                model.vl_inss = inss;
                model.vl_irpj = ir;
                model.qtd_falta = falta;
                model.vl_salario_bruto = salario;
                model.vl_salario_liquido = salarioliquido;
                model.hr_extra = cal_extra;

                Business.FolhaPagamentoBusiness bu = new Business.FolhaPagamentoBusiness();
                bu.Salvar(model);

                MessageBox.Show("Inserido com sucesso");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public void Imprimir()
        {
            DataBase.Entity.tb_folha_pagamento model = new DataBase.Entity.tb_folha_pagamento();

            DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
            DataBase.Entity.tb_funcionario md = db.FuncionarioId(funcionario);

            model.id_funcionario = funcionario;
            model.tp_cargo = Convert.ToString(md.id_cargo);
            model.vl_vt = vt;
            model.vl_inss = inss;
            model.vl_irpj = ir;
            model.qtd_falta = falta;
            model.vl_salario_bruto = salario;
            model.vl_salario_liquido = salarioliquido;
            model.hr_extra = cal_extra;

            Telas.RH.FrmGeradorHoleride tela = new RH.FrmGeradorHoleride();
            tela.Preencher(model, descfalt);
            tela.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(cboFuncionario.SelectedValue);

            MessageBox.Show(id);
        }

        private void nudPLR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.ExibirInformacoes();
        }

        private void FrmInserirFolhaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.SalvarFolhaBanco();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.Imprimir();
        }

        private void CboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario telas = new Menus.FrmMenuTemporario();
            telas.Show();
            Hide();
        }
    }
}
