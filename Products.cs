
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSam2_2
{
    struct Products
    {
        public static List<Products> products = new List<Products>();



        public string Name { get; set; }
        public string Producer { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

        public Products(string name, string producer, int price, DateTime date)
        {
            Name = name;
            Producer = producer;
            Price = price;
            Date = date;
        }

        public static void Show()
        {
            int sum = 0;

            foreach (var i in products)
            {
                if (i.Date.Year == DateTime.Now.Year)
                {
                    Console.WriteLine($"Name: {i.Name}, Producer: {i.Producer}, Price: {i.Price}, Date: {i.Date}");
                    sum += i.Price;
                }

            }
            
            //else
            //    {
            //        Console.WriteLine("Нет продуктов года выпуска 2025 года.");
            //    return;
            //    }

            Console.WriteLine($"Общее количество книг: {products.Count}");
            Console.WriteLine($"Общая стоимость продуктов 2025 года: {sum} рублей.");
        }
        public static void AddProduct()
        {
            int count = products.Count;
            Console.WriteLine("Введите название продукта:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите производителя продукта:");
            string producer = Console.ReadLine();
            Console.WriteLine("Введите цену продукта:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату выпуска продукта (в формате ГГГГ-ММ-ДД):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            products.Add(new Products(name, producer, price, date));
            count++;
        }
        public static void MaxMin()
        {

            var maxPriceProduct = products.OrderByDescending(p => p.Price).First();
            var minPriceProduct = products.OrderBy(p => p.Price).First();

            Console.WriteLine($"Самый дорогой {maxPriceProduct.Name}, а его цена {maxPriceProduct.Price} рублей.");
            Console.WriteLine($"Самый дешевый {minPriceProduct.Name}, а его цена {minPriceProduct.Price} рублей.");
        }
    }
}
