using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora v1
            #region Console Unicode
            Utility.SetUnicodeConsole();
            #endregion

            #region Variables
            double operand1, operand2, result = 0;
            string mathSymbol;
            #endregion

            Utility.WriteTitle("Calculadora");

            #region Prompt
            Utility.WriteMessage("Primeiro valor: ", "", "\n");
            operand1 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Operação matemática: ", "", "\n");
            mathSymbol = Console.ReadLine();

            Utility.WriteMessage("Segundo valor: ", "", "\n");
            operand2 = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Switch
            switch (mathSymbol)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Utility.WriteMessage("Impossível");
                        break;
                    }
                    result = operand1 / operand2;
                    break;
                default:
                    Utility.WriteMessage("Operação inválida");
                    break;
            }

            Utility.WriteMessage($"{operand1}{mathSymbol}{operand2} = {result}");
            #endregion

            Utility.TerminateConsole();

        }
    }
}
