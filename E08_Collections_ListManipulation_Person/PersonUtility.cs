using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E08_Collections_ListManipulation_Person
{
    internal class PersonUtility
    {
        #region Methods

        #region Menu
        internal static void ShowMenu()
        {
            Utility.WriteMessage("1. Add person", "", "\n");
            Utility.WriteMessage("2. Insert person in position", "", "\n");
            Utility.WriteMessage("3. Find person by id", "", "\n");
            Utility.WriteMessage("4. Remove person by id", "", "\n");
            Utility.WriteMessage("5. Sort list by id", "", "\n");
            Utility.WriteMessage("6. Sort list by name", "", "\n");
            Utility.WriteMessage("7. List person", "", "\n");
            Utility.WriteMessage("8. Exit", "", "\n");
            Utility.WriteMessage(">  ", "\n");
        }

        #endregion

        #region Try Parse Switch Option

        internal static bool TryParseOption(string input, out int option)
        {
            return int.TryParse(input, out option);
        }

        #endregion

        #region Validate Switch Option

        internal static bool ValidateSwitchOption(int option)
        {
            return option >= 1 && option <= 8;
        }

        #endregion

        #endregion

    }
}