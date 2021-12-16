using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public  class Operations
    {
        public static bool Proverka(string a)
        {

            return true; //вызов метода проверки в классе с правилом
        }
      
        public  string Write_off()
        {
            if (Operations.Proverka("Списание"))
                return ("Списание разрешено");
            else
                return ($"Списание запрещено-({First.pravilo})");
        }
        public  string Refill()
        {
            if (Operations.Proverka("Пополнение"))
                return ("Пополнеи разрешено");
            else
                return ($"Пополнение запрещено-({First.pravilo})");
        }


    }
    public static class First
    {
        public static string pravilo="null"; //Присваиваем правило из класса
    
    }
}
