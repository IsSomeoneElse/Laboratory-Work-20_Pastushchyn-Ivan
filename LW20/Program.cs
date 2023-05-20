using System;
using System.Runtime.CompilerServices;

namespace LW20
{
    class Program
    {
        public bool IsLeapYear(int year)
        {
            try
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (year % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Виникла помилка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Рік: " + year);
            }

            return false;
        }

        static void Main()
        {
            var iop = new Program();
            string val;
            int year;

            Console.WriteLine("Введіть рік:  ");
            val = Console.ReadLine();
            year = Convert.ToInt32(val);

            Console.WriteLine($"Рік високосний: {iop.IsLeapYear(year)}");
        }
    }
}