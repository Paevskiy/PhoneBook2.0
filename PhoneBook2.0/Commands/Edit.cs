using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2._0
{
    class Edit
    {
        public static void EditString()
        {
            Console.WriteLine("Please type index of line for editing");
            int Index = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please change Name {0} and press Enter", Data.ListName[Index - 1]);
            Data.ListName[Index - 1] = Console.ReadLine();
            Console.WriteLine("Please change Surname {0} and press Enter", Data.ListSurname[Index - 1]);
            Data.ListSurname[Index - 1] = Console.ReadLine();
            Console.WriteLine("Please change PhoneNumber {0} and press Enter", Data.PhoneNumber[Index - 1]);
            Data.PhoneNumber[Index - 1] = Convert.ToDouble(Console.ReadLine());
        }
    }
}
