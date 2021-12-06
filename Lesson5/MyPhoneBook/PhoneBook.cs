using System;
using System.Linq;

namespace MyPhoneBook
{
    public class PhoneBook
    {
        private PhoneBookEntry[] entries;
        private int lookUpIndex = 0;
        private int entriesNumber;
        private readonly int phoneBookSize;
        public PhoneBookEntry entryToDelete;

        public PhoneBook() :this(5)
        {}

        public PhoneBook(int no)
        {
            entriesNumber = 0;
            phoneBookSize = no;
            entries = new PhoneBookEntry[no];
        }

        public PhoneBookEntry Insert(string name, string number)
        {
            if (entriesNumber < phoneBookSize)
            {
                int insertPosition = 0;
                while (entries[insertPosition] != null)
                {
                    insertPosition++;
                }
                PhoneBookEntry newEntry = new PhoneBookEntry(name, number);
                entries[insertPosition] = newEntry;
                entriesNumber++;
                return newEntry;
            }
            else
                return null;
            
        }

        public bool LookUp(string name, out PhoneBookEntry foundEntry)
        {
            var totalMatches = 0;
            int firstPositionFound = -1;
            for(int i=lookUpIndex; i < phoneBookSize; i++)
            {
                if ((entries[i] != null) && (entries[i].Name.Equals(name)))
                {
                    totalMatches++;
                    if(firstPositionFound == -1)
                        firstPositionFound = i;
                }
            }
            if(totalMatches == 0)
            {
                foundEntry = null;
                return false;
            }
            else if(totalMatches == 1)
            {
                foundEntry = entries[firstPositionFound];
                entryToDelete = foundEntry;
                lookUpIndex = 0;
                return false;
            }
            else
            {
                foundEntry = entries[firstPositionFound];
                entryToDelete = foundEntry;
                lookUpIndex++;
                return true;
            }
        }

        public bool LookUp(string name, string phone, out PhoneBookEntry foundEntry)
        {
            var totalMatches = 0;
            int firstPositionFound = -1;
            for (int i = lookUpIndex; i < phoneBookSize; i++)
            {
                if (entries[i]!=null && entries[i].Name.Equals(name) && entries[i].PhoneNumber.Equals(phone))
                {
                    totalMatches++;
                    if (firstPositionFound == -1)
                        firstPositionFound = i;
                }
            }
            if (totalMatches == 0)
            {
                foundEntry = null;
                return false;
            }
            else if (totalMatches == 1)
            {
                foundEntry = entries[firstPositionFound];
                entryToDelete = foundEntry;
                lookUpIndex = 0;
                return false;
            }
            else
            {
                foundEntry = entries[firstPositionFound];
                entryToDelete = foundEntry;
                lookUpIndex++;
                return true;
            }
        }

        public bool delete()
        {
            if (entryToDelete == null)
                return false;
            else
            {
                int i = 0;
                while ((i < phoneBookSize) && (entryToDelete != null))
                {
                    if ((entries[i] != null) && entries[i].Name.Equals(entryToDelete.Name) && entries[i].PhoneNumber.Equals(entryToDelete.PhoneNumber))
                    {
                        entries[i] = null;
                        entryToDelete = null;
                    }
                    i++;
                }
                return true;
            }
        }

        public PhoneBookEntry this[int i]
        {
            get {
                if ((i < phoneBookSize) && (entries[i] != null))
                    return entries[i];
                else
                    return null;
            }
        }

        public void printPhoneBook()
        {
            Console.WriteLine("----------");
            for(int i=0;i<phoneBookSize;i++)
            {
                if (entries[i] != null)
                    Console.WriteLine($"{i}: {entries[i].Name} - {entries[i].PhoneNumber}");
                else
                    Console.WriteLine($"{i}: empty");
            }
            Console.WriteLine("----------");
        }
    }
}
