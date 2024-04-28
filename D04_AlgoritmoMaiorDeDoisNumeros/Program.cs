/*
 Decidir qual de dois números é o maior, ou se são iguais
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D04_AlgoritmoMaiorDeDoisNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Algoritmo do Maior de 2 Números");

            double number1, number2;

            Utility.WriteMessage("Primeiro número : ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Segundo número: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            //  versão if
            //if (number1 > number2)
            //{
            //    Utility.WriteMessage("O primeiro número é maior", "", "\n");
            //}
            //else
            //{
            //    if (number2 > number1)
            //    {
            //        Utility.WriteMessage("O segundo número é maior", "", "\n");
            //    }
            //    else
            //    {
            //        Utility.WriteMessage("Os números são iguais");
            //    }
            //}

            // versão else if
            if (number1 > number2)
            {
                Utility.WriteMessage("O primeiro número é maior", "", "\n");
            }
            else if (number2 > number1) 
            {
                Utility.WriteMessage("O segundo número é maior", "", "\n");
            }
            else 
            {
                Utility.WriteMessage("Os números são iguais");
            }

            Utility.TerminateConsole();
        }
    }
}
