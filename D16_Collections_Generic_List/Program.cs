using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_Collections_Generic_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<t> -> t: type

            Utility.SetUnicodeConsole();

            #region List<int>
            List<int> listIntegers = new List<int>();

            // Adicionar multi linhas em ciclo
            for (int i = 1; i < 3; i++)
            {
                listIntegers.Add(i);
            }

            // Adicionar 1 linha posteriormente com nº auto-incrementado -> 3
            listIntegers.Add(listIntegers.Count + 1);

            // Adicionar 1 linha posteriormente
            listIntegers.Add(4);

            Utility.WriteTitle("List<int>");

            CourseUtility.ListData(listIntegers);
            #endregion

            #region List<string>
            // List<string> listStrings = new List<string> { "a", "b", "c" };
            List<string> listStrings = new List<string>
            {
                "a",
                "b",
                "c"
            };

            // Adicionar 1 linha posteriormente
            listStrings.Add("d");

            Utility.WriteMessage("\n\n");

            Utility.WriteTitle("List<string>");

            CourseUtility.ListData(listStrings);
            #endregion

            Utility.WriteMessage("\n\n");

            #region List<Course>        // Course é uma classe, precisa ser instanciado
            // Adicionar multi linhas

            //// Sintaxe alternativa -> CORRIGIR ISTO
            //List<Course> listCourses = new List<Course>
            //{
            //course01 = new Course("C01", "DB", "Database Fundamentals");
            //course02 = new Course("C02", "DB", "Querying with SQL");
            //course03 = new Course("C03", "Dev", "C# Fundamentals");
            //course04 = new Course("C04", "Dev", "Data access with Entity Framework");
            //};

            List<Course> listCourses = new List<Course>();

            Course course01 = new Course("C01", "DB", "Database Fundamentals");
            Course course02 = new Course("C02", "DB", "Querying with SQL");
            Course course03 = new Course("C03", "Dev", "C# Fundamentals");
            Course course04 = new Course("C04", "Dev", "Data access with Entity Framework");

            listCourses.Add(course01);
            listCourses.Add(course02);
            listCourses.Add(course03);
            listCourses.Add(course04);

            Utility.WriteTitle("List<Course>");

            Course.ListCourse(listCourses);
            #endregion

            Utility.TerminateConsole();
        }
    }
}
