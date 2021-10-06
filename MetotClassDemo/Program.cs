using System;

namespace MetotClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Ad = "hatice";
            customer1.Soyad = "ateş";
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Ad = "merve";
            customer2.Soyad = "canbaz";
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Ad = "murat";
            customer3.Soyad = "dağ";

            Customer[] customers = new Customer[] {customer1,customer2,customer3 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customers);
            Console.WriteLine("-------------------------");
            customerManager.Sil(customer3);
            customerManager.Listele(customers);

        }
    }
}
