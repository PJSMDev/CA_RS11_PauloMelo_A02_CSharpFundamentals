using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_Calculadora_v04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            CalculatorUtility calculatorUtilities = new CalculatorUtility();
            Calculator calculator = new Calculator();

            calculatorUtilities.DisplayMenu();

            // Todo MRS: Try encadeados? Porquê?
            try
            {
                calculator.ReadOperation();

                calculatorUtilities.ClearCalculatorScreen();

                while (true)
                {
                    try
                    {
                        calculatorUtilities.OperationTitle(calculator.Operator);

                        calculator.ReadValues();

                        calculator.Calculation();

                        calculator.PrintResult();
                        break;
                    }
                    catch (FormatException)
                    {
                        calculator.NumericFormatError();
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.WriteMessage($"Erro: {ex.Message}\n");
            }

            Utility.TerminateConsole();
        }
    }
}
