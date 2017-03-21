using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product = new Product();
            Console.Write("請輸入產品名稱:");
            product.Name = Console.ReadLine();
            Console.Write("請輸入{0}的價錢", product.Name);
            Console.WriteLine("共有{0}個產品", Product.TotalProduct);
            try
            {
                int price = 0;
                price = int.Parse(Console.ReadLine());
                product.SetPrice(price);
                Console.WriteLine("產品:{0}的價格是{1}", product.Name, product.GetPrice());
            }
            catch
            {
                Console.WriteLine("價格輸入錯誤");
                return;
            }

            Console.WriteLine(product);
            Product product2 = product.Clone();
            product2.Name = "BB";
            Console.WriteLine(product2);
            /*
            Console.WriteLine("Product 的 name: {0}", product.Name);
            //Product product2 = product;
            Product product2 = new Product();
            product2.Name = "B";
            Console.WriteLine("Product 的 name: {0}", product.Name);
            Console.WriteLine("Product 的 name: {0}", product2.Name);
            */
        }
    }