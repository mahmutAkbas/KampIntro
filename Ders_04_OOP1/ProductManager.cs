using System;

namespace Ders_04_OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("{0} eklendi.", product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("{0} guncellendi.", product.ProductName);
        }
        
    }
}