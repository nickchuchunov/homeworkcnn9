using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson2
{

    /* В классе банковский счет, удалить методы заполнения полей. Вместо этих
методов создать конструкторы. Переопределить конструктор по умолчанию,
создать конструктор для заполнения поля баланс, конструктор для заполнения
поля тип банковского счета, конструктор для заполнения баланса и типа
банковского счета. Каждый конструктор должен вызывать метод, генерирующий
номер счета.*/



    class BankAccountDesigner
    {


        private static long _AccountNameDesigner = 155455245555;
        private decimal _RemainsDesigner;
        private string _TypeBankAccount; 
        private Random rnd = new Random();
        public long AccountNameDesigner { get { return _AccountNameDesigner+ rnd.Next(); } set { _AccountNameDesigner = value; } }
        public decimal RemainsDesigner { get { return _RemainsDesigner; } set { _RemainsDesigner = value; } }
        public string TypeBankAccount { get {return _TypeBankAccount; } set { _TypeBankAccount = value; } }









        public  BankAccountDesigner(decimal RemainsDesigner)
        {
            this.RemainsDesigner = RemainsDesigner;

           Console.WriteLine(" Счет номер {0} с балансом {1} созданы", AccountNameDesigner, RemainsDesigner);

            Console.ReadLine();


        }

        public BankAccountDesigner(string TypeBankAccount)
        {
            this.TypeBankAccount = TypeBankAccount;

            Console.WriteLine("задайте баланс счета");
            RemainsDesigner = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(" Счет номер {0} с балансом {1}  и типом {2} созданы", AccountNameDesigner, RemainsDesigner, TypeBankAccount);

            Console.ReadLine();


        }



        public BankAccountDesigner(string TypeBankAccount, decimal RemainsDesigner)
        {
            this.TypeBankAccount = TypeBankAccount;
            this.RemainsDesigner = RemainsDesigner;

            

            Console.WriteLine(" Счет номер {0} с балансом {1}  и типом {2} созданы", AccountNameDesigner, RemainsDesigner, TypeBankAccount);

            Console.ReadLine();


        }







        /*public BankAccountDesigner()
        {


            Console.WriteLine("задайте номер счета");
            AccountNameDesigner = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("задайте баланс счета");
            RemainsDesigner = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine(" Счет номер {0} с балансом {1} созданы", AccountNameDesigner, RemainsDesigner);

            Console.ReadLine();


        }*/












    }
}
