using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAppOOP_1
{
    class BirthdayEntry
    {
        // characteristics of the class - fields
        public string firstName;
        public string lastName;
        public string telephone;
        public DateTime dateOfBirth;

        // default constructor
        public BirthdayEntry()
        {
            // put some sample values for the user to see, e.g.
            // firstName = "NoName"
            // ..
            // dateOfBirth = "1900/01/01"
            this.firstName = "NoName";
            this.lastName = "NoName";
            this.telephone = "00000000";
            this.dateOfBirth = Convert.ToDateTime("1900/01/01");
        }

        // overloaded constructor
        public BirthdayEntry(string firstName, string lastName, 
                             string telephone, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.telephone = telephone;
            this.dateOfBirth = dateOfBirth;
        }

        // overloaded constructor
        public BirthdayEntry(string firstName)
        {
            // put some sample values for the user to see, e.g.
            // ..
            // dateOfBirth = "1900/01/01"
            this.firstName = firstName;
            this.lastName = "NoName";
            this.telephone = "00000000";
            this.dateOfBirth = Convert.ToDateTime("1900/01/01");
        }

        // methods
        public override string ToString()
        {
            return ($"FirstName: {firstName}, LastName: {lastName}, " +
                              $"   Telephone: {telephone}, Date Of Birth: {dateOfBirth}");
        }


    }
}
