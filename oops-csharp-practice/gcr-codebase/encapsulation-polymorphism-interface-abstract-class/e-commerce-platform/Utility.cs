using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce_platform
{
    public class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>();

            Product p1 = new Electronics();
            p1.SetProductId(1);
            p1.SetName("Laptop");
            p1.SetPrice(60000);

            Product p2 = new Clothing();
            p2.SetProductId(2);
            p2.SetName("Jacket");
            p2.SetPrice(3000);

            Product p3 = new Groceries();
            p3.SetProductId(3);
            p3.SetName("Rice Bag");
            p3.SetPrice(1200);

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            CalculateFinalPrice(products);
        }

        static void CalculateFinalPrice(List<Product> products)
        {
            foreach (Product product in products)
            {
                double tax = 0;

                if (product is ITaxable taxable)
                {
                    tax = taxable.CalculateTax();
                    Console.WriteLine(taxable.GetTaxDetails());
                }

                double discount = product.CalculateDiscount();
                double finalPrice = product.GetPrice() + tax - discount;

                Console.WriteLine($"Product: {product.GetName()}");
                Console.WriteLine($"Base Price: {product.GetPrice()}");
                Console.WriteLine($"Discount: {discount}");
                Console.WriteLine($"Tax: {tax}");
                Console.WriteLine($"Final Price: {finalPrice}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
