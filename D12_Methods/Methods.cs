using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Methods
{
    internal class Methods
    {
        #region Método void
        public void Procedure()
        {
            string message = "Procedimento: método void que não devolve valor";
            Utility.WriteMessage(message, "", "\n\n");
        }
        #endregion

        #region Método não void
        public int Function()
        {
            string message = "Função: método não void que devolve valor";
            Utility.WriteMessage(message, "", "\n\n");

            int v1, v2, res;

            v1 = 10;
            v2 = 20;
            res = v1 + v2;

            return res;
        }
        #endregion

        #region Método com parâmetros obrigatórios
        public void MethodRequiredParameters(string message01, string message02)
        {
            Utility.WriteMessage(message01, "", "\n");
            Utility.WriteMessage(message02, "", "\n\n");
        }
        #endregion

        #region Método com parâmetros opcionais
        // tem de receber 1 parâmetro e pode receber 2 parâmetros
        public void MethodOptionalParameters(string message01, string message02 = "Opcionais.")     // message01, string message02 = "")
        {
            Utility.WriteMessage(message01, "", "\n");
            Utility.WriteMessage(message02, "", "\n\n");
        }
        #endregion

        #region Método com parâmetro por valor
        public void PassingValues(int value)
        {
            value = 10;

            Utility.WriteMessage($"\n2. Valor dentro do método: {value}", "\n", "\n");        // 10
        }
        #endregion

        #region Método com parâmetro por referência
        public void PassingReferences(ref int value)
        {
            value = 10;     // mudar o valor implica mudar em todas as referências
            // uma única zona de memória (partilhada)

            Utility.WriteMessage($"1. Valor dentro do método: {value}", "", "\n\n");      // 10
        }
        #endregion

        #region Método de instância
        public void InstanceMethod()
        {
            Utility.WriteMessage("Um método de insância é chamado através de um objeto (instância) da classe", "", "\n\n");
        }
        #endregion

        #region Método estático
        public static void StaticMethod()
        {
            Utility.WriteMessage("Um método estático é chamado diretamente da classe.", "", "\n\n");
        }
        #endregion

        #region Sobrecarga de métodos (overloading)
        // ter um método com mais do que uma assinatura
        // é um método utilitário -> static
        public static void WriteNewMessage(string message)
        {
            message = message.ToUpper();

            Utility.WriteMessage(message, "", "\n");
        }

        // v2
        public static void WriteNewMessage(string message01, string message02)
        {
            message01 = message01.ToLower();
            message02 = message02.ToLower();

            Utility.WriteMessage($"{message01} {message02}", "", "\n");
        }
        #endregion
    }
}
