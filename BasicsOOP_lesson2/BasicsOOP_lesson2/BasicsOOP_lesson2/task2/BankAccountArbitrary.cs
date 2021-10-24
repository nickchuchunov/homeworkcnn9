using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson2
{

    /* Изменить класс счет в банке из упражнения таким образом, чтобы номер счета
генерировался сам и был уникальным. Для этого надо создать в классе
статическую переменную и метод, который увеличивает значение этого
переменной.
*/


    class BankAccountArbitrary
    {
        private static long _AccountName = 155455245555;
        private decimal _Remains;

       private Random rnd = new Random();

        public long AccountNameArbitrary { get { return _AccountName+ rnd.Next(); }  }
        public decimal RemainsArbitrary { get { return _Remains; } set { _Remains = value; } }

        


        public BankAccountArbitrary()
        {
            
            Console.WriteLine("задайте баланс счета");
            RemainsArbitrary = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine(" Счет номер {0} с балансом {1} созданы", AccountNameArbitrary, RemainsArbitrary);

            Console.ReadLine();


        }








    }
}
