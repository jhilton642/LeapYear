using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int nYear;
                bool isDiv4;
                bool isDiv100;
                bool isDiv400;
                do
                {
                    Console.WriteLine("Please enter a year to see if it is, was, or will be a leap year: ");
                } while (!int.TryParse(Console.ReadLine(), out nYear));
                isDiv4 = nYear % 4 == 0 ? true : false;
                isDiv100 = nYear % 100 == 0 ? true : false;
                isDiv400 = nYear % 400 == 0 ? true : false;
                if ((isDiv4 && isDiv100 && isDiv400) || (isDiv4 && !isDiv100 && !isDiv400)){
                    Console.WriteLine(nYear + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(nYear + " is not a leap year.");
                }
                Console.WriteLine("Would you like to test another year?   Type y for yes or any other key to qu;it");
            } while (Console.ReadLine() == "y");
            }
        }
    }

