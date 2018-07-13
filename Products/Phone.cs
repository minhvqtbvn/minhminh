namespace Products
{
    public class Phone : Product
    
    {
        public override double computeTax()
        {
            return _productPrice * 10 / 100;
        }    
    }
    
        
    }
