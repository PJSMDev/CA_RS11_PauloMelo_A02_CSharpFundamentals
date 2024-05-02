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

            Utility.WriteTitle("Calculadora");

            calculator.DisplayMenu();

            try
            {
                calculator.ReadValues();
            }
            catch (FormatException ex)
            {
                Utility.WriteMessage("Insira um número", "", "\n");
                //throw;
            }
            catch (DivideByZeroException)
            {
                Utility.WriteMessage("Divisão por zero. Impossível", "", "\n");
            }
            catch (Exception ex)
            {
                Utility.WriteMessage($"Erro: {ex.Message}", "", "\n");
            }
            //calculator.ReadValues();

            calculator.Calculation();
            calculator.PrintResult();

            Utility.TerminateConsole();
        }
    }
}
