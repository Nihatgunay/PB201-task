using System.Diagnostics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TASK---1

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 97, 10, 11, 12, 13, 14, };
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++;)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine(max);


            //TASK---2

            var product1 = new { id = 1, name = "t-shirt", price = 18};
            var product2 = new { id = 2, name = "chips", price = 15 };
            var product3 = new { id = 3, name = "cup", price = 8 };
            var product4 = new { id = 4, name = "plate", price = 6 };
            var product5 = new { id = 5, name = "trouser", price = 13 };

            var products = new[] {product1, product2, product3, product4, product5};
            int sum = 0;
            int count = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].id % 2 == 1)
                {                   
                    sum += products[i].price;
                    count++;
                }
            }
            double average = sum / count;
            Console.WriteLine($"average is {average}");




            





        }
    }
}
