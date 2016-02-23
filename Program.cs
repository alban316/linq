using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {
        static void GetPeople(string match)
        {
            AwDbDataContext db = new AwDbDataContext();

            var query =
                from rowset in db.Persons
                where rowset.LastName.StartsWith(match)
                select rowset;

            foreach (Person person in query)
            {
                Console.WriteLine("{0}, {1} {2}", person.LastName, person.FirstName, person.MiddleName);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the search string:");
            string search = Console.ReadLine();
            GetPeople(search);
        }
    }
}
