/*
    Inscrever um formando num curso 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E03_AlgoritmoInserirFormandoNoCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Variables

            string name, option;
            string[] courses = new string[3];

            courses[0] = "OOP";
            courses[1] = "Bases de dados";
            courses[2] = "Desenvolvimento web";

            Utility.WriteMessage("Nome: ");
            name = Console.ReadLine();

            Utility.WriteMessage($"Lista de Cursos:\n1 - {courses[0]}\n2 - {courses[1]}\n3 - {courses[2]}", "\n", "\n\n");

            Utility.WriteMessage("Selecione um curso: ");
            option = Console.ReadLine();

            #endregion

            #region Ifs Encadeados

            //if (option == "1")
            //{
            //    Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[0]}");
            //}
            //else
            //{
            //    if (option == "2")
            //    {
            //        Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[1]}");
            //    }
            //    else
            //    {
            //        if (option == "3")
            //        {
            //            Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[2]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Opção incorreta!");
            //        }
            //    }
            //}

            #endregion

            #region If ... Else If

            //if (option == "1")
            //{
            //    Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[0]}");
            //}
            //else if (option == "2")
            //{
            //    Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[1]}");
            //}
            //else if (option == "3")
            //{
            //    Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[2]}");
            //}
            //else
            //{
            //    Console.WriteLine("Opção incorreta!");
            //}

            #endregion

            #region Switch

            switch (option)
            {
                case "1":
                    Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[0]}");
                    break;
                case "2":
                    Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[1]}");
                    break;
                case "3":
                    Utility.WriteMessage($"Parabéns, {name}, estás inscrito(a) no curso: {courses[2]}");
                    break;
                default:
                    Console.WriteLine("Opção incorreta!");
                    break;
            }

            #endregion

            Utility.TerminateConsole();
        }
    }
}
