using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    public class sum
    {
        public int Number;
        public int DigitSum;
        public void ReadNumber()
        {
            Console.WriteLine("enter a number:");
            Number = Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateSum()
        {
            int temp = Number;
            DigitSum = 0;

            while (temp != 0)
            {
                int digit = temp % 10;
                DigitSum += digit;
                temp /= 10;
            }
        }


        public void Display()
        {
            Console.WriteLine("sum of digits:" + DigitSum);
        }
    }
}
