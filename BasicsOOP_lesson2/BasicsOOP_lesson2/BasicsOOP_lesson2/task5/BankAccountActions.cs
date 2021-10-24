using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson2
{


    /*     Добавить в класс счет в банке два метода: снять со счета и положить на счет.
Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в
случае положительного результата изменяет баланс.
        */




    class BankAccountActions
    {

        private static long _AccountNameActions = 155455245555;
        private decimal _RemainsActions = 32546465;
        private string _TypeBankAccount = "active" ;
        public long AccountNameActions { get { return _AccountNameActions;  } set { _AccountNameActions = value; } }
        public decimal RemainsActions { get { return _RemainsActions; } set { _RemainsActions = value; } }
        public string TypeBankAccountActions { get { return _TypeBankAccount; } set { _TypeBankAccount = value; } }

        public decimal TopUp() // метод поплнения счета

        {
            

            if (RemainsActions!=null & AccountNameActions!=0)
            {
                Console.WriteLine(" Сообщите сумму для зачисления");

                decimal _TopUp = Convert.ToDecimal(Console.ReadLine());

                RemainsActions = RemainsActions + _TopUp;

                Console.WriteLine(" Ваш счет пополнен, на счете {0} денежных средств", RemainsActions);
                Console.ReadLine();

            } 
            
            else { Console.WriteLine("Ваш счет не активен"); }

            return RemainsActions;


        }


        public decimal TaceOff() //  метод снятия со счета
        {

            if (RemainsActions != 0 & AccountNameActions != 0)
            {
                Console.WriteLine("вам доступно {0} сообщите сумму перевода ", RemainsActions);


                decimal _TopUp = Convert.ToDecimal(Console.ReadLine());

                RemainsActions = RemainsActions - _TopUp;

                Console.WriteLine("Денежные средства сняты, на счете {0} денежных средств", RemainsActions);
                Console.ReadLine();

            }

            else { Console.WriteLine("Ваш счет не активен"); }

            return RemainsActions;



        }








        public BankAccountActions() { }
     














    }
}
