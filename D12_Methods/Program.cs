using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Methods methods01 = new Methods();

            #region Método void
            Utility.WriteTitle("Procedure (método void)");

            methods01.Procedure();
            #endregion

            #region Método não void
            Utility.WriteTitle("Function (método não void)");

            // v1 
            //Utility.WriteMessage(methods01.Function().ToString(), "", "\n\n");
            //Utility.WriteMessage($"{methods01.Function()}", "", "\n\n");

            // v2 -> versão mais correta -> o res pode precisar ser reutilizado mais tarde
            int res;

            res = methods01.Function();

            Utility.WriteMessage(res.ToString());
            #endregion

            #region Método com parâmetros obrigatórios
            Utility.WriteTitle("Método com parâmetros obrigatórios");

            methods01.MethodRequiredParameters("Passagem de parâmetros.", "Obrigatórios.");
            #endregion

            #region Método com parâmetros opcionais
            Utility.WriteTitle("Método com parâmetros opcionais");

            methods01.MethodOptionalParameters("Passagem de parâmetros");
            #endregion

            #region Método com parâmetro por valor (default)
            Utility.WriteTitle("Método com parâmetro por valor");

            int value02 = 1;

            Utility.WriteMessage($"\n1. Valor antes do método: {value02}", "\n", "\n");        // 1

            methods01.PassingValues(value02);
            Utility.WriteMessage($"\n3. Valor antes do método: {value02}", "\n", "\n");        // 1
            #endregion

            #region Método com parâmetro por referência
            Utility.WriteTitle("Método com parâmetro por referência");

            methods01.PassingReferences(ref value02);

            Utility.WriteMessage($"2. Valor depois do método: {value02}", "", "\n\n");
            #endregion

            #region Método de instância
            Utility.WriteTitle("Método de instância.");

            // Chamar o método de instância
            Methods methods02 = new Methods();

            // já tenho uma instância deste método: methods02
            // o método está disponível através da instância do objeto
            methods02.InstanceMethod();
            #endregion

            #region Método estático
            Utility.WriteTitle("Método estático.");

            // não instanciei, invoquei diretamente
            // a classe tem de estar alcansável (using...)
            // Methods.StaticMethod(); é alcansável porque é public e está dentro da classe que estou a usar
            Methods.StaticMethod();
            #endregion

            #region Sobrecarga de métodos (overloading)
            // escrever métodos com mais do que uma versão/assinatura
            Utility.WriteTitle("Sobrecarga de métodos (overloading)");

            Methods.WriteNewMessage("Overloading de métodos");
            
            Methods.WriteNewMessage("1º overload");

            Methods.WriteNewMessage("2º", "OVERLOAD");
            #endregion

            Utility.TerminateConsole();
        }
    }
}
