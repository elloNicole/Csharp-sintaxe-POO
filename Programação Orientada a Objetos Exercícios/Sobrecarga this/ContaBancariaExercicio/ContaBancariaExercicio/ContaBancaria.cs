using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaExercicio
{
    internal class ContaBancaria
    {
        public string Nome {  get; set; }
        public int NumConta {  get; private set; }//numero da conta nao pode ser alterado
        public double Saldo { get; private set; }//saldo só pode ser alterado por meio de metodos


        public ContaBancaria(string nome, int numConta)
        {
            Nome = nome;
            NumConta = numConta; //atribui 0.0 p saldo
        }

        public ContaBancaria( string nome, int numConta, double depositoInicial) : this (nome, numConta)
        {
            Deposito(depositoInicial);//facilita atualizaçôes do metodo de deposito
        }

        public void Deposito (double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
            + NumConta
            + ", Titular "
            + Nome 
            + ", Saldo $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
