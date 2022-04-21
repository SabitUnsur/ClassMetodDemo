using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri customers)
        {
            Console.WriteLine("Customer has been added.");
            Console.WriteLine("Welcome,Dear" + customers.Name);
        }

        public void MusteriSil(Musteri customers)
        {
            Console.WriteLine("Customer has been deleted.");
           
            Console.WriteLine("Deleted-->"+customers.Name);
        }

       

    }
}
