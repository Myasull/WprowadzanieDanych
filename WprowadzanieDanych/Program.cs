using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WprowadzanieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            for (; ;)
            {
                greeting();
                age();
                settings();
            }

        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void age()
        {
            Console.Write("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jesteś pełnoletni");
            }
            else if (result == false)
            {
                Console.WriteLine("Wiek musi być cyfrą");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nie jesteś pełnoletni");

            }
        }

        /// <summary>
        /// Wypisujemy powitanie użytkowinika
        /// </summary>
        private static void greeting()
        {
            Console.Write("Wpisz swoje imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name);
        }
    }
}
