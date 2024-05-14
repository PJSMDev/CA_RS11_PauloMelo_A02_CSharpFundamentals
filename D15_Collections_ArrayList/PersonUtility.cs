using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class PersonUtility
    {
        #region Methods
        // Método para listar as coleções (que não de Person)
        internal static void ListData(ArrayList list)        // nomes dos métodos deve dar a ideia de ação
        {
            foreach (var item in list)      // tem de usar var porque não sei o tipo do elemento a listar
            {
                Utility.WriteMessage($"{item}", "", "\n");
            }
        }

        #endregion
    }
}
