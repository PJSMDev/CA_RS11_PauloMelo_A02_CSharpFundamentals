using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D14_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Error handling");

            #region Sem tratamento de erros
            //int number01;

            //Utility.WriteMessage("Número: ");
            //number01 = Convert.ToInt16(Console.ReadLine());
            #endregion

            #region Com tratamento de erros
            try        // snippet -> Tab Tab
            {
                int number02;

                Utility.WriteMessage("Número: ");
                number02 = Convert.ToInt16(Console.ReadLine());
            }
            catch (DivideByZeroException)
            {
                Utility.WriteMessage("Não podes dividir por 0", "", "\n");
            }
            catch (FormatException ex)
            {
                Utility.WriteMessage("Escreve um número", "", "\n");
            }
            catch (Exception ex)        // variável do tipo Exception (ex -> nome standard)
            {
                #region Versão de desenolvimento
                Utility.WriteMessage($"Erro: {ex.Message}", "\n");        // imprime o erro sem ter de fazer throw (terminar)
                //throw;        // lançar o erro e interrompe a execução
                #endregion

                #region Versão de produção (devemos implementar um sistema de logs)
                //Utility.WriteMessage("Aconteceu um erro", "", "\n");        
                #endregion
            }
            // os catchs têm de estar em linhas consecutivas (sem \n's)
            // usar os catchs mais específicos em cima
            // usar o catch mais geral em baixo (catch all)
            finally     // é opcional mas se existir é SEMPRE executado
            {
                Utility.WriteMessage("Terminei!", "", "\n"); 
            }
            // útil para usar em DataBases para a fechar, quer dê erro, ou não

            // event viewer do Windows -> permite ver os eventos que estão a acontecer no PC
            // Windows -> Event Viewer
            #endregion

            Utility.TerminateConsole();
        }
    }
}
