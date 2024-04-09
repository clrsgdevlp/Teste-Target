using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fibonacci
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um número para saber se pertence a sequancia fibonacci");

            int numero = int.Parse(Console.ReadLine());

            var calculoFibonacci = new CaculaFibonacci();

            calculoFibonacci.VerificaFibonacci(numero);

           
        }
    }
}
