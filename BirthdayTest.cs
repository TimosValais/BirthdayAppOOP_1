using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAppOOP_1
{
    class BirthdayTest
    {
        public void PrintTwoEntries(BirthdayEntry be, BirthdayEntry be2)
        {
            Console.WriteLine(be);
            Console.WriteLine(be2);
            //Console.WriteLine($"be {be.firstName}, {be.lastName}, " +
            //                  $"   {be.telephone}, {be.dateOfBirth}");
            //Console.WriteLine($"be2 {be2.firstName}, {be2.lastName}, " +
            //                  $"   {be2.telephone}, {be2.dateOfBirth}");
        }
    }
}
