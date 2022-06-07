using System;
namespace Sample6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату (например: 23 июль 2003): ");
            var DATA = Console.ReadLine().ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            uint a = Convert.ToUInt32(DATA[0]);
            string b = DATA[1];
            uint c = Convert.ToUInt32(DATA[2]);
            uint D = 0;
            string[] month = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            uint[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            uint[] vday = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < 12; i++)
            {
                if ((c % 4 == 0 && c % 100 != 0) || (c % 400 == 0))
                {
                    if (b == month[i])
                    {
                        if (a > 0 && a <= vday[i])
                        {
                            uint x = D + a;
                            uint y = 366 - (D + a);
                            Console.WriteLine($"Корректная дата\n{x}\n{y}");
                        }
                        else Console.WriteLine("Некорректная дата");
                    }
                    D = D + vday[i];
                }
                else
                {
                    if (b == month[i])
                    {
                        if (a > 0 && a <= day[i])
                        {
                            uint x = D + a;
                            uint y = 365 - (D + a);
                            Console.WriteLine($"Корректная дата\n{x}\n{y}");
                        }
                        else Console.WriteLine("Некорректная дата");
                    }
                    D = D + day[i];
                }
            }
        }
    }
}
