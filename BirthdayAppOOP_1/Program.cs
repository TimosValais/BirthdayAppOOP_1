using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAppOOP_1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            BirthdayTest bt = new BirthdayTest();
            BirthdayEntry be = new BirthdayEntry("George", "Pasparakis", 
                                                 "6977", DateTime.Now);
            BirthdayEntry be2 = new BirthdayEntry("George");
            bt.PrintTwoEntries(be, be2);
        }
    }
}
