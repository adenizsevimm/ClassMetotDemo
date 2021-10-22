using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Uygar Efe";
            customer1.LastName = "Sevim";
            customer1.Address = "Bartın";
            customer1.PostCode = 74600;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Ahmet Deniz";
            customer2.LastName = "Sevim";
            customer2.Address = "Bartın";
            customer2.PostCode = 74600;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Uğur";
            customer3.LastName = "Çelik";
            customer3.Address = "İstanbul";
            customer3.PostCode = 34093;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Yunus Emre";
            customer4.LastName = "Eryılmaz";
            customer4.Address = "İstanbul";
            customer4.PostCode = 34025;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);

        }
          
    }
}
