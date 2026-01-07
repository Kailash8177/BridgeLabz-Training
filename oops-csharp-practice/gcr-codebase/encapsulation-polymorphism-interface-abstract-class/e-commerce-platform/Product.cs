using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce_platform
{
    public abstract class Product
    {
        // Encapsulation: private fields
        private int productId;
        private string name;
        private double price;

        // Setter methods (controlled update)
        public void SetProductId(int id)
        {
            productId = id;
        }

        public void SetName(string productName)
        {
            name = productName;
        }

        public void SetPrice(double productPrice)
        {
            if (productPrice > 0)
                price = productPrice;
        }

        // Getter methods
        public int GetProductId() => productId;
        public string GetName() => name;
        public double GetPrice() => price;

        // Abstract method
        public abstract double CalculateDiscount();
    }

}
