using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D08_DataTypesManipulation
{

    internal class Program
    {
    
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variáveis

            #region Strings
            string area = "Informática";
            string category = "Linguagens de programação";
            string course = "C# Foundations";
            string completeCourse00;     // +
            string completeCourse01;     // string interpolation
            string completeCourse02;     // string.join
            string completeCourse03;     // string.concat
            string completeCourse05;     // string.format
            StringBuilder completeCourse04 = new StringBuilder();
            // é uma classe -> APPEND()
            #endregion

            #region Numbers
            int value01 = 10;
            int value02 = 100;
            double value03 = 2.3;
            double value04 = -12.1;
            double value05 = 64;
            double value06 = 4;
            #endregion
            
            #region Datetime
            DateTime timestamp = DateTime.Now;
            #endregion

            #endregion

            #region Manipulação de strings

            #region Clássico: evitar se houver concatenação de strings nas variáveis
            // Operador + -> NÃO USAR -> STRING É UM OBJETO
            // GERA MAIS OBJETOS EM VEZ DE CONCATENAR
            completeCourse00 = area + ", " + category + ", " + course;

            // String interpolation
            completeCourse01 = $"{area}, {category}, {course}";

            // string.Concat()
            completeCourse03 = string.Concat(area, " - ", category, ", ", course);   // T-SQL Concat()
            
            // string.Join()
            completeCourse02 = string.Join(", ", area, category, course);            // T-SQL Concat_Ws()

            // string.Format()
            completeCourse05 = string.Format("Curso completo: {0} - {1},  {2}", area, category, course);
            //  Zero based como os arrays
            #endregion

            #region Ótima - classe StringBuilder
            completeCourse04.Append(area);
            completeCourse04.Append("\t");
            completeCourse04.Append(category);
            completeCourse04.Append("\t");
            completeCourse04.Append(course);
            #endregion

            #region Mostrar na consola
            Utility.WriteTitle("manipulação de strings");
            Utility.WriteMessage($"Maiúsculas: {completeCourse01.ToUpper()}");
            Utility.WriteMessage($"Minúsculas: {completeCourse02.ToLower()}", "\n");
            Utility.WriteMessage($"Esquerda (fixo): {completeCourse03.Substring(0, 11)}", "\n");        // Left; Informática
            Utility.WriteMessage($"Esquerda (dinâmico): {completeCourse02.Substring(0, completeCourse02.IndexOf(","))}", "\n");
            Utility.WriteMessage($"Curso completo: {completeCourse05}", "\n", "\n\n");
            #endregion

            #endregion

            #region Manipulação de numbers
            Utility.WriteTitle("Manipulação de numbers");
            Utility.WriteMessage($"Mínimo: {Math.Min(value01, value02)}");
            Utility.WriteMessage($"Máximo: {Math.Max(value01, value02)}", "\n");
            Utility.WriteMessage($"Absoluto: {Math.Abs(value04)}", "\n");
            Utility.WriteMessage($"Arredondamento: {Math.Round(value03)}", "\n");
            Utility.WriteMessage($"Raíz quadrada: {Math.Sqrt(value06)}", "\n", "\n\n");

            #endregion

            #region Manipulação de datetime
            Utility.WriteTitle("Manipulação de datetime");
            Utility.WriteMessage($"Minutos + 10: {timestamp.AddMinutes(10).Minute}");
            Utility.WriteMessage($"Próxima hora: {timestamp.AddHours(1).Hour}", "\n");
            #endregion

            Utility.TerminateConsole();

        }

    }

}
