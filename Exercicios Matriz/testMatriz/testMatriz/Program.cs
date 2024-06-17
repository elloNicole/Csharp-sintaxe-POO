using System;

namespace testMAtriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //quantidade total de espaços
            Console.WriteLine(mat.Rank); //quantidade de linhas, primeira dimensao, primeiro termo
            Console.WriteLine(mat.GetLength); //funcao de dimensao
            Console.WriteLine(mat.GetLength(0)); //dimensão 1 linha
            Console.WriteLine(mat.GetLength(1)); //dimensão 2 coluna
        }
    }
}