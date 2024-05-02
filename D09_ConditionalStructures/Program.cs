using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D09_ConditionalStructures
{

    internal class Program
    {

        static void Main(string[] args)
        {
            
            Utility.SetUnicodeConsole();

            #region Variáveis
            int number = 0;
            int value01 = 1;
            int value02 = 2;
            bool result = true;
            #endregion

            #region If Simples
            Utility.WriteTitle("If Simples");

            if (number == 0)
            {
                Utility.WriteMessage("O número é 0.", endMessage: "\n\n");
            }

            if (number == 10)
            {
                Utility.WriteMessage("O número é 10.", endMessage: "\n\n");
            }
            #endregion

            #region If Else
            Utility.WriteTitle("If Else");

            if (number == 100)
            {
                Utility.WriteMessage("O número é igual a 100.", endMessage: "\n\n");
            }
            else
            {
                Utility.WriteMessage("O número é diferente de 100.", endMessage: "\n\n");
            }
            #endregion

            #region Operador Ternário
            Utility.WriteTitle("Operador Ternário");

            /* Clássico
            if (valor01 == valor02)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            */

            // Se 2 valores são iguais           
            result = value01 == value02 ? true : false;      // result = expression ? T : F

            Utility.WriteMessage(result.ToString(), "", "\n\n");
            #endregion

            #region Ifs Encadeados

            Utility.WriteTitle("Ifs encadeados");

            if (number == 0)
            {
                Utility.WriteMessage("O número é igual a 0", "", "\n\n");
            }
            else
            {
                if (number == 5)
                {
                    Utility.WriteMessage("O número é igual a 5", "", "\n\n");
                }
                else
                {
                    if (number == 10)
                    {
                        Utility.WriteMessage("O número é igual a 10", "", "\n\n");
                    }
                    else
                    {
                        if (number == 15)
                        {
                            Utility.WriteMessage("O número é igual a 15", "", "\n\n");
                        }
                        else
                        {
                            Utility.WriteMessage("O número não é: 0, 5, 10, 15", "", "\n\n");
                        }
                    }
                }

            }

            #endregion

            #region If ElseIf

            Utility.WriteTitle("If ElseIf");

            if (number == 0)
            {
                Utility.WriteMessage("O número é igual a 0", "", "\n\n");
            }
            else if (number == 5)
            {
                Utility.WriteMessage("O número é igual a 5", "", "\n\n");
            }
            else if (number == 10)
            {
                Utility.WriteMessage("O número é igual a 10", "", "\n\n");
            }
            else if (number == 15)
            {
                Utility.WriteMessage("O número é igual a 15", "", "\n\n");
            } 
            else
            {
                Utility.WriteMessage("O número não é: 0, 5, 10, 15", "", "\n\n");
            }

            #endregion

            #region Switch

            Utility.WriteTitle("Switch");

            switch (number)
            {
                case 0:
                    Utility.WriteMessage("O número é 0");
                    break;
                case 1:
                    Utility.WriteMessage("O número é um");
                    break;
                case 2:
                    Utility.WriteMessage("O número é dois");
                    break;
                case 3:
                    Utility.WriteMessage("O número é três");
                    break;
                case 4:
                    Utility.WriteMessage("O número é quatro");
                    break;
                case 5:
                    Utility.WriteMessage("O número é 5");
                    break;
                case 10:
                    Utility.WriteMessage("O número é 10");
                    break;
                case 15:
                    Utility.WriteMessage("O número é 15");
                    break;
                default:        // equivalente ao else do if
                    Utility.WriteMessage("O número não é: 0, 5, 10, 15");
                    break;
            }
            #endregion

            Utility.TerminateConsole();

        }

    }

}
