using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal interface IProductOperations
    {
        void AddProduct(string name, int discount);
        void DisplayProducts();
        void SortByDiscount();
    }
}
