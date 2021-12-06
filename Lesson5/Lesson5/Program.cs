using System;
using MyPhoneBook;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook myPhoneBook = new PhoneBook(7);

            myPhoneBook.Insert("Spyros", "6980218891");
            myPhoneBook.Insert("Marina", "6970213291");
            myPhoneBook.Insert("George", "6932278123");
            myPhoneBook.Insert("Spyros", "6931234567");
            myPhoneBook.Insert("Vlassis", "6989123581");
            myPhoneBook.printPhoneBook();

            Console.WriteLine($"Delete: {myPhoneBook.delete()}");

            myPhoneBook.printPhoneBook();

            myPhoneBook.LookUp("Spyros", out myPhoneBook.entryToDelete);
            myPhoneBook.LookUp("Spyros", out myPhoneBook.entryToDelete);
            Console.WriteLine($"Delete: {myPhoneBook.delete()}");
            myPhoneBook.printPhoneBook();

            myPhoneBook.Insert("Thanos", "6936678123");
            myPhoneBook.printPhoneBook();

            myPhoneBook.LookUp("Marina", "6970213291", out myPhoneBook.entryToDelete);
            Console.WriteLine($"Delete: {myPhoneBook.delete()}");
            myPhoneBook.printPhoneBook();


            //Indexer
            Console.WriteLine($"Phonebook entry: {myPhoneBook[2].Name}, {myPhoneBook[2].PhoneNumber}");

            Console.WriteLine($"Null result: {myPhoneBook[9]}");
            if (myPhoneBook[9] != null)
                Console.WriteLine($"Indexer null result: {myPhoneBook[9].Name}");
        }
    }
}
