using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D18_CollectionsGeneric_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Stack (pilha - FILO)
            Stack<int> stackIntegers = new Stack<int>();
            
            stackIntegers.Push(0);
            stackIntegers.Push(1);
            
            for (int i = 2; i < 4; i++)
            {
                stackIntegers.Push(i);
            }
            
            Utility.WriteTitle("Push");
            
            foreach (int item in stackIntegers)
            {
                Utility.WriteMessage(item.ToString(), "\n");    // 3, 2, 1, 0
            }

            Utility.WriteMessage("\n\n");

            Utility.WriteTitle("Pop", "\n\n\n\n");
            
            int totalPilha = stackIntegers.Count; // 4
            
            for (int i = 0; i < totalPilha; i++)
            {
                Utility.WriteMessage($"{stackIntegers.Pop()}", "\n");  // 3, 2, 1, 0
            }
            #endregion
            Utility.TerminateConsole();
        }
    }
}
