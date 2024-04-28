/*
    Verificar se uma pessoa é maior de idade
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_AlgoritmoMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            string name, age;

            Utility.WriteMessage("Nome: ");
            name = Console.ReadLine();

            Utility.WriteMessage("Idade: ");
            age = Console.ReadLine();

            if (Convert.ToInt16(age) >= 18)
            {
                Console.WriteLine($"Sim, {name}, és maior de idade.");
            }
            else
            {
                Console.WriteLine($"Não, {name}, não és maior de idade.");
            }

            Utility.TerminateConsole();
        }
    }
}
