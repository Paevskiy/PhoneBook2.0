using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2._0
{
    using System.Text.RegularExpressions;
    class Search
    {
        public static void MainSearch()
        {
            Console.WriteLine("Поиск введите критерии поиска:");
            string searchString = Console.ReadLine();
            //string searchString = "Иван";
            //string searchString = "Иван Иванов";
            //string searchString = "";
            //string searchString = "Иван Иванов 89611176115";
            var wordsRegex = new Regex("\\w+?\\b");
            var wordsCollection = wordsRegex.Matches(searchString)
                .OfType<Match>()
                .Select(s => s.Value)
                .ToList();

            Console.Clear();
            Show.ShowTitle();
            Show.ShowLine();
            for (int index = 0; index < Data.ListName.Length; index++)
            {
                switch (wordsCollection.Count) //по колличеству введеных слов
                {
                    case 0:
                        Console.WriteLine("Вы ввели ничего");
                        Console.ReadKey();
                        MainSearch();
                        break;
                    case 1:
                        if (Data.ListName[index] == searchString)
                        {
                            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |",
                                index, Data.ListName[index], Data.ListSurname[index], Data.PhoneNumber[index]);
                        }
                        else if (Data.ListSurname[index] == searchString)
                        {
                            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |",
                                index, Data.ListName[index], Data.ListSurname[index], Data.PhoneNumber[index]);
                        }

                        break;
                    case 2:
                        if (Data.ListName[index] == wordsCollection[0] &&
                            Data.ListSurname[index] == wordsCollection[1])
                        {
                            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |",
                                           index, Data.ListName[index], Data.ListSurname[index], Data.PhoneNumber[index]);
                        }
                        break;
                    case 3:
                        if (Data.ListName[index] == wordsCollection[0] &&
                            Data.ListSurname[index] == wordsCollection[1] &&
                            Data.PhoneNumber[index] == double.Parse(wordsCollection[2]))
                        {
                            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |",
                                           index, Data.ListName[index], Data.ListSurname[index], Data.PhoneNumber[index]);
                        }
                        break;
                    default:
                        Console.WriteLine("Не верные критерии поиска");
                        MainSearch();
                        break;

                }


            }
            //foreach (var p in wordsCollection)
            //{
            //    Console.WriteLine(p);
            //}
            Show.ShowLine();
            CommandsList.CommandsAll();
            Console.ReadKey();
        }
    }
}
