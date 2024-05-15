using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D19_CollectionsGeneric_Dictionary
{
    internal class DictionaryUtility
    {
        #region Methods

        internal static void ShowDictionary(Dictionary<string, string> dictionary)
        {
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Utility.WriteMessage($"Country: {item.Key} - {item.Value}", "", "\n");
            }
        }

        internal static bool FindKey_v0(Dictionary<string, string> dictionary, string key)
        {
            return dictionary.ContainsKey(key);
        }

        internal static void InsertDictionaryEntry(Dictionary<string, string> dictionary, string key, string value)
        {
            dictionary.Add(key, value);
        }

        // se existir Aparece País duplicado e a chave e o País
        internal static bool FindKey(Dictionary<string, string> dictionary, string key)
        {
            return dictionary.TryGetValue(key, out string value);
        }

        #endregion
    }
}
