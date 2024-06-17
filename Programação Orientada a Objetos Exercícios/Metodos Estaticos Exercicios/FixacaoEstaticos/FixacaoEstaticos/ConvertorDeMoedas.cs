using System;


namespace FixacaoEstaticos
{
    internal class ConvertorDeMoedas
    {
        public static double taxa = 6.0; //6%
        public static double ValorPago(double cot, double dol)
        {
            double total = cot * dol;
            return total + total * 6.0 / 100;

        }
    }
}
