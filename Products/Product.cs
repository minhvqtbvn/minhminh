using System;
using System.Runtime.CompilerServices;

namespace Products
{
    public abstract class Product
    {
        public string _productID;
        public string _productName;
        public int _productPrice;

        public Product()
        {
        }

        public Product(string productId, string productName, int productPrice)
        {
            _productID = productId;
            _productName = productName;
            _productPrice = productPrice;
        }

        public string ProductId
        {
            get => _productID;
            set => _productID = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public int ProductPrice
        {
            get => _productPrice;
            set => _productPrice = value;
        }

        public abstract double computeTax();
    }
}