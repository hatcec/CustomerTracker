using System;
using System.Collections.Generic;
using System.Text;

namespace MetotClassDemo
{
    public class CustomerManager
    {
        public void Ekle(Customer[] customer)
        {
            Console.WriteLine("müşteri eklendi");
        }
        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.Ad+" isimli müşteri silindi");                     
        }
        public void Listele(Customer[] customer)
        {
            
            foreach (var c in customer)
            {
                Console.WriteLine(c.Id+" "+c.Ad+" "+c.Soyad);
            }
        }

    }
}
