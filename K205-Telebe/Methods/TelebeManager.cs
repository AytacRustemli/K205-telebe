using K205_Telebe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace K205_Telebe.Methods
{
    public class TelebeManager
    {
        public void HereketeBasla(Telebe telebe )
        {
            Console.WriteLine("Giris baliniz necedir?");
            string bal = Console.ReadLine();
            decimal netice = Convert.ToDecimal(bal);
            decimal lazimlibal = telebe.Bal - netice;
            
            if (netice > 50)
            {
                Console.WriteLine("Duzgun bali daxil edin");
            }
            else
            {
                telebe.Bal -= netice;
                Console.WriteLine("Size minimum" + " " + telebe.Bal + " bal lazimdir.");
            }
        }

        public void Davam(Telebe telebe)
        {
            Console.WriteLine("Aldiginiz bali daxil edin:");
            string bal1 = Console.ReadLine();
            decimal netice1 = Convert.ToDecimal(bal1);

            if (netice1 < 51)
            {
                Console.WriteLine("Siz kesildiniz");
            }
            else if (netice1 < 61)
            {
                Console.WriteLine("Siz E aldiniz");
            }
            else if (netice1 < 71)
            {
                Console.WriteLine("Siz D aldiniz");
            }
            else if (netice1 < 81)
            {
                Console.WriteLine("Siz C aldiniz");
            }
            else if (netice1 < 91)
            {
                Console.WriteLine("Siz B aldiniz");
            }
            else
            {
                Console.WriteLine("Siz A aldiniz");
            }
        }
        public void TelebeInfo(Telebe telebe)
        {
            Console.WriteLine("Telebenin adi: " + telebe.Name);
            Console.WriteLine("Telebenin soyadi: " + telebe.Surname);
            Console.WriteLine("Fenn: " + telebe.Fenn);
            Console.WriteLine("Kesilmemek ucun lazim olan bal: " + telebe.Bal);
        }
    }
}
