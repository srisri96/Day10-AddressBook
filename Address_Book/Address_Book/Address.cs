using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Address

    {
        List<Contacts> add_book = new List<Contacts>();
        public static void Add()
        {
            Contacts contacts = new Contacts();                    
            Console.WriteLine("Enter your first name");
            contacts.first_name = Console.ReadLine();
            Console.WriteLine("Enter your second name");
            contacts.s_name = Console.ReadLine();
            Console.WriteLine("Enter your address");
            contacts.address = Console.ReadLine();
            Console.WriteLine("Enter your city");
            contacts.city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter your zip code");
            contacts.zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            contacts.phone_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email");
            contacts.email = Console.ReadLine();
            add_book.Add(contacts);
        }
        public void display()               //displaying details of each conatact
        {
            foreach (var data in add_book)
            {
                Console.WriteLine($"Contacts No. - {data}");
                Console.WriteLine($"Name - {data.first_name} {data.s_name}");
                Console.WriteLine($"Address - {data.address}");
                Console.WriteLine($"City- {data.city}");
                Console.WriteLine($"State - {data.state}");
                Console.WriteLine($"Zip - {data.zip}");
                Console.WriteLine($"Phone no. - {data.phone_no}");
                Console.WriteLine($"Email - {data.email}");
            }
        }
    }
}
