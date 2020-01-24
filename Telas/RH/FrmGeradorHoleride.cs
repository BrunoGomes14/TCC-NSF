using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas.RH
{
    public partial class FrmGeradorHoleride : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        Bitmap memoryImage;


        public FrmGeradorHoleride()
        {
            InitializeComponent();

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();

            Hide();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.panel1.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X + this.panel1.Location.X, this.Location.Y + this.panel1.Location.Y + 30, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        public void Preencher(DataBase.Entity.tb_folha_pagamento folha, decimal faltadin)
        {
            DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
            DataBase.Entity.tb_funcionario  fun = db.FuncionarioId(folha.id_funcionario);

            lblIDFuncionario.Text = Convert.ToString(fun.id_funcionario);
            lblNome.Text = fun.nm_nome + " " + fun.nm_sobrenome;

            DataBase.CargoDatabase db1 = new DataBase.CargoDatabase();
            DataBase.Entity.tb_cargo CARGO = db1.CargoID(fun.id_cargo);
            lblfuncao.Text = CARGO.tp_cargo;

            lblValorFaltas.Text = Convert.ToString(folha.qtd_falta);
            lblINssvalordesc.Text = Convert.ToString(folha.vl_inss);
            lblIRVALOR.Text = Convert.ToString(folha.vl_irpj);
            lblvalorvt.Text = Convert.ToString(folha.vl_vt);
            lblsalariobruto.Text = Convert.ToString(folha.vl_salario_bruto);

            lblSalarioFamilia.Text = Convert.ToString(folha.vl_familia);
            lblvalorhoraextra.Text = Convert.ToString(folha.hr_extra);

            lblFaltadin.Text = Convert.ToString(faltadin);

            decimal desconto = Math.Round(faltadin + folha.vl_inss + folha.vl_irpj + folha.vl_vt, 2);
            lblDesc.Text = Convert.ToString(desconto);

            decimal proventos = Math.Round(folha.hr_extra + folha.vl_familia, 2);

            decimal liquido = (folha.vl_salario_bruto - desconto) + proventos;

            lblLiquido.Text = Convert.ToString(liquido);

            lbltotalprov.Text = Convert.ToString(proventos);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            this.WindowState = FormWindowState.Minimized;

            
        }
    }
}
