using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D02_AlgoritmoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Algoritmo da Média:");

            /*
            -----------------------------
            Declarar variáveis
            -----------------------------

            1. Declarar e atribuir simultaneamente
            string nome = "Milena";

            2. Primeiro declarar e depois atribuir
            string nome;
            nome = "Milena";
            */

            // 1. Declarar as variáveis
            string value01;
            int value02;
            double result;

            // 2. Pedir o primeiro valor
            // Namespace.Class
            // System.Console
            // System.Console.WriteLine()
            // System está a cinzento por causa do using System (redundante)
            Utility.WriteMessage("Número 1: ");
            value01 = Console.ReadLine();   // quando calcular a média vou ter de converter em valor numérico

            // 3. Pedir o segundo valor
            Utility.WriteMessage("Número 2: ");
            value02 = Convert.ToInt16(Console.ReadLine());   // vou ter de converter ao ler o valor

            // 4. Calcular a média
            // usado para ver os dois métodos
            result = (Convert.ToDouble(value01) + Convert.ToDouble(value02)) / 2;
            // para evitar a conversão implícita

            // 5. Mostrar o resultado
            Utility.WriteMessage($"Média: {result}");

            // 6. Pausar a consola
            Utility.TerminateConsole();
        }
    }
}
