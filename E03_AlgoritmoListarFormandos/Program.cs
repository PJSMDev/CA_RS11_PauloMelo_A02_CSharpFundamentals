/*
    Ler o nome de 5 formandos da turma e listar no final
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E04_AlgoritmoTurma5Formandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            string[] students = new string[5];

            Utility.WriteMessage("Nome do formando 1: ");
            students[0] = Console.ReadLine();

            Utility.WriteMessage("Nome do formando 2: ");
            students[1] = Console.ReadLine();

            Utility.WriteMessage("Nome do formando 3: ");
            students[2] = Console.ReadLine();

            Utility.WriteMessage("Nome do formando 4: ");
            students[3] = Console.ReadLine();

            Utility.WriteMessage("Nome do formando 5: ");
            students[4] = Console.ReadLine();

            Utility.WriteMessage($"Turma:", "\n", "\n");

            for (int i = 0; i < students.Length; i++)
            {
                Utility.WriteMessage($"Formando {i + 1}: {students[i]}", "", "\n");
            }

            Utility.TerminateConsole();
        }
    }
}
