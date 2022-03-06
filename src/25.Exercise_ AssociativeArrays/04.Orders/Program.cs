using System;
using System.Collections.Generic;

namespace _04.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var productsQuantity = new Dictionary<string, int>();
            var productsPrices = new Dictionary<string, double>();

            while (!input[0].Contains("buy"))
            {
                if (productsQuantity.ContainsKey(input[0]) && productsPrices.ContainsKey(input[0]))
                {
                    productsQuantity[input[0]] += int.Parse(input[2]);
                    productsPrices[input[0]] = double.Parse(input[1]);
                }
                else
                {
                    productsQuantity.Add(input[0], int.Parse(input[2]));
                    productsPrices.Add(input[0], double.Parse(input[1]));
                }


                input = Console.ReadLine().Split(' ');
            }

            foreach (var product in productsPrices)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value * productsQuantity[product.Key]):F2}");
            }
        }
    }
}