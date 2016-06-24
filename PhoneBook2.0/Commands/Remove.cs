using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2._0
{
    class Remove
    {
        public static void RemoveString()
        {
            Console.WriteLine("Please type index of line for removing");
            int Index1 = Int32.Parse(Console.ReadLine());
            Data.ListName[Index1 - 1] = null;
            Data.ListName = Data.ListName.Where(x => x != null).ToArray();
            Data.ListSurname[Index1 - 1] = null;
            Data.ListSurname = Data.ListSurname.Where(x => x != null).ToArray();
            Data.PhoneNumber[Index1 - 1] = 0;
            Data.PhoneNumber = Data.PhoneNumber.Where(x => x != 0).ToArray();
        }
    }
}
