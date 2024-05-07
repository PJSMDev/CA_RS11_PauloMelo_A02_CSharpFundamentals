using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_Calculadora_v03_ComTratamentoErros
{
    internal class Calculator
    {
        //A gestão de erros têm de estar do lado da Progam. Métodos não geram erros a menos que sirvam exclusivamente para isso
        internal string[] menu =
        {
            "+  Soma",
            "-  Subtração",
            "*  Multiplicação",
            "/  Divisão"
        };

        internal double Value1 { get; set; }
        internal double Value2 { get; set; }
        internal double Result { get; set; }
        internal string Operator { get; set; }


        internal void DisplayMenu()
        {
            Utility.WriteTitle("Calculadora com tratamento de erros");
            foreach (string item in menu)
            {
                Utility.WriteMessage(item, "", "\n");
            }
        }

        internal void ReadValues()
        {
            Utility.WriteMessage("Valor 1: ");
            Value1 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Operação matemática: ");
            Operator = Console.ReadLine();

            Utility.WriteMessage("Value 2: ");
            Value2 = Convert.ToDouble(Console.ReadLine());
        }

        internal void Calculation()
        {
            switch (Operator)
            {
                case "+":
                    Add();
                    break;
                case "-":
                    Sub();
                    break;
                case "*":
                    Mult();
                    break;
                case "/":
                    Div();
                    break;
                default:
                    break;
            }
        }

        internal void Add()
        {
            Result = Value1 + Value2;
        }

        internal void Sub()
        {
            Result = Value1 - Value2;
        }

        internal void Mult()
        {
            Result = Value1 * Value2;
        }

        internal void Div()
        {
            Result = Value1 / Value2;
        }

        internal void PrintResult()
        {
            Utility.WriteMessage($"{Value1} {Operator} {Value2} = {Result}");
        }
    }
}
