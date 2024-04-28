// Namespaces
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

// Comentário de uma só linha

/*
    Bloco de comentários
    Bloco de comentários
    Bloco de comentários
*/

// A minha namespace
namespace D01_VisualStudio
{
    // Classe Program
    internal class Program
    {
        // Método Main(): entry point
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Média:");

            // 1. Declarar as variáveis
            double value01, value02, result;

            // 2. Pedir o primeiro valor
            Utility.WriteMessage("Primeiro valor: ");
            value01 = Convert.ToDouble(Console.ReadLine());

            // 3. Pedir o segundo valor
            Utility.WriteMessage("Segundo valor: ");
            value02 = Convert.ToDouble(Console.ReadLine());

            // 4. Calcular a média
            result = (value01 + value02) / 2;

            // 5. Mostrar o resultado
            Utility.WriteMessage($"Média dos valores {value01} e {value02}: {result}", "\n");

            // 6. Pausar a consola
            Utility.TerminateConsole();
        }
    }
}
