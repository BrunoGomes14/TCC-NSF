using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas.Fornecedor
{
    public partial class FrmConsultaCNPJ : Form
    {
        public DataBase.Entity.ModelEmpresa empresaConsultada;

        private Objetos_Auxiliares.ConsultaCNPJReceita consulta;

        public FrmConsultaCNPJ()
        {
            InitializeComponent();
            CarregaCaptcha();
        }
       

        private void frmConsultaCNPJ_Load(object sender, EventArgs e)
        {
            
        }

        private void CarregaCaptcha()
        {
            consulta = new Objetos_Auxiliares.ConsultaCNPJReceita();
            txtLetras.Text = "";
            txtLetras.Focus();
            // Cursor cursor;
            // cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            Bitmap bit = consulta.GetCaptcha();
            this.Cursor = Cursors.Arrow;
            if (bit != null)
            {
                picLetras.Image = bit;
            }
            else
            {
                MessageBox.Show("Não foi possível recuperar a imagem de validação do site da Receita Federal");
                // this.Cursor = cursor;
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            // Cursor cursor;
            //  cursor = this.Cursor;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string tmp = consulta.Consulta(txtCNPJ.Text, txtLetras.Text);
                if (tmp.Length > 0)
                {
                    empresaConsultada = new DataBase.Entity.ModelEmpresa();
                    //Empresa em si
                    empresaConsultada.Cnpj = txtCNPJ.Text;
                    empresaConsultada.RazaoSocial = RecuperaColunaValor(tmp, Coluna.RazaoSocial);
                    empresaConsultada.NomeFantasia = RecuperaColunaValor(tmp, Coluna.NomeFantasia);
                    empresaConsultada.NaturezaJuridica = RecuperaColunaValor(tmp, Coluna.NaturezaJuridica);
                    empresaConsultada.AtividadeEconomicaPrimaria = RecuperaColunaValor(tmp, Coluna.AtividadeEconomicaPrimaria);
                    empresaConsultada.AtividadeEconomicaSecundaria = RecuperaColunaValor(tmp, Coluna.AtividadeEconomicaSecundaria);
                    empresaConsultada.NumeroDaInscricao = RecuperaColunaValor(tmp, Coluna.NumeroDaInscricao);
                    empresaConsultada.MatrizFilial = RecuperaColunaValor(tmp, Coluna.MatrizFilial);
                    empresaConsultada.SituacaoCadastral = RecuperaColunaValor(tmp, Coluna.SituacaoCadastral);
                    empresaConsultada.DataSituacaoCadastral = RecuperaColunaValor(tmp, Coluna.DataSituacaoCadastral);
                    empresaConsultada.MotivoSituacaoCadastral = RecuperaColunaValor(tmp, Coluna.MotivoSituacaoCadastral);


                    //Endereço
                    empresaConsultada.Endereco = RecuperaColunaValor(tmp, Coluna.Endereco);
                    empresaConsultada.Numero = RecuperaColunaValor(tmp, Coluna.Numero);
                    empresaConsultada.Bairro = RecuperaColunaValor(tmp, Coluna.Bairro);
                    empresaConsultada.Cidade = RecuperaColunaValor(tmp, Coluna.Cidade);
                    empresaConsultada.CEP = RecuperaColunaValor(tmp, Coluna.CEP);
                    empresaConsultada.UF = RecuperaColunaValor(tmp, Coluna.UF);
                    empresaConsultada.Complemento = RecuperaColunaValor(tmp, Coluna.Complemento);


                    //Contato
                    //empresaConsultada.MotivoSituacaoCadastral = RecuperaColunaValor(tmp, Coluna.);

                    empresaConsultada.Cnae = RecuperaColunaValor(tmp, Coluna.AtividadeEconomicaPrimaria);

                    CarregaDadosNoFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CarregaCaptcha();
            }
            // this.Cursor = cursor;
        }
        private void CarregaDadosNoFormulario()
        {

            txtRazao.Text = empresaConsultada.RazaoSocial;
            txtFantasia.Text = empresaConsultada.NomeFantasia;
            txtAtividadeEconomeica.Text = empresaConsultada.AtividadeEconomicaPrimaria;
            txtAtividadeEconomicaSecundaria.Text = empresaConsultada.AtividadeEconomicaSecundaria;
            txtNaturezaJuridica.Text = empresaConsultada.NaturezaJuridica;

            //Datas
            txtDataSituacaoCadastral.Text = empresaConsultada.DataSituacaoCadastral;

            //Situações
            txtSituacaoCadastral.Text = empresaConsultada.SituacaoCadastral;
      
            //txtSituacaoEspecial.Text = empresaConsultada.AtividadeEconomicaPrimaria;


            //Endereco
            txtLogradouro.Text = empresaConsultada.Endereco;
            txtBairro.Text = empresaConsultada.AtividadeEconomicaPrimaria;
            txtCidade.Text = empresaConsultada.AtividadeEconomicaPrimaria;
            txtUF.Text = empresaConsultada.Endereco;
            txtCEP.Text = empresaConsultada.AtividadeEconomicaPrimaria;
            txtComplemento.Text = empresaConsultada.Endereco;

            /*   empresaConsultada.Cnpj = txtCNPJ.Text;
                                empresaConsultada.RazaoSocial = RecuperaColunaValor(tmp, Coluna.RazaoSocial);
                                empresaConsultada.NomeFantasia = RecuperaColunaValor(tmp, Coluna.NomeFantasia);
                                empresaConsultada.NaturezaJuridica = RecuperaColunaValor(tmp, Coluna.NaturezaJuridica);
                                empresaConsultada.AtividadeEconomicaPrimaria = RecuperaColunaValor(tmp, Coluna.AtividadeEconomicaPrimaria);
                                empresaConsultada.AtividadeEconomicaSecundaria = RecuperaColunaValor(tmp, Coluna.AtividadeEconomicaSecundaria);
                                empresaConsultada.NumeroDaInscricao = RecuperaColunaValor(tmp, Coluna.NumeroDaInscricao);
                                empresaConsultada.MatrizFilial = RecuperaColunaValor(tmp, Coluna.MatrizFilial);
                                empresaConsultada.SituacaoCadastral = RecuperaColunaValor(tmp, Coluna.SituacaoCadastral);
                                empresaConsultada.DataSituacaoCadastral = RecuperaColunaValor(tmp, Coluna.DataSituacaoCadastral);
                                empresaConsultada.MotivoSituacaoCadastral = RecuperaColunaValor(tmp, Coluna.MotivoSituacaoCadastral);


                                //Endereço
                                empresaConsultada.Endereco = RecuperaColunaValor(tmp, Coluna.Endereco);
                                empresaConsultada.Numero = RecuperaColunaValor(tmp, Coluna.Numero);
                                empresaConsultada.Bairro = RecuperaColunaValor(tmp, Coluna.Bairro);
                                empresaConsultada.Cidade = RecuperaColunaValor(tmp, Coluna.Cidade);
                                empresaConsultada.CEP = RecuperaColunaValor(tmp, Coluna.CEP);
                                empresaConsultada.UF = RecuperaColunaValor(tmp, Coluna.UF);
                                empresaConsultada.Complemento = RecuperaColunaValor(tmp, Coluna.Complemento);                 
                                */


        }

        private enum Coluna
        {
            RazaoSocial = 0,
            NomeFantasia,
            AtividadeEconomicaPrimaria,
            AtividadeEconomicaSecundaria,

            NumeroDaInscricao,
            MatrizFilial,
            NaturezaJuridica,

            SituacaoCadastral,
            DataSituacaoCadastral,
            MotivoSituacaoCadastral,

            Endereco,
            Numero,
            Bairro,
            Cidade,
            UF,
            Complemento,
            CEP

        }

        private String RecuperaColunaValor(String pattern, Coluna col)
        {
            String S = pattern.Replace("\n", "").Replace("\t", "").Replace("\r", "");

            switch (col)
            {
                case Coluna.RazaoSocial:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NOME EMPRESARIAL -->", "<!-- Fim Linha NOME EMPRESARIAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NomeFantasia:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ESTABELECIMENTO -->", "<!-- Fim Linha ESTABELECIMENTO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NaturezaJuridica:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NATUREZA JURÍDICA -->", "<!-- Fim Linha NATUREZA JURÍDICA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.AtividadeEconomicaPrimaria:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ATIVIDADE ECONOMICA -->", "<!-- Fim Linha ATIVIDADE ECONOMICA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.AtividadeEconomicaSecundaria:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ATIVIDADE ECONOMICA SECUNDARIA-->", "<!-- Fim Linha ATIVIDADE ECONOMICA SECUNDARIA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NumeroDaInscricao:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.MatrizFilial:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.Endereco:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.Numero:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.Complemento:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.CEP:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.Bairro:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.Cidade:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.UF:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.SituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.DataSituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.MotivoSituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha MOTIVO DE SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha MOTIVO DE SITUAÇÃO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }

                default:
                    {
                        return S;
                    }
            }
        }

        private String StringEntreString(String Str, String StrInicio, String StrFinal)
        {
            int Ini;
            int Fim;
            int Diff;
            Ini = Str.IndexOf(StrInicio);
            Fim = Str.IndexOf(StrFinal);
            if (Ini > 0) Ini = Ini + StrInicio.Length;
            if (Fim > 0) Fim = Fim + StrFinal.Length;
            Diff = ((Fim - Ini) - StrFinal.Length);
            if ((Fim > Ini) && (Diff > 0))
                return Str.Substring(Ini, Diff);
            else
                return "";
        }

        private String StringSaltaString(String Str, String StrInicio)
        {
            int Ini;
            Ini = Str.IndexOf(StrInicio);
            if (Ini > 0)
            {
                Ini = Ini + StrInicio.Length;
                return Str.Substring(Ini);
            }
            else
                return Str;
        }

        public string StringPrimeiraLetraMaiuscula(String Str)
        {
            string StrResult = "";
            if (Str.Length > 0)
            {
                StrResult += Str.Substring(0, 1).ToUpper();
                StrResult += Str.Substring(1, Str.Length - 1).ToLower();
            }
            return StrResult;
        }

        private void FrmConsultaCNPJ_Load_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Menus.FrmMenuTemporario telas = new Menus.FrmMenuTemporario();
            telas.Show();
            Hide();
        }
    }
    

}
