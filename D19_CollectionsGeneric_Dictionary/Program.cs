using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D19_CollectionsGeneric_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Dicionary: criar e carregar os valores iniciais

            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>()
            {
                { "PT" , "Portugal" },
                { "BR" , "Brasil" },
                { "ES" , "Espanha" },
                { "MZ" , "Moçambique" }
            };

            dictionaryCountries.Add("CV", "Cabo Verde");

            #endregion

            #region Dictionary: listar

            Utility.WriteTitle("Dictionary<string, string> - listagem 1");

            DictionaryUtility.ShowDictionary(dictionaryCountries);

            Utility.WriteMessage("\n");

            #endregion

            #region Dictionary: inserir um país se não existir e listar

            //string key = "AN";

            //if (DictionaryUtility.FindKey_v0(dictionaryCountries, key))
            //{
            //    //Utility.WriteMessage("País duplicado", "", "\n");
            //    DictionaryUtility.FindKey_v1(dictionaryCountries, key);
            //}
            //else
            //{
            //    string value = "Portugal";
            //    //string value = "Angola";

            //    DictionaryUtility.InsertDictionaryEntry(dictionaryCountries, key, value);

            //    Utility.WriteTitle("Dictionary<string, string> - listagem 2");

            //    DictionaryUtility.ShowDictionary(dictionaryCountries);
            //}

            string key = "PT";
            //string key = "AN";

            if (DictionaryUtility.FindKey(dictionaryCountries, key))
            {
                // {dictionaryCountry[key]} -> permite aceder ao valor da chave especificada
                Utility.WriteMessage($"País duplicado: {key} - {dictionaryCountries[key]}");
            }
            else
            {
                string value = "Portugal";
                //string value = "Angola";

                DictionaryUtility.InsertDictionaryEntry(dictionaryCountries, key, value);

                Utility.WriteTitle("Dictionary<string, string> - listagem 2");

                DictionaryUtility.ShowDictionary(dictionaryCountries);
            }

            #endregion

            Utility.TerminateConsole();
        }
    }
}
