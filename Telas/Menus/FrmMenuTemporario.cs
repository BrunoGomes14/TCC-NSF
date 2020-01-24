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

namespace TCC.Telas.Menus
{
    public partial class FrmMenuTemporario : Form
    {
        public FrmMenuTemporario()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            DataBase.Entity.tb_login user = DataBase.Entity.UsuarioLogadoModel.login;

            Business.LoginBusiness bu = new Business.LoginBusiness();
            byte[] fto = bu.ConsultarFoto(user);

            MemoryStream mst = new MemoryStream(fto);

            pcbUser.Image = System.Drawing.Image.FromStream(mst);

            lblBoasVindas.Visible = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }



     

        private void btnCliente_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image img = pcbUser.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbUser.Image = img;
        }

        private void pcbUser_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void pcbUser_MouseEnter(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
           

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void pcbUser_MouseLeave(object sender, EventArgs e)
        {
            //timer1.Stop();
            //timer2.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            //timer1.Stop();
            //timer2.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirFolhaPagamento tela = new FrmInserirFolhaPagamento();
            tela.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            groupBox1.Height += 15;
            if (groupBox1.Height >= 96)
            {
                groupBox1.Height = 95;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            groupBox1.Height -= 10;
            if (groupBox1.Height <= 0)
            {
                groupBox1.Height = 0;
                timer2.Stop();
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Telas.FrmLoginOtica tela = new FrmLoginOtica();
            tela.Show();
            Hide();
        }

        private void lblInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Telas.Login.FrmInformacoesConta tela = new Login.FrmInformacoesConta();
            tela.Show();
            
        }

        private void FrmMenuTemporario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            groupBox2.Width += 15;
            if (groupBox2.Width >= 224)
            {
                groupBox2.Width = 223;
                timer3.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            timer4.Stop();
            timer3.Start();
            
                
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            groupBox2.Width -= 15;
            if (groupBox2.Width <= 0)
            {
                groupBox2.Width = 0;
                timer3.Stop();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            timer3.Stop();
            timer4.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Telas.Funcionario.AlterarFuncionario tela = new Funcionario.AlterarFuncionario();
            tela.Show();
            Hide();
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                if(DataBase.Entity.UsuarioLogadoModel.login.tp_hierarquia != "gerente")
                {
                    throw new ArgumentException("Usuário não possui permissões necessárias para acessar este modulo");
                }

                if (gpbFuncionarios.Height == 0)
                {
                    FecharFuncionario.Stop();
                    AbrirFuncionario.Start();

                }



                if (gpbFuncionarios.Height > 0)
                {
                    AbrirFuncionario.Stop();
                    FecharFuncionario.Start();

                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Image img = pcbFuncionario.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbFuncionario.Image = img;

            

           
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            gpbFuncionarios.Height += 15;
            if (gpbFuncionarios.Height >= 158)
            {
                gpbFuncionarios.Height = 157;
                AbrirFuncionario.Stop();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            gpbFuncionarios.Height -= 15;
            if (gpbFuncionarios.Height <= 0 )
            {
                gpbFuncionarios.Height = 0;
                AbrirFuncionario.Stop();
            }
        }

        private void Label65_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirJornada tela = new FrmInserirJornada();
            tela.Show();
            Hide();
        }

        private void pcbproduto_Click(object sender, EventArgs e)
        {
            Image img = pcbproduto.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbproduto.Image = img;



            if (gpbProdutos.Height == 0)
            {
                FecharProdutos.Stop();
                AbrirProdutos.Start();

            }



            if (gpbProdutos.Height == 157)
            {
                AbrirProdutos.Stop();
                FecharProdutos.Start();

            }
        }

        private void AbrirProdutos_Tick(object sender, EventArgs e)
        {
            gpbProdutos.Height += 15;
            if (gpbProdutos.Height >= 158)
            {
                gpbProdutos.Height = 157;
                AbrirProdutos.Stop();
            }
        }

        private void FecharProdutos_Tick(object sender, EventArgs e)
        {
            gpbProdutos.Height -= 15;
            if (gpbProdutos.Height <= 0)
            {
                gpbProdutos.Height = 0;
                AbrirProdutos.Stop();
            }
        }

        private void pcbcliente_Click(object sender, EventArgs e)
        {
            Image img = pcbcliente.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbcliente.Image = img;



            if (gpbCliente.Height == 0)
            {
                FecharCliente.Stop();
                AbrirCliente.Start();

            }



            if (gpbCliente.Height == 157)
            {
                AbrirCliente.Stop();
                FecharCliente.Start();

            }
        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {
            gpbCliente.Height += 15;
            if (gpbCliente.Height >= 158)
            {
                gpbCliente.Height = 157;
                AbrirCliente.Stop();
            }
        }

        private void FecharCliente_Tick(object sender, EventArgs e)
        {
            gpbCliente.Height -= 15;
            if (gpbCliente.Height <= 0)
            {
                gpbCliente.Height = 0;
                AbrirCliente.Stop();
            }
        }

        private void pcbfornecedores_Click(object sender, EventArgs e)
        {
            Image img = pcbfornecedores.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbfornecedores.Image = img;



            if (gpbFornecedores.Height == 0)
            {
                FecharFornecedores.Stop();
                AbrirFornecedores.Start();

            }



            if (gpbFornecedores.Height > 0)
            {
                AbrirFornecedores.Stop();
                FecharFornecedores.Start();

            }
        }

        private void AbrirFornecedores_Tick(object sender, EventArgs e)
        {
            gpbFornecedores.Height += 15;
            if (gpbFornecedores.Height >= 158)
            {
                gpbFornecedores.Height = 157;
                AbrirFornecedores.Stop();
            }
        }

        private void FecharFornecedores_Tick(object sender, EventArgs e)
        {
            gpbFornecedores.Height -= 15;
            if (gpbFornecedores.Height <= 0)
            {
                gpbFornecedores.Height = 0;
                AbrirFornecedores.Stop();
            }
        }

        private void AbrirCargos_Tick(object sender, EventArgs e)
        {
            gpbCargos.Height += 15;
            if (gpbCargos.Height >= 158)
            {
                gpbCargos.Height = 157;
                AbrirCargos.Stop();
            }
        }

        private void FecharCargos_Tick(object sender, EventArgs e)
        {
            gpbCargos.Height -= 15;
            if (gpbCargos.Height <= 0)
            {
                gpbCargos.Height = 0;
                AbrirCargos.Stop();
            }
        }

        private void pcbCargo_Click(object sender, EventArgs e)
        {
            Image img = pcbCargo.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbCargo.Image = img;



            if (gpbCargos.Height == 0)
            {
                FecharCargos.Stop();
                AbrirCargos.Start();

            }



            if (gpbCargos.Height == 157)
            {
                AbrirCargos.Stop();
                FecharCargos.Start();

            }
        }

        private void pcbDespesa_Click(object sender, EventArgs e)
        {
            Image img = pcbDespesa.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbDespesa.Image = img;



            if (gpbDespesas.Height == 0)
            {
                FecharDespesas.Stop();
                AbrirDespesas.Start();

            }



            if (gpbDespesas.Height == 157)
            {
                AbrirDespesas.Stop();
                FecharDespesas.Start();

            }
        }

        private void AbrirDespesas_Tick(object sender, EventArgs e)
        {
            gpbDespesas.Height += 15;
            if (gpbDespesas.Height >= 158)
            {
                gpbDespesas.Height = 157;
                AbrirDespesas.Stop();
            }
        }

        private void FecharDespesas_Tick(object sender, EventArgs e)
        {
            gpbDespesas.Height -= 15;
            if (gpbDespesas.Height <= 0)
            {
                gpbDespesas.Height = 0;
                AbrirDespesas.Stop();
            }

        }

        private void AbrirPonto_Tick(object sender, EventArgs e)
        {
            gpbCont.Height += 15;
            if (gpbCont.Height >= 158)
            {
                gpbCont.Height = 157;
                AbrirPonto.Stop();
            }
        }

        private void FecharPonto_Tick(object sender, EventArgs e)
        {
            gpbCont.Height -= 15;
            if (gpbCont.Height <= 0)
            {
                gpbCont.Height = 0;
                AbrirPonto.Stop();
            }
        }

        private void pcbControlePonto_Click(object sender, EventArgs e)
        {
            Image img = pcbControlePonto.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbControlePonto.Image = img;



            if (gpbCont.Height == 0)
            {
                FecharPonto.Stop();
                AbrirPonto.Start();

            }



            if (gpbCont.Height == 157)
            {
                AbrirPonto.Stop();
                FecharPonto.Start();

            }
        }

        private void AbrirSalario_Tick(object sender, EventArgs e)
        {
            gpbSalario.Height += 15;
            if (gpbSalario.Height >= 158)
            {
                gpbSalario.Height = 157;
                AbrirSalario.Stop();
            }
        }

        private void FecharSalario_Tick(object sender, EventArgs e)
        {
            gpbSalario.Height -= 15;
            if (gpbSalario.Height <= 0)
            {
                gpbSalario.Height = 0;
                AbrirSalario.Stop();
            }
        }

        private void pcbSalario_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataBase.Entity.UsuarioLogadoModel.login.tp_hierarquia != "gerente")
                {
                    throw new ArgumentException("Usuário não possui permissões necessárias para acessar este modulo");
                }

                Image img = pcbSalario.Image;
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pcbSalario.Image = img;



                if (gpbSalario.Height == 0)
                {
                    FecharSalario.Stop();
                    AbrirSalario.Start();

                }



                if (gpbSalario.Height == 157)
                {
                    AbrirSalario.Stop();
                    FecharSalario.Start();

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AbrirServico_Tick(object sender, EventArgs e)
        {
            gpbServicos.Height += 15;
            if (gpbServicos.Height >= 158)
            {
                gpbServicos.Height = 157;
                AbrirServico.Stop();
            }
        }

        private void FecharServico_Tick(object sender, EventArgs e)
        {
            gpbServicos.Height -= 15;
            if (gpbServicos.Height <= 0)
            {
                gpbServicos.Height = 0;
                AbrirServico.Stop();
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Image img = pcbServicos.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbServicos.Image = img;



            if (gpbServicos.Height == 0)
            {
                FecharServico.Stop();
                AbrirServico.Start();

            }



            if (gpbServicos.Height == 157)
            {
                AbrirServico.Stop();
                FecharServico.Start();

            }
        }

        private void pcbVendas_Click(object sender, EventArgs e)
        {
            Image img = pcbVendas.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcbVendas.Image = img;



            if (gpbVenda.Height == 0)
            {
                FecharVenda.Stop();
                AbrirVenda.Start();

            }



            if (gpbVenda.Height == 157)
            {
                AbrirVenda.Stop();
                FecharVenda.Start();

            }
        }

        private void AbrirVenda_Tick(object sender, EventArgs e)
        {
            gpbVenda.Height += 15;
            if (gpbVenda.Height >= 158)
            {
                gpbVenda.Height = 157;
                AbrirVenda.Stop();
            }
        }

        private void FecharVenda_Tick(object sender, EventArgs e)
        {
            gpbVenda.Height -= 15;
            if (gpbVenda.Height <= 0)
            {
                gpbVenda.Height = 0;
                AbrirVenda.Stop();
            }
        }

        private void AbrirRH_Tick(object sender, EventArgs e)
        {
            gpbRH.Height += 15;
            if (gpbRH.Height >= 158)
            {
                gpbRH.Height = 157;
                AbrirRH.Stop();
            }
        }

        private void FecharRH_Tick(object sender, EventArgs e)
        {
            gpbRH.Height -= 15;
            if (gpbRH.Height <= 0)
            {
                gpbRH.Height = 0;
                AbrirRH.Stop();
            }
        }

        private void pcbRH_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataBase.Entity.UsuarioLogadoModel.login.tp_hierarquia != "gerente")
                {
                    throw new ArgumentException("Usuário não possui permissões necessárias para acessar este modulo");
                }

                Image img = pcbRH.Image;
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pcbRH.Image = img;



                if (gpbRH.Height == 0)
                {
                    FecharRH.Stop();
                    AbrirRH.Start();

                }



                if (gpbRH.Height == 157)
                {
                    AbrirRH.Stop();
                    FecharRH.Start();

                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirFuncionario tela = new FrmInserirFuncionario();
            tela.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Telas.Funcionario.AlterarFuncionario tela = new Funcionario.AlterarFuncionario();
            tela.Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Telas.Funcionario.AlterarFuncionario tela = new Funcionario.AlterarFuncionario();
            tela.Show();
            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirFalta tela = new FrmInserirFalta();
            tela.Show();
            Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarFalta tela = new FrmDeletarFalta();
            tela.Show();
            Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarFalta tela = new FrmDeletarFalta();
            tela.Show();
            Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmInserirProduto tela =new Estoque.frmInserirProduto();
            tela.Show();
            Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmAlterarRemoverProduto tela = new Estoque.frmAlterarRemoverProduto();
            tela.Show();
            Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmAlterarRemoverProduto tela = new Estoque.frmAlterarRemoverProduto();
            tela.Show();
            Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmAlterarRemoverProduto produto = new Estoque.frmAlterarRemoverProduto();
            produto.Show();
            Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmConsultarProduto tela = new Estoque.frmConsultarProduto();
            tela.Show();
            Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirCliente tela = new FrmInserirCliente();
            tela.Show();
            Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarCliente tela = new FrmDeletarCliente();
            tela.Show();
            Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarCliente tela = new FrmDeletarCliente();
            tela.Show();
            Hide();
        }

        private void gpbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarCliente tela = new FrmDeletarCliente();
            tela.Show();
            Hide();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirFornecedor tela = new FrmInserirFornecedor();
            tela.Show();
            Hide();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            Telas.FrmConsultarFornecedor tela = new FrmConsultarFornecedor();
            tela.Show();
            Hide();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarFornecedor tela = new FrmDeletarFornecedor();
            tela.Show();
            Hide();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarFornecedor tela = new FrmDeletarFornecedor();
            tela.Show();
            Hide();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirCargo tela = new FrmInserirCargo();
            tela.Show();
            Hide();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarCargo tela = new FrmDeletarCargo();
            tela.Show();
            Hide();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarCargo tela = new FrmDeletarCargo();
            tela.Show();
            Hide();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarCargo tela = new FrmDeletarCargo();
            tela.Show();
            Hide();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirDespesa tela = new FrmInserirDespesa();
            tela.Show();
            Hide();
        }

        private void label39_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarDespesa tela = new FrmDeletarDespesa();
            tela.Show();
            Hide();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarDespesa tela = new FrmDeletarDespesa();
            tela.Show();
            Hide();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarDespesa tela = new FrmDeletarDespesa();
            tela.Show();
            Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirPonto tela = new FrmInserirPonto();
            tela.Show();
            Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarPonto tela = new FrmDeletarPonto();
            tela.Show();
            Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarPonto tela = new FrmDeletarPonto();
            tela.Show();
            Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarPonto tela = new FrmDeletarPonto();
            tela.Show();
            Hide();
        }

        private void label46_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirSalario tela = new FrmInserirSalario();
            tela.Show();
            Hide();
        }

        private void label45_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarSalario tela = new FrmDeletarSalario();
            tela.Show();
            Hide(); 
        }

        private void label44_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarSalario tela = new FrmDeletarSalario();
            tela.Show();
            Hide();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarSalario tela = new FrmDeletarSalario();
            tela.Show();
            Hide();
        }

        private void label51_Click(object sender, EventArgs e)
        {
            Telas.Servicos.InserirServico tela = new Servicos.InserirServico();
            tela.Show();
            Hide();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarServico tela = new FrmDeletarServico();
            tela.Show();
            Hide();
        }

        private void label49_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarServico tela = new FrmDeletarServico();
            tela.Show();
            Hide();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarServico tela = new FrmDeletarServico();
            tela.Show();
            Hide();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirVenda tela = new FrmInserirVenda();
            tela.Show();
            Hide();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarVenda tela = new FrmDeletarVenda();
            tela.Show();
            Hide();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarVenda tela = new FrmDeletarVenda();
            tela.Show();
            Hide();
        }

        private void label53_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarVenda tela = new FrmDeletarVenda();
            tela.Show();
            Hide();
        }

        private void label58_Click(object sender, EventArgs e)
        {
            Telas.FrmInserirFolhaPagamento tela = new FrmInserirFolhaPagamento();
            tela.Show();
            Hide();
        }

        private void label64_Click(object sender, EventArgs e)
        {
            Telas.RH.FrmAlterarJornada tela = new RH.FrmAlterarJornada();
            tela.Show();
            Hide();
        }

        private void label63_Click(object sender, EventArgs e)
        {
            Telas. FrmDeletarJornada tela = new FrmDeletarJornada();
            tela.Show();
            Hide();
        }

        private void label62_Click(object sender, EventArgs e)
        {
            Telas.FrmConsultarFolhaPagamento tela = new FrmConsultarFolhaPagamento();
            tela.Show();
            Hide();
        }

        private void label60_Click(object sender, EventArgs e)
        {
            Telas.FrmDeletarFolhaPagamento tela = new FrmDeletarFolhaPagamento();
            tela.Show();
            Hide();
        }

        private void label59_Click(object sender, EventArgs e)
        {
            Telas.RH.FrmGeradorHoleride tela = new RH.FrmGeradorHoleride();
            tela.Show();
            Hide();
        }

        private void label67_Click(object sender, EventArgs e)
        {
            Telas.FrmConsultarSalario tela = new FrmConsultarSalario();
            tela.Show();
            Hide();
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void BoasVindas()
        {
            string wellcome = "Seja Bem-Vindo";

            string funcionario = DataBase.Entity.UsuarioLogadoModel.login.nm_usuario;

            string frase = wellcome + " " + funcionario;

            lblBoasVindas.Text = frase;
            lblBoasVindas.Visible = true;
        }

        private void panel3_Enter(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void label66_Click(object sender, EventArgs e)
        {
            Telas.Financeiro.FrmFluxoCaixa tela = new Financeiro.FrmFluxoCaixa();
            tela.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click_1(object sender, EventArgs e)
        {
            Telas.Financeiro.FrmFluxoCaixa tela = new Financeiro.FrmFluxoCaixa();
            tela.Show();
            Hide();
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {
            Telas.Fornecedor.FrmConsultaCNPJ tela = new Fornecedor.FrmConsultaCNPJ();
            tela.Show();
            Hide();
        }
    }
}
