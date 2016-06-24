using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2._0
{
    class Add
    {
        public static void AddString()
        {
            Console.WriteLine("Please Name and press Enter");
            Array.Resize(ref Data.ListName, Data.ListName.Length + 1);
            Data.ListName[Data.ListName.Length - 1] = Console.ReadLine();
            Console.WriteLine("Please Surname and press Enter");
            Array.Resize(ref Data.ListSurname, Data.ListSurname.Length + 1);
            Data.ListSurname[Data.ListSurname.Length - 1] = Console.ReadLine();
            Console.WriteLine("Please PhoneNumber and press Enter");
            Array.Resize(ref Data.PhoneNumber, Data.PhoneNumber.Length + 1);
            Data.PhoneNumber[Data.PhoneNumber.Length - 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |",
                Data.ListName.Length,
                Data.ListName[Data.ListName.Length - 1],
                Data.ListSurname[Data.ListSurname.Length - 1],
                Data.PhoneNumber[Data.PhoneNumber.Length - 1]);
        }
    }
}
