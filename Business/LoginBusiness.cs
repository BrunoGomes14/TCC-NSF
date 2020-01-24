using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class LoginBusiness
    {
        public void CadastroUsuario(DataBase.Entity.tb_login usuario)
        {
            if (usuario.ft_usuario == null)
            {
                throw new ArgumentException("Escolha uma foto de perfil");
            }
            if (usuario.nm_usuario == null)
            {
                throw new ArgumentException("O campo usuário não pode estar vazio");
            }
            if (usuario.pw_senha == null)
            {
                throw new ArgumentException("O campo senha não pode estar vazio");
            }
            if (usuario.nm_dica == null)
            {
                throw new ArgumentException("O campo Dica não pode estar vazio");
            }
            if (usuario.nm_email == null)
            {
                throw new ArgumentException("O campo e-mail não pode estar vazio");
            }

            DataBase.LoginDatabase db = new DataBase.LoginDatabase();

            bool existe = db.ConsultarExistencia(usuario.nm_email);

            if (existe)
                throw new ArgumentException("E-mail já cadastrado");

           

            db.CadastroUsuario(usuario);
        }
        public byte[] ConsultarFoto(DataBase.Entity.tb_login usuario)
        {
            DataBase.LoginDatabase db = new DataBase.LoginDatabase();
            bool conf = db.ConsultarExistencia(usuario.nm_email);

            if (conf == false)
            {
                throw new ArgumentException("E-mail invalido");
            }

            byte[] img = db.ConsultarFotoUsuario(usuario);

            return img;
        }
        public void EfetuarLogin(DataBase.Entity.tb_login usuario)
        {
            DataBase.LoginDatabase db = new DataBase.LoginDatabase();

            bool existe = db.ConsultarExistencia(usuario.nm_email);

            DataBase.Entity.tb_login user = db.Consulta_email(usuario.nm_email);

            if (!existe)
            {
                throw new ArgumentException("E-mail inexistente no sistema");
            }

            DataBase.Entity.tb_login log = db.Consulta_email(usuario.nm_email);

            if (log.pw_senha == string.Empty)
            {
                throw new ArgumentException("O campo senha não pode estar vazio");
            }

            bool pass = false;

            if (usuario.pw_senha == log.pw_senha)
            {
                pass = true;
            }
            if(usuario.pw_senha != log.pw_senha)
            {
                throw new ArgumentException("Senha incorreta");
            }


            DataBase.Entity.UsuarioLogadoModel.login = user;


            if (pass == true)
            {
                Telas.Menus.FrmMenuTemporario tela = new Telas.Menus.FrmMenuTemporario();
                tela.BoasVindas();
                tela.Show();

            }
           


        }
        public string BuscarDica(string nome)
        {
            DataBase.LoginDatabase db = new DataBase.LoginDatabase();
            string dica = db.ConsultarDicaUsuario(nome);

            if(dica == string.Empty)
            {
                throw new ArgumentException("Usuário inexistente no sistema");

            }
            return dica;
        }
        
        public bool GerarCodigoRecuperarSenha(string usuario)
        {
            DataBase.LoginDatabase db = new DataBase.LoginDatabase();
            
            bool confere = db.ConsultarExistencia(usuario);


            if(confere == false)
            {
                throw new ArgumentException("Usuário inexistente no sistema");
            }
         
            Random rdn = new Random();
            int codigo = rdn.Next(1000, 9999);

            DataBase.Entity.tb_login mod  = db.Consulta_email(usuario);
            
            string frase =  string.Format("Olá, nós somos a Solutions of  Software, desenvolvedora do sistema para a Ótica Gambec, Esqueceu sua senha?🤔", Environment.NewLine);
            

            Gmail.GmailSender gmail = new Gmail.GmailSender();
            gmail.Enviar(mod.nm_email, "Recuperação de senha ", frase +
                                       " Seu código de recuperação é " + codigo + " .");

            bool certo = db.InserirCodigoRecuperacao(usuario, codigo);

            if (certo == false)
                throw new ArgumentException("Algo deu errado");

            return certo;
        }
        public bool ConferirCodigo(DataBase.Entity.tb_login usuario)
        {
            bool certo = false;

            DataBase.LoginDatabase db = new DataBase.LoginDatabase();
            DataBase.Entity.tb_login modelo = db.Consulta_email(usuario.nm_email);
            if(modelo.cd_recuperacao == string.Empty)
            {
                throw new ArgumentException("Nenhum código inserido");
            }
            if(usuario.cd_recuperacao == modelo.cd_recuperacao)
            {
                certo = true;
            }
            if (usuario.cd_recuperacao != modelo.cd_recuperacao)
            {
                throw new ArgumentException("Código incorreto");
            }
            if (usuario.cd_recuperacao == null)
            {
                throw new ArgumentException("Falha, por favor, tente novamente");
            }
            
            return certo;
        }
        public void AlterarSenha(DataBase.Entity.tb_login usuario)
        {
            DataBase.LoginDatabase db = new DataBase.LoginDatabase();

            DataBase.Entity.tb_login senha = db.Consulta_email(usuario.nm_email);
            
            if(senha.pw_senha == usuario.pw_senha)
            {
                throw new ArgumentException("Senha já foi usada ");
            }

            db.AlterarSenha(usuario);
        }
            
    }
}
