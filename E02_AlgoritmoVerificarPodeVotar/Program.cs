/*
    Verificar se uma pessoa pode votar 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E02_AlgoritmoVotacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            string name, age;
            bool isRegistered;

            Utility.WriteMessage("Nome: ");
            name = Console.ReadLine();

            Utility.WriteMessage("Idade: ");
            age = Console.ReadLine();

            Console.Write("Recenseamento completo: (true/false) ");
            isRegistered = Convert.ToBoolean(Console.ReadLine());

            if (Convert.ToInt16(age) >= 18 && isRegistered)
            {
                Console.WriteLine($"Sim, {name}, podes votar.");
            }
            else 
            {
                Console.WriteLine($"Não, {name} , não podes votar.");
            }

            Utility.TerminateConsole();
        }
    }
}
