using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    public class ProductNode
    {
        public string product;
        public int discount;
        public ProductNode next;
       public  ProductNode (string product , int discount)
        {
            this.product = product;
            this.discount = discount;
            next = null;
        }
    }
}
