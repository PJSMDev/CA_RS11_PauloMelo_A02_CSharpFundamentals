using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E08_Collections_ListManipulation_Person
{
    internal class Person
    {

        #region Properties

        internal static int NextId { get; set; } = 1;
        internal string Name { get; set; }
        internal int Id { get; set; }

        #endregion

        #region Constructors

        internal Person() 
        {
            Id = 0;
            Name = string.Empty;
        }

        internal Person(string name)
        {
            Id = NextId++;
            Name = name;
        }

        #endregion

        #region Methods

        #region 1. AddPerson()

        internal static void AddPerson(List<Person> list, string name)
        {
            /*
            método Add()
            https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=net-8.0
            public void Add(T item);
            Objeto adicionado no FINAL da List<T>
            */

            Person newPerson = new Person(name);
            list.Add(newPerson);
            Utility.WriteMessage($"ID: {newPerson.Id} - Name: {name} added successfully!", "", "\n\n");
        }

        #endregion

        #region 2. Insert Person by Position
        /*
        método insert()
        https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.insert?view=net-8.0
        como empurrar as outras pessoas todas?
        public void Insert(int index, T item);
        o índice começa a 0
        */

        #endregion

        #region 3. Find Person by ID
        /*
        método find()
        https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-8.0
        public T? Find(Predicate<T> match);
        Predicate<T> define a condição a encontrar
        retorna o PRIMEIRO elemento que satisfaça o predicado
        foreach?? com return?? ou print no proprio metodo?
        talvez return para que o método só faça uma coisa

        propiedade count
        public int Count { get; }

        deve ser algo do género: Find(person.Id == id que recebe como parâmetro)
        recebe também a lista como parâmetro
        */

        internal static Person FindPersonById(List<Person> list, int id)
        {
            return list.Find(person => person.Id == id);
        }

        #endregion

        #region 4. Remove Person by ID
        /*
        método remove()
        https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=net-8.0
        public bool Remove(T item);
        como puxar todos os outros para tras?
        retorna um bool -> true se removido com sucesso
                        -> false se -> não for removido com sucesso
                                    -> se não encontrar o item
        será que posso mudar a assinatura para devolver o item? pode dar jeito para imprimir a informação no Program.cs???
        */

        //internal static bool RemovePersonById(List<Person> list, int id) 
        //{
        //    // usar a FindPersonById()


        //}

        #endregion

        #region 5. Sort List by ID
        /*
        método sort()
        https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-8.0
        public void Sort(Comparison<T> comparison);
        Comparison<T> comparação a fazer
        usa a propriedade CompareTo
            EXEMPLO: return name1.CompareTo(name2);
        */

        internal static void SortListById(List<Person> list)
        {
            list.Sort((person01, person02) => person01.Id.CompareTo(person02.Id));       // voltar a pesquisar isto para compreender melhor
            Utility.WriteMessage("List sorted by ID.", "", "\n\n");                        // acede ao Id da primeira pessoa e compara-o com o Id da segunda
            // NÃO FUNCIONA CORRETAMENTE, O WriteMessage NÃO APARECE
        }

        #endregion

        #region 6. Sort List by Name
        /*
        método sort()
        https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-8.0
        public void Sort(Comparison<T> comparison);
        */

        internal static void SortListByName(List<Person> list)
        {
            list.Sort((person01, person02) => person01.Name.CompareTo(person02.Name));
            Utility.WriteMessage("list sorted by Name.", "", "\n\n");
            // NÃO FUNCIONA CORRETAMENTE, O WriteMessage NÃO APARECE
        }

        #endregion

        #region 7. List Person
        // foreach

        internal static void ListPerson(List<Person> list) 
        {
            Console.Clear();

            foreach (var person in list)        // tenho de usar var??? Acho que sim
            {
                Utility.WriteMessage($"ID: {person.Id} -> Name: {person.Name}", "", "\n");
            }

            Utility.WriteMessage("\n");
        }

        #endregion

        #endregion

    }
}
