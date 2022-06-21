using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public class AddressBook
    {
        public void Address()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }
        public static void Main(string[]strings)
        {
            AddressBook book = new AddressBook();
            book.Address();
        }
    }
}
