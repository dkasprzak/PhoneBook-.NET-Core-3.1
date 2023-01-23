using System;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");

            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search contacts");
            Console.WriteLine("To exit insert 'x'");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();

                        var newContact = new Contact(name, number);

                        if (number.Length > 9)
                        {
                            Console.WriteLine("The number can not be longer than 9 chars");
                        }
                        else if (number.Length < 9)
                        {
                            Console.WriteLine("The number can not be a shorter than 9 chars");
                        }
                        else if (name.Length < 3)
                        {
                            Console.WriteLine("The name must be least 3 characters long");
                        }
                        else
                        {
                            phoneBook.AddContact(newContact);
                        }

                        break;

                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);

                        break;

                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;

                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPrase);
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();

            }
        }
    }
}
