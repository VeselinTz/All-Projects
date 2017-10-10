using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Master_Number
{  
    class Program
    {
        static bool isNumSymetric(string number)
        {
            string first = number.Substring(0, number.Length / 2);
            char[] arr = number.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
        static bool isNumDevisible(string number)
        {
            int sumOfDigits = 0;
            char[] arrVal = number.ToCharArray();
            for (int i = 0; i < arrVal.Length; i++)
            {
                sumOfDigits += (Convert.ToInt32(arrVal[i])-48);
            }
            if (sumOfDigits % 7 == 0)
                return true;
            else return false;
        }
        static bool isNumContainsSameDigits(string number)
        {          
            char[] arrNumber = number.ToCharArray();
            for (int i = 1; i < arrNumber.Length; i++) 
            {                               
                    if (arrNumber[i] %2 ==0)
                        return true;
            }
            return false;
        }
        static void isNumMaster(int N)
        {
            for (int number = 0; number < N; number++) 
            if (isNumContainsSameDigits(Convert.ToString(number)) && isNumDevisible(Convert.ToString(number)) && isNumSymetric(Convert.ToString(number)))
                Console.WriteLine(number);            
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            isNumMaster(number);
        }
    }
}
