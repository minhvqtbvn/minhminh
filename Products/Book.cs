using System.Security.Cryptography.X509Certificates;

namespace Products
{
    public class Book : Product
    {
        
        public override double computeTax()
        {
            return _productPrice * 5 / 100;


        }
    }
}