using System;

namespace SqlToExcelConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConnectionString tack");
            var connectionString = Console.ReadLine();
            Console.WriteLine("Query tack");
            var query = Console.ReadLine();
            Console.WriteLine("Filnamn");
            var fileName = Console.ReadLine();
            Console.WriteLine("Snart så");
            SqlToExcelConverter.Convert(connectionString, query, fileName);
            Console.WriteLine("Klart! Nu skall du bara hitta filen på data också :)");
            Console.WriteLine("Tryck på en knapp för att avsluta");
            Console.ReadKey();

        }
    }
}
