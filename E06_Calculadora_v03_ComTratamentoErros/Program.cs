using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_Calculadora_v03_ComTratamentoErros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Calculator calculator = new Calculator();

            calculator.DisplayMenu();
            calculator.ReadValues();
            calculator.Calculation();
            calculator.PrintResult();

            Utility.TerminateConsole();
        }
    }
}
