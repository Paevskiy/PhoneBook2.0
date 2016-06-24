using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2._0
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public double PhoneNumber { get; set; }
        //private int age;

        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        if (value < 1)
        //            age = 1;
        //        else if (value > 150)
        //            age = 150;
        //        else age = value;
        //    }
        //}


        public Person(int id, string name, string surname, double phonenumber)
        {
            Id = id;
            Name = name;
            SurName = surname;
            PhoneNumber = phonenumber;
            //Age = age;
        }
        //public Person(){}
        public virtual void ShowInfo()
        {
            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |", Id, Name, SurName, PhoneNumber);
        }
    }
}
