using System;
using System.Collections;
using D00_Utility;

namespace E07_PersonList
{
    internal class PersonUtility
    {
        #region Methods
        internal static void ListData(ArrayList list)
        {
            foreach (Person person in list)
            {
                Utility.WriteMessage($"ID: {person.ID}, Name: {person.Name}", "", "\n");
            }
        }
        #endregion
    }
}
