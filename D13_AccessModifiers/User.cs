using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using D00_Utility;

namespace D13_AccessModifiers
{
    internal class User     // --> se uma classe é internal, tudo dentro da classe também deve ser internal <--
    {
        /*
         * D13, criar a classe User:
         * 1 field para suportar a propriedade RegistrationDate
         *6 properties: Id, Name, Department, RegistrationDate (clássica),  Username e Password
         * 2 constructors
         * 2 methods: CreateUser e ListUser
        */
        #region Field
        private DateTime registrationDate;      // não usar _registrationDate -> deprecated!!!

        #endregion

        #region Properties (dados)
        internal int Id { get; }      // read-only

        internal string Name { get; set; }

        internal string Department { get; set; }

        internal DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }       // <- se fosse read-only, tirava isto
        }

        internal string Username { get; set; }

        internal string Password { get; set; }
        #endregion

        #region Constructors
        internal User() 
        {
            Id = 1;     // pq não vou conseguir atribuir-lhe um valor
            // os construtores é que vão lidar com a atribuição dos valores a fields read-only
            // usar valores anteriores como referência e incrementar
            Name = string.Empty;
            Department = string.Empty;
            // RegistrationDate = DateTime.MinValue;       // data vazia
            RegistrationDate = DateTime.Today;       // como DateTime.Now mas só para a data (e não a data e a hora)
            Username = string.Empty;
            Password = string.Empty;
        }

        internal User(int id, string name, string department, DateTime regDate, string userName, string password)
        {
            Id = id;
            Name = name;
            Department = department;
            RegistrationDate = regDate;
            Username = userName;
            Password = password;
        }
        #endregion

        #region Methods
        internal void CreateUser()
        {
            Utility.WriteTitle("Create User");

            Utility.WriteMessage("Name: ");
            Name = Console.ReadLine();

            Utility.WriteMessage("Department: ");
            Department = Console.ReadLine();

            Utility.WriteMessage("Data de registo (MM/DD/YYYY): ");
            while (!DateTime.TryParse(Console.ReadLine(), out registrationDate))    
            {
                Utility.WriteMessage("Data inválida. Tente novamente (MM/DD/YYYY): ");
            }

            Utility.WriteMessage("Username: ");
            Username = Console.ReadLine();

            Utility.WriteMessage("Password: ");
            Password = Console.ReadLine();
            Utility.WriteMessage("\n");
        }

        internal void ListUser(string beginTitle = "")
        {
            Utility.WriteTitle("List User", beginTitle);

            Utility.WriteMessage($"Person ID: {Id}", "", "\n");
            Utility.WriteMessage($"Name: {Name}", "", "\n");
            Utility.WriteMessage($"Department: {Department}", "", "\n");
            Utility.WriteMessage($"Registration date: {RegistrationDate}", "", "\n");
            Utility.WriteMessage($"Username: {Username}", "", "\n");
            //Utility.WriteMessage($"Password: {Password}", "", "\n");
            Utility.HidePassword(Password);
        }
        #endregion
    }
}
