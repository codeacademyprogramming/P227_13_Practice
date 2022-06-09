using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClasses
{
    public class Library
    {
        Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length-1] = product;
        }
        public int GetJournalsCount()
        {
            int count = 0;
            foreach (var item in Products)
            {
                if (item is Journal)
                {
                    count++;
                }
            }
            return count;
        }

        public Product[] GetProducts(bool isBook)
        {
            Product[] products;

            if (isBook)
                products = GetBookProducts();
            else
                products = GetJournalProducts();

            return products;
        }


        public Product[] GetJournalProducts()
        {
            Product[] journals = new Product[0];

            foreach (var item in Products)
            {
                if(item is Journal)
                {
                    Array.Resize(ref journals, journals.Length + 1);
                    journals[journals.Length - 1] = item;
                }
            }

            return journals;
        }

        public Product[] GetBookProducts()
        {
            Product[] journals = new Product[0];

            foreach (var item in Products)
            {
                if (item is Book)
                {
                    Array.Resize(ref journals, journals.Length + 1);
                    journals[journals.Length - 1] = item;
                }
            }

            return journals;
        }
    }
}
