using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class InverteString
    { 
        public void  InverteValorString(string valor)
        {
            var arrayValor = valor.ToCharArray();

            var lenght = arrayValor.Length-1;

            string novoArray = string.Empty;

            var indiceNovoArray = 0;
            for (int i = lenght; i >= 0; i--) 
            {
                var charAtual = arrayValor[i];

                 novoArray  = String.Concat(novoArray, " ", charAtual);
                 indiceNovoArray++;
            }
           
            Console.WriteLine($"string original: {valor} - String invertida: {novoArray}");
        }
    }
}
