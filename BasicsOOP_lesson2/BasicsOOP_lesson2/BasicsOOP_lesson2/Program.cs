using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP_lesson2

{
    class Program
    {
        static void Main(string[] args)
        {
            // первое задание
            //new BankAccount();

            // второе задание

            //new BankAccountArbitrary();

            // третье  и четвертое задание

            //new BankAccountDesigner(12254);
            // new BankAccountDesigner("starting");
            // new BankAccountDesigner("starting", 12254);

            // пятое задание

            BankAccountActions topup =  new BankAccountActions();

            topup.TaceOff();

        }
    }
}
