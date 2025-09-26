using System.Net.NetworkInformation;

namespace _05_ADO.NET_FinalWork
{
    internal class Program
    {
        class Country
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Duplo
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class Genre
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ICollection<Book> Books { get; set; }

        }

        class Publisher
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Country Country{ get; set; }
        }
        class Author
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }
    


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
