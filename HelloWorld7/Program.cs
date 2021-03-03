using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld0
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 30;
            string nome = "Jorge Lucas";
            double saldo = 16.65423;

            //Placeholders: 
            // Colocar uma ordenação entre {} e depois mapear com as variáveis 
            Console.WriteLine("{0} tem {1} anos e recebe {2:F2}", nome, idade, saldo); // {2:F2} o 'F2' dentro do place holder indica que só vai mostrar 2 casas decimais

            //Inter polação:
            //Colocar o '$' antes das asplas dupla e indicar a variável entre {}
            Console.WriteLine($"{nome} tem {idade} anos e recebe {saldo:F2}");

            //Concatenação
            // colocar o '+' entre as variáveis e a String
            Console.WriteLine(nome + " tem " + idade + " anos e recebe " + saldo.ToString("F2")); //'ToString' é usado pra representar em forma textual, nesse caso limitando as cada decimais em 2

        }
    }
}
