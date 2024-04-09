using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class CaculaFibonacci
    {
        public void VerificaFibonacci(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                ImprimeResultado(true,numero);
                return;
            }

            int anterior = 0;
            int atual = 1;

            while (atual < numero)
            {
                int proximoNumero = anterior + atual;
                anterior = atual;
                atual = proximoNumero;
            }

            if (atual == numero)
            {
                ImprimeResultado(true, numero);
                return;
            }
         
            ImprimeResultado(false,numero);
        }

        private void ImprimeResultado(bool EhFibonacci, int numero)
        {
            if (EhFibonacci)
            {
                Console.WriteLine($"{numero} pertence à sequência!");
                return;
            }

            Console.WriteLine($"{numero} não pertence a sequencia!");
        }
    }
}

