using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystalsCount;
            int crystalsPrice = 10;

            Console.WriteLine("Добро пожаловать в магазин, сегодня кристаллы по " + crystalsPrice + " монет");
            Console.Write("Введите колоичество золота у Вас в кошельке:");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов вам нужно:");
            crystalsCount = Convert.ToInt32(Console.ReadLine());

            gold -= crystalsCount * crystalsPrice;
            Console.WriteLine("У Вас в кошельке {0} золота, и {1} кристаллов", gold, crystalsCount);
        }
    }
}
