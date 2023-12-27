using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_03.practice
{

    class Product
    {
        string name;
        double price;
        double quantity;
        private string Name { 
            get { return name; } 
            set {
                if (value == "")
                    throw new ArgumentException("Name is Empty!");
                name = value;
            } 
        }
        private double Price {
            get { return price; } 
            set {
                if (value < 0)
                    throw new ArgumentException("Price is -ve");
                price = value;
            }
        }
        private double Quantity {
            get { return quantity; }
            set { 
                if(value < 0)
                    throw new ArgumentException("Qunatity is -ve");
                quantity = value;
            }
        }

        public Product( string name , int price , int quantity ) { 
            this.name = name;
            this.price = price;
            this.quantity= quantity;
        }

        public double GetTotalValue()
        {
            return this.price * this.quantity;
        }

    }
    internal class Program02
    {
        public static void Main()
        {
            Product myProduct = new Product("Banana", 100, 12);
            Console.WriteLine(myProduct.GetTotalValue());
        }
    }
}
