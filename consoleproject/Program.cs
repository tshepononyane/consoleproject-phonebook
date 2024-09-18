using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\t\t\t\t\t\t\t~~~PHONE BOOK APP~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n CHOOSE A NUMBER\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("_______________________________________");
            Console.WriteLine("1 ADD CONTACT");
            Console.WriteLine("2 SEARCH FOR A  CONTACT BY NUMBER");
            Console.WriteLine("3 VIEW ALL CONTACTS");
            Console.WriteLine("4 SEARCH FOR CONTACTS FOR A BY NAME");
            Console.WriteLine("PRESS 'x' TO EXIT");
            Console.WriteLine("_______________________________________");
            Console.ForegroundColor = ConsoleColor.Yellow;
            var userinput = Console.ReadLine();
            var phoneBook = new PhoneBook();
            
            while (true)
            {
                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("CONTACT NAME");
                        var name = Console.ReadLine();
                        Console.WriteLine("CONTACT NUMBER");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name,number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("CONTACT NUMBER TO SEARCH");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContant(searchNumber);
                        break;
                   case "3":
                        phoneBook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Name Search Phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    
                    case "x":
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("WRONG INPUT");
                        break;

                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("CHOOSE A NUMBER");
                userinput = Console.ReadLine();


            }




        }
    }
}
