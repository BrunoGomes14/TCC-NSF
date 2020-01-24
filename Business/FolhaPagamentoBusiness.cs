using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class FolhaPagamentoBusiness
    { 
        public decimal CalcularInss(decimal salario)
        {
            decimal pocentagemINSS = 0;

            if (salario <= 1751.81m)
            {
                pocentagemINSS = 0.08m;
            }
            if (salario > 1751.81m && salario < 2919.72m)
            {
                pocentagemINSS = 0.09m; 
            }
            if (salario > 2919.73m && salario < 5839.45m)
            {
                pocentagemINSS = 0.11m;
            }
            if (salario >= 5839.46m)
            {
                pocentagemINSS = 0.15m;
            }

            decimal calculoInss = Math.Round(salario * pocentagemINSS, 2);

            return calculoInss;
        }
        public decimal HoraExtra50(decimal salario, decimal HoraExtraTrabalhada)
        {
            decimal ValorHoraTrabalhado = salario / 220;
            decimal ValorHoraExtra = ValorHoraTrabalhado * 1.5m;
            decimal ValorTotal = Math.Round(ValorHoraExtra * HoraExtraTrabalhada, 2);

            return ValorTotal;
        }
        public decimal HoraExtra100(decimal salario, decimal HoraExtraTrabalhada)
        {
            decimal ValorHoraTrabalhado = salario / 220;
            decimal ValorHoraExtra = ValorHoraTrabalhado * 2;
            decimal ValorTotal = ValorHoraExtra * HoraExtraTrabalhada;

            return ValorTotal;
        }
        public decimal CalculoVT(decimal salario)
        {
            decimal desconto = Math.Round(salario * 0.06m, 2);
            return desconto;
        }
        public decimal DSR(decimal salario, int DiasUteis, int DomingoFeriados)
        {
            decimal ValorHoraTrabalhado = salario / 220;
            decimal conta = ((220 * DiasUteis) * DomingoFeriados);
            decimal total = conta * ValorHoraTrabalhado;

            return total;
        }
        public List<DataBase.Entity.tb_funcionario> ConsultarFuncionarios()
        {
            DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
            List<DataBase.Entity.tb_funcionario> mod = db.ListarTodos();
            return mod;
        }
        public decimal ConsultarSalarioFuncionario(int funcionario)
        {
            DataBase.FolhaPagamentoDatabase db = new DataBase.FolhaPagamentoDatabase();
           decimal salario  = db.SalarioFuncionario(funcionario);
            return salario;
        }
        public decimal ConsultaSalario(int fun)
        {
            DataBase.FolhaPagamentoDatabase db = new DataBase.FolhaPagamentoDatabase();
            bool existe = db.VerficarExistencia(fun);

            if (!existe)
                throw new ArgumentException("Salário do funcionário não encontrado");

            decimal salario = db.SalarioFuncionario(fun);


            return salario;
        }
        public int Faltas(int id, DateTime mes)
        {
            DataBase.FolhaPagamentoDatabase db = new DataBase.FolhaPagamentoDatabase();
            int falt = db.FaltasFuncionario(id, mes);

            return falt;
        }
        public decimal DescontoFalta(int qtdfalta, decimal salario)
        {
             int qtddiastrab = 30;

            decimal conta = (salario / qtddiastrab) * qtdfalta;
            decimal descontoDSR = salario / qtddiastrab;

            if (qtdfalta == 0)
                descontoDSR = 0;

            decimal totdesc = Math.Round(conta + descontoDSR, 2);

            return totdesc;
        }
        public decimal SalarioFamilia(decimal salario, int id )
        {
            DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();
           DataBase.Entity.tb_funcionario md = db.FuncionarioId(id);

            bool direito = false;
            decimal salariofamilia = 0.00m;

            if(md.nr_dependentes > 1)
            {
                direito = true;
            }
            if(salario <= 907.77m && direito == true)
            {
                salariofamilia = 46.54m;
            }
            if(salario > 907.77m && salario <= 1364.43m && direito == true)
            {
                salariofamilia = 32.80m;
            }
            if (salariofamilia > 1364.43m && direito == true)
            {
                salariofamilia = 0.00m;
            }

            return salariofamilia;
        }

        public decimal CalculoIR(decimal salario)
        {
            decimal descontoIR = 0;

            if(salario <= 1903.98m )
            {
                descontoIR = 0;
            }
            if (salario >= 1903.99m && salario <= 2826.65m)
            {
                descontoIR = 142.80m;
            }
            if (salario >= 2826.66m && salario <= 3751.05m)
            {
                descontoIR = 354.80m;
            }
            if(salario >= 3751.06m && salario <= 4664.68m)
            {
                descontoIR = 636.13m;
            }
            if(salario > 4664.68m)
            {
                descontoIR = 869.36m;
            }

            return descontoIR;
        }
        public void Salvar(DataBase.Entity.tb_folha_pagamento folha)
        {
            if (folha == null)
                throw new ArgumentException("Funcionario não selecionado");

            DataBase.FolhaPagamentoDatabase db = new DataBase.FolhaPagamentoDatabase();
            bool existe = db.ConsultarExistenciaDeFolha(folha);

            if (existe)
                throw new ArgumentException("Folha já cadastrada");

            db.InserirFolhaDePagamento(folha);

        }
    }
}
