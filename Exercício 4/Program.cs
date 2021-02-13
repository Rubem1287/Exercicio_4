using System;
using System.Globalization;
namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double media = 0;

            double[] numeros;

            int n = int.Parse(Console.ReadLine());

            numeros = new double[n];

            string[] vetor = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {

                numeros[i] = double.Parse(vetor[i], CultureInfo.InvariantCulture);
                soma += numeros[i];
            }

            media = soma / n;

            Console.WriteLine();
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++)
            {
                if (numeros[i] <= media)
                {
                    Console.WriteLine(numeros[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}

