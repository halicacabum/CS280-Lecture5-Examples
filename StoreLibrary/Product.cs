using System;
using System.Collections.Generic;
using System.Text;

namespace StoreLibrary
{
    public class Product
    {
        public string Name { get; set; }
        private int price;
        private float discount;

        public static int TotalProduct { get; set; }

        /*
        public Product(string name, int price)
        {
            this.Price = price;
            this.Name = name;
            this.Discount = 1.0f;
        }
        */

        public Product(string name, int price, float discount)
        {
            this.Price = price;
            this.Name = name;
            this.Discount = discount;
            TotalProduct++;
        }

        public Product(string name, int price)
            : this(name, price, 1.0f)
        {
        }

        public Product()
            : this("無產品名稱", 0, 1.0f)
        {
        }

        public Product(Product product)
            : this(product.Name, product.Price, product.Discount)
        {
        }

        public int Price
        {
            get { return this.price; }

            set
            {
                if (value > 200)
                {
                    this.price = 200;
                }
                else if (value < 39)
                {
                    this.price = 39;
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public float Discount
        {
            get => this.discount;
            set
            {
                if (value > 1.0f)
                {
                    this.discount = 1.0f;
                }
                else if (value < 0.3f)
                {
                    this.discount = 0.3f;
                }
                else
                {
                    this.discount = value;
                }
            }
        }

        public int GetPrice()
        {
            return this.price;
        }

        public void SetPrice(int price)
        {
            if (price > 200)
            {
                this.price = 200;
            }
            else if (price < 39)
            {
                this.price = 39;
            }
            else
            {
                this.price = price;
            }
        }

        public Product Clone()
        {
            return new Product()
        }

        public override string ToString()
        {
            return string.Format("產品名稱:{0}\n產品價格:{1}\n產品折扣:{2}\n這是第{3}個Product"
                 , this.Name
                 , this.Price
                 , this.Discount
                 , Product.TotalProduct);
        }
    }
}