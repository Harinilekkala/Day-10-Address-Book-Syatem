using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class person
    {
        public List<contacts> people = new List<contacts>();
        public  void createcontacts()
        {
            contacts contact = new contacts();
            Console.WriteLine("Enter first name: ");
            contact.firstname = Console.ReadLine();

            Console.WriteLine("Enter lastname name: ");
            contact.lastname = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter contact Number: ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            contact.city = Console.ReadLine();


            Console.WriteLine("Enter zip code: ");
            contact.zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter state: ");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            contact.email = Console.ReadLine();

            people.Add(contact);
        }
        public  void displaycontacts()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("address book is empty.");
                return;
            }
            Console.WriteLine("list of contacts:\n");
            foreach (var contact in people)
            {
                Console.WriteLine("first name: " + contact.firstname);
                Console.WriteLine("last name: " + contact.lastname);
                Console.WriteLine("address: " + contact.address);
                Console.WriteLine("city: " + contact.city);
                Console.WriteLine("state: " + contact.state);
                Console.WriteLine("zip Code: " + contact.zip);
                Console.WriteLine("contact No: " + contact.phoneNo);
                Console.WriteLine("email address: " + contact.email);
            }
        }

    }
}
