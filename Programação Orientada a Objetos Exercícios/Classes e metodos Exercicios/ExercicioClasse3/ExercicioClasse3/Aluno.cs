using System;

namespace ExercicioClasse3
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalculoNota()
        {
            return Nota1 + Nota2 + Nota3;

        }

        public bool Avaliacao()
        {
            if (CalculoNota() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante() //necessariamente retorna valor, se aluno aprovado nn resta nota
        {  
            if (Avaliacao())
            {
                return 0.0;
            }
            else
            {
                return 60 - CalculoNota();
            }
        }
    }
}
