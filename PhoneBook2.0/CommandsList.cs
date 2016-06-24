using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Double;

namespace PhoneBook2._0
{

    class CommandsList
    {
        public static void CommandsAll()
        {
            Console.WriteLine(@"Available operation are listed below:
""Remove""
""Add""
""Edit""
""Show""
""Sort /name /surname /phone""
""Search""  
""Exit""
Please, type command" + "\n");

            string command = Console.ReadLine();
            switch (command.ToLowerInvariant().Trim())
            {
                case "remove":
                    Remove.RemoveString();
                    Show.ShowAll();
                    break;
                case "add":
                    Add.AddString();
                    Show.ShowAll();
                    break;
                case "edit":
                   Edit.EditString();
                    Show.ShowAll();
                    break;
                case "show":
                    Show.ShowAll();
                    break;
                case "sort /name":
                    Sort.SortName();
                    Show.ShowAll();
                    break;
                case "sort /surname":
                    Sort.SortName();
                    Show.ShowAll();
                    break;
                case "sort /phone":
                    Sort.SortPhone();
                    Show.ShowAll();
                    break;
                case "search":
                    Search.MainSearch();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("\nInput Error, Please try again\n");
                    Console.ReadKey();
                    Show.ShowAll();
                    break;
            }

        }

        
    }
}
