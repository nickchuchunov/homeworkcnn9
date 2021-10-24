using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson2
{

    /*   1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, 
     *   тип банковского счета (использовать перечислимый тип). Предусмотреть методы для доступа к данным – заполнения и чтения. 
     *   Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.             */
   public class BankAccount
    {

        private long _AccountName;
        private decimal _Remains;

        public long AccountName { get { return _AccountName; } set { _AccountName = value; } }
        public decimal Remains { get { return _Remains; } set { _Remains = value; } }

       public BankAccount() 
        {
            
            
            Console.WriteLine("задайте номер счета");
            AccountName =   Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("задайте баланс счета");
            Remains = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine(" Счет номер {0} с балансом {1} созданы", AccountName, Remains);

            Console.ReadLine();


        }
        


       



    }
}
