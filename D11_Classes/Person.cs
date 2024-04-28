/*
CLASS ELEMENTS:
        Attributes or fields    = variáveis privadas da classe (suporte às propriedades)
        Properties              = caraterísticas
        Methods                 = funcionalidades
        Constructors            = funcionalidade invocada aquando da criação do objeto
        Destructor              = funcionalidade que permite indicar como é que o objeto é destruído
EXEMPLO:
        Classe: Produto
        Objects (instâncias da classe): Produto1, Produto2, Produto3...
        Properties: Nome, Cor, Unidade, ...
        Methods: Inserir, Pesquisar, Editar, Apagar, ...
        Constructor: Cor = verde
        Destructor (log): informar que o objeto vai ser destruído
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_Classes
{
    internal class Person
    {
        #region Fields (variáveis privadas das propriedades)
        // ver Classic properties
        // para uso exclusivo das variáveis das propriedades
        private string city, country, address;

        #endregion

        #region Properties

        #region Auto-implemented properties 2.0
        // método a usar mais habitualmente
        // usar snippet (prop -> Tab,Tab)
        public int Id { get; set; }     // é uma Id numérica, como nas bases de dados      
        public string Name { get; set; }
        public string Phone { get; set; }       // não vai ser usado em cálculos -> string
        public string NIF { get; set; }
        #endregion

        #region Classic properties 1.0 (public ou internal)
        // usam o conceito de field
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }       // responsável por ler o valor da propriedade
            // precisa de fields
            set { city = value; }     // responsável por escrever o valor da propriedade
        }
        #endregion

        #region Bodied-expression properties 3.0
        // usam o conceito de field
        public string Country
        {
            get => country;     // => labda operator
            set => country = value;
        }
        #endregion

        #endregion

        #region Constructors (public ou internal)
        // a classe dá, por default, um construtor vazio
        // é um método especial (tem o mesmo nome da classe)

        // substituto do default constructor (vazio)
        // atribui vazio a cada uma das prorpeiedades
        // métodos podem ter o mesmo nome mas não podem ter a mesma assinatura
        public Person()
        {
            Id = 0;
            Name = "";      // geram o mesmo resultado
            NIF = string.Empty;     // geram o mesmo resultado
            Phone = string.Empty;
            Address = "";
            City = "";
            Country = "";
        }

        // construtor só com 2 
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // construtor com todas as propriedades
        /*
        é possível usar construtores opcionais
        public Person(int id, string name, string nif = "", string phone = "", string address = "", string city = "", string country = "")
        neste caso só os parâmetro id e o name são obrigatórios
        */

        public Person(int id, string name, string nif, string phone, string address, string city, string country)
        {
            // atribuir a cada uma das variáveis, os valores atribuídos
            // Propriedade = Parameter
            Id = id;
            Name = name;
            NIF = nif;
            Phone = phone;
            Address = address;
            City = city;
            Country = country;
        }
        #endregion

        #region Methods (public ou internal)
        public void PersonWriteData()
        {
            // posso simplesmente mencionar as propriedades da classe, porque estou dentro do próprio objeto
            Utility.WriteTitle("Person - list");
            Utility.WriteMessage($"Id: {Id}", "", "\n");
            Utility.WriteMessage($"Name: {Name}", "", "\n");
            Utility.WriteMessage($"Name: {NIF}", "", "\n");
            Utility.WriteMessage($"Phone: {Phone}", "", "\n");
            Utility.WriteMessage($"Address: {Address}", "", "\n");
            Utility.WriteMessage($"Name: {City}", "", "\n");
            Utility.WriteMessage($"Name: {Country}", "", "\n");
        }

        public void PersonReadData()
        {
            Utility.WriteTitle("Person - read");

            Utility.WriteMessage("Person id:", "", "\n");
            Id = Convert.ToInt16(Console.ReadLine());      // debug, try ... catch (tratamento de erros)
            
            Utility.WriteMessage("Person name: ", "\n");
            Name = Console.ReadLine();
            
            Utility.WriteMessage("Person nif: ", "\n");
            NIF = Console.ReadLine();

            Utility.WriteMessage("Person phone: ", "\n");
            Phone = Console.ReadLine();
            
            Utility.WriteMessage("Person address: ", "\n");
            Address = Console.ReadLine();

            Utility.WriteMessage("Person city: ", "\n");
            City = Console.ReadLine();

            Utility.WriteMessage("Person country: ", "\n");
            Country = Console.ReadLine();
        }
        #endregion

        #region Destructor



        #endregion
    }
}
