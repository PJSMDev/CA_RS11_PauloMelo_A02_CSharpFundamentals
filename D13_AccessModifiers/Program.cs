using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D13_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Instances
            User user01 = new User();
            User user02 = new User(1, "PJSM", "IT", DateTime.Today, "pjsm", "querty");
            #endregion

            user01.CreateUser();

            Utility.PauseConsole();

            user01.ListUser();

            user02.ListUser();

            Utility.TerminateConsole();
        }
    }
}
