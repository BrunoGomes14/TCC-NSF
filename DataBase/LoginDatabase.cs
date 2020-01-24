using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class LoginDatabase
    {
        public void CadastroUsuario(DataBase.Entity.tb_login usuario)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            db.tb_login.Add(usuario);

            db.SaveChanges();
        }
        public Entity.tb_login Consulta_email(string nome)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

            DataBase.Entity.tb_login modelo = db.tb_login.FirstOrDefault(x => x.nm_email == nome);

            return modelo;
        }
        public byte[] ConsultarFotoUsuario(DataBase.Entity.tb_login usuario)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new DataBase.Entity.db_a4f62c_oticaEntities();

            byte[] img = (byte[])db.tb_login.FirstOrDefault(a => a.nm_email == usuario.nm_email).ft_usuario;

            if (img == null)
                throw new ArgumentException("Erro tente novamente.");

            return img;
        }
        public bool ConsultarExistencia(string nome)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            bool e = db.tb_login.Any(a => a.nm_email == nome);
            return e;
        }
        public string ConsultarDicaUsuario(string nome)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            string dica = db.tb_login.FirstOrDefault(x => x.nm_email == nome).nm_dica;
            return dica;
        }
        public void Alterar(DataBase.Entity.tb_login login)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_login usuario = db.tb_login.FirstOrDefault(x => x.nm_email == login.nm_email);

            usuario.nm_usuario = login.nm_usuario;
            usuario.pw_senha = login.pw_senha;
            usuario.tp_hierarquia = login.tp_hierarquia;
            usuario.cd_recuperacao = login.cd_recuperacao;
            usuario.ft_usuario = login.ft_usuario;
            usuario.nm_email = login.nm_email;


           

            db.SaveChanges();
        }
        public void Remover(Entity.tb_login login)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_login usuario = db.tb_login.FirstOrDefault(x => x.nm_email == login.nm_email);

            db.tb_login.Remove(usuario);
            db.SaveChanges();
        }
        public bool InserirCodigoRecuperacao(string usuario, int codigo)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

            Entity.tb_login modelo = db.tb_login.FirstOrDefault(x => x.nm_email == usuario);
            
            modelo.cd_recuperacao = Convert.ToString(codigo);

            db.SaveChanges();

            bool certo = true;

            return certo;
           
        }
        public string ConsultaCodigo(string usuario)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            string cod = db.tb_login.FirstOrDefault(x => x.nm_usuario == usuario).cd_recuperacao;
            return cod;
        }
        public void RemoverCdRecuperacao(string login)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_login usuario = db.tb_login.FirstOrDefault(x => x.nm_usuario == login);
            
            usuario.cd_recuperacao = null;
         
            db.SaveChanges();
        }
        public void AlterarSenha(DataBase.Entity.tb_login login)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_login usuario = db.tb_login.FirstOrDefault(x => x.nm_email == login.nm_email);
            
            usuario.pw_senha = login.pw_senha;

            db.SaveChanges();

            this.ApagarCodigoRecuperacao(login);
        }
        public string EmailFuncionario(Entity.tb_login log)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new DataBase.Entity.db_a4f62c_oticaEntities();
            string email = db.tb_login.FirstOrDefault(x => x.id_login == log.id_login).nm_usuario;

            return email;
        }
        public void ApagarCodigoRecuperacao(DataBase.Entity.tb_login login)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_login usuario = db.tb_login.FirstOrDefault(x => x.nm_email == login.nm_email);
            
            usuario.cd_recuperacao = null;
           
            db.SaveChanges();
        }
        public string ConsultaId(int id)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            string funcionario = db.tb_funcionario.FirstOrDefault(x => x.id_funcionario == id).nm_nome;
            return funcionario;
        }

    }
}
