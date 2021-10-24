using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson2
{
    class BankAccountFatures
    {


        private static long _AccountNameFatures = 155455245555;
        private decimal _RemainsFatures;
        private string _TypeBankAccount;
        private Random rnd = new Random();
        public long AccountNameFatures { get { return _AccountNameFatures + rnd.Next(); } set { _AccountNameFatures = value; } }
        public decimal RemainsFatures { get { return _RemainsFatures; } set { _RemainsFatures = value; } }
        public string TypeBankAccountFatures { get { return _TypeBankAccount; } set { _TypeBankAccount = value; } }









        public BankAccountFatures(decimal RemainsFatures)
        {
            this.RemainsFatures = RemainsFatures;

            Console.WriteLine(" Счет номер {0} с балансом {1} созданы", AccountNameFatures, RemainsFatures);

            Console.ReadLine();


        }

        public BankAccountFatures(string TypeBankAccountFatures)
        {
            this.TypeBankAccountFatures = TypeBankAccountFatures;

            Console.WriteLine("задайте баланс счета");
            RemainsFatures = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(" Счет номер {0} с балансом {1}  и типом {2} созданы", AccountNameFatures, RemainsFatures, TypeBankAccountFatures);

            Console.ReadLine();


        }



        public BankAccountFatures(string TypeBankAccountFatures, decimal RemainsFatures)
        {
            this.TypeBankAccountFatures = TypeBankAccountFatures;
            this.RemainsFatures = RemainsFatures;



            Console.WriteLine(" Счет номер {0} с балансом {1}  и типом {2} созданы", AccountNameFatures, RemainsFatures, TypeBankAccountFatures);

            Console.ReadLine();


        }









    }
}
