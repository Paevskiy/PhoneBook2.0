using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2._0
{
    class Show
    {
        public static void ShowTitle()
        {
            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |",
    Data.Title[0], Data.Title[1], Data.Title[2], Data.Title[3]);

           
        }

        public static void ShowLine()
        {
            for (int a = 0; a < 49; a++)
                Console.Write("-");
            Console.WriteLine();
        }
        public  static void ShowAll()
        {
            Console.Clear();
            // создаем лист контактов, по классу Person, и заполняем данныеими из класса Data
            List<Person> contacts = new List<Person>();
            for (int i = 0; i < Data.ListName.Length; i++)
                contacts.Add(new Person(contacts.Count + 1, Data.ListName[i], Data.ListSurname[i], Data.PhoneNumber[i]));
            ShowTitle();
            ShowLine();
            
            foreach (Person p in contacts)
            {
                p.ShowInfo();
            }
            ShowLine();
            //Console.ReadKey();
            CommandsList.CommandsAll();
        }

    }
}
