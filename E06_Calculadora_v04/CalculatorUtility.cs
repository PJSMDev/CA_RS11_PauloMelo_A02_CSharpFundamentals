using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_Calculadora_v04
{
    internal class CalculatorUtility
    {
        internal string[] menu =
        {
            "Operações:",
            "+ -> Soma",
            "- -> Subtração",
            "* -> Multiplicação",
            "/ -> Divisão"
        };

        internal void DisplayMenu()
        {
            Utility.WriteTitle("Calculadora v04");
            foreach (string item in menu)
            {
                Utility.WriteMessage(item, "\n", "\n");
            }
            Utility.WriteMessage("\n");
        }

        // Tod MRS: Podes passasr este método para a Utility, porque de certeza que o podes reutilizar noutros projetos.
        internal void ClearCalculatorScreen()
        {
            Console.Clear();
        }
        
        // Todo MRS: Um método para escrever titles diferentes por operaçºao, não é muito útil.
        // Todo MRS: Porque é que não crias uma matriz com 3 colunas (em vez do vetor) e colocas lá os títtulos? Ou então, criar um vetor só com os títulos?
        internal void OperationTitle(string operation)
        {
            switch (operation)
            {
                case "+":
                    Utility.WriteTitle("Operação: Soma");
                    break;
                case "-":
                    Utility.WriteTitle("Operação: Subtração");
                    break;
                case "*":
                    Utility.WriteTitle("Operação: Multiplicação");
                    break;
                case "/":
                    Utility.WriteTitle("Operação: Divisão");
                    break;
                default:
                    break;
            }
        }
    }
}
