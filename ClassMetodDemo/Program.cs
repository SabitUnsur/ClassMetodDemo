using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1=new Musteri();
            customer1.Name = "Sabit";
            customer1.Surname = "Ünsür";
            customer1.telephone = "+905423849158";
            customer1.Adress = "Sincan/Ankara";

            Musteri customer2=new Musteri();
            customer2.Name = "Talha";
            customer2.Surname = "Ersöz";
            customer2.telephone = "+90554348468";
            customer2.Adress = "Merkez/Afyon";


            Musteri customer3 =new Musteri();
            customer3.Name = "Ahmet";
            customer3.Surname = "Yıldız";
            customer3.telephone = "+905863841256";
            customer3.Adress = "Beyoğlu/İstanbul";

            Musteri[] customers=new Musteri[]{ customer1,customer2,customer3};
            foreach (var i in customers)
            {
                Console.WriteLine("Person:" + i.Name + i.Surname);
                Console.WriteLine("Telephone:" + i.telephone);
                 Console.WriteLine("Adress:"+i.Adress);
                Console.WriteLine("*******");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(customer1);
            Console.WriteLine("*******");
            musteriManager.MusteriSil(customer2 );


            Console.ReadKey();
        }
    }
}
