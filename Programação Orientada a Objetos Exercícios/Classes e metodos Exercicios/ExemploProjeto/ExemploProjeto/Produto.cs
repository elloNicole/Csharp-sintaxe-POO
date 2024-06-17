using System;
using System.Globalization;


namespace ExemploProjeto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() //valor total calculo fica na classe
        {
            return Preco * Quantidade;//ao imprimir o metodo realiza o calculo

        }

        public void AdicionaProdutos(int quantidade) //apenas altera o valor da quantidade, por isso void; parametros em letra minuscula
        {
            Quantidade = Quantidade + quantidade; //ou +=
            return;
        }

        public void RemoveProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade; //ou -=
            return;
        }

        public override string ToString() //override operação veio de outra classe
        {
            return Nome //transforma classe em string 
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
