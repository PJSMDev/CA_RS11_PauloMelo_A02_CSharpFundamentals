using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_Collections_Generic_List
{
    internal class CourseUtility
    {
        #region Methods
        /*
         * OVERLOADING
         * Em vez de termos métodos com nomes diferentes e objetivos iguais,
         * temos 1 método com o mesmo nome e assinaturas diferentes
         * 
         * internal static void ListDataIntegers(List<int> list) { }
         * 
         * internal static void ListDataStrings(List<string> list) { }
        */
        internal static void ListData(List<int> list)
        {
            foreach (int item in list)      // não posso usar var por causa do overloading
            {
                Utility.WriteMessage($"Integer: {item}", "", "\n");
            }
        }

        internal static void ListData(List<string> list)
        {
            foreach (string item in list)       // não posso usar var por causa do overloading
            {
                Utility.WriteMessage($"String: {item}", "", "\n");
            }
        }
        #endregion
    }
}
