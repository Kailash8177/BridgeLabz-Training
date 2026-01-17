using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FlashDealz
{
    internal class ProductUtility : IProductOperations
    {
        private ProductNode head;

        public void AddProduct(string product,int value)
        {

            ProductNode newNode = new ProductNode(product, value);

            // Add at First
            if(head == null)
            {
                head = newNode;
                return;
            }

            //Add at last

            ProductNode temp = head;

            while (temp.next!=null)
            {
                temp = temp.next;
            }

            temp.next = newNode;

        }

        public void DisplayProducts()
        {
            if (head==null)
            {
                Console.WriteLine("There is no Product");
                return;
            }
            ProductNode temp = head;

            while (temp != null)
            {
                Console.WriteLine($"the peoduct is : {temp.product} prcie is: {temp.discount}");
                temp = temp.next;
            }

        }

        public void SortByDiscount()
        {

            head = QuickSort(head); 

        }
        private ProductNode QuickSort(ProductNode head)
        {
            if (head == null || head.next == null )
            {
                return head;
            }

            ProductNode pivot = head;

            ProductNode highHead = null;
            ProductNode highTail = null;
            ProductNode lowHead = null;
            ProductNode lowTail = null;

            ProductNode current = head.next;

            while ( current != null )
            {
                if (current.discount > pivot.discount)
                {
                    if (highHead == null)
                    {
                        highHead = highTail = current;
                    }
                    else
                    {
                        highTail.next = current;
                        highTail = current;
                    }
                }
                else
                {
                    if (lowHead == null)
                    {
                        lowHead = lowTail = current;
                    }
                    else
                    {
                        lowTail.next = current;
                        lowTail = current;
                    }
                }
                current = current.next;
            }

            if (highTail != null) highHead.next = null;
            if (lowTail != null) lowHead.next = null;

            return merge( highHead, pivot, lowHead);
            

        }

        public ProductNode merge(ProductNode left, ProductNode pivot, ProductNode right)
        {
            pivot.next = right;
            if (left == null) return pivot;

            ProductNode temp = left;
            while (temp.next != null)
                temp = temp.next;

            temp.next = pivot;
            return left;
        }

    
    }
}
