using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSam2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<Products> products = new List<Products>();
                //Products productiki = new Products();
                Console.Clear();
                Console.WriteLine("Выберите функцию:\n1. Добавить товар\n2. Вывести список товаров\n3. Вывести самый дорогой/дешёвый товары\n4. Выход");
                string s = Console.ReadLine();
                Console.WriteLine("");
                switch (s)
                {
                    case "1":
                        Console.Clear();
                        Products.AddProduct();
                        break;
                    case "2":
                        Products.Show();
                        Console.Read();
                        break;
                    case "3":
                        Products.MaxMin();
                        Console.Read();
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        break;
                }
            }
        }
    }
}
