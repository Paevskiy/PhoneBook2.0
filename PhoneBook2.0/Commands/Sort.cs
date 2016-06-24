using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2._0
{
    class Sort
    {

        public static void SortName()
        {
            string tempName;
            string tempSurName;
            double tempPhone;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < Data.ListName.Length - 1; ++i)
                    if (Data.ListName[i].CompareTo(Data.ListName[i + 1]) > 0)
                    {
                        tempName = Data.ListName[i];
                        Data.ListName[i] = Data.ListName[i + 1];
                        Data.ListName[i + 1] = tempName;
                        tempSurName = Data.ListSurname[i];
                        Data.ListSurname[i] = Data.ListSurname[i + 1];
                        Data.ListSurname[i + 1] = tempSurName;
                        tempPhone = Data.PhoneNumber[i];
                        Data.PhoneNumber[i] = Data.PhoneNumber[i + 1];
                        Data.PhoneNumber[i + 1] = tempPhone;
                        flag = true;
                    }
            }
        }
        public static void SortSurname()
        {
            string tempName;
            string tempSurName;
            double tempPhone;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < Data.ListSurname.Length - 1; ++i)
                    if (Data.ListSurname[i].CompareTo(Data.ListSurname[i + 1]) > 0)
                    {
                        tempName = Data.ListName[i];
                        Data.ListName[i] = Data.ListName[i + 1];
                        Data.ListName[i + 1] = tempName;
                        tempSurName = Data.ListSurname[i];
                        Data.ListSurname[i] = Data.ListSurname[i + 1];
                        Data.ListSurname[i + 1] = tempSurName;
                        tempPhone = Data.PhoneNumber[i];
                        Data.PhoneNumber[i] = Data.PhoneNumber[i + 1];
                        Data.PhoneNumber[i + 1] = tempPhone;
                        flag = true;
                    }
            }
        }
        public static void SortPhone()
        {
            string tempName;
            string tempSurName;
            double tempPhone;
            for (int i = 0; i < Data.PhoneNumber.Length - 1; i++)
            {
                for (int j = i + 1; j < Data.PhoneNumber.Length; j++)
                {
                    if (Data.PhoneNumber[i] > Data.PhoneNumber[j])
                    {
                        tempPhone = Data.PhoneNumber[i];
                        Data.PhoneNumber[i] = Data.PhoneNumber[j];
                        Data.PhoneNumber[j] = tempPhone;
                        tempName = Data.ListName[i];
                        Data.ListName[i] = Data.ListName[j];
                        Data.ListName[j] = tempName;
                        tempSurName = Data.ListSurname[i];
                        Data.ListSurname[i] = Data.ListSurname[j];
                        Data.ListSurname[j] = tempSurName;
                    }
                }
            }
        }

    }
}
