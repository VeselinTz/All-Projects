using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong ID = ulong.Parse(Console.ReadLine());
            int firmID = int.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {fName}\nLast name: {lName}\nAge: {age}\nGender: {gender}\nPersonal ID: {ID}\nUnique Employee number: {firmID}");
        }
    }
}
