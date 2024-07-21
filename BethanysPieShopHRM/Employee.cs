using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
    {
    internal class Employee
        {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthday;

        const int minimalHoursWorkedUnit = 1;

        // adding custom constructor
        // overload constructor, in this case hourlyrate is 0 
        public Employee( string firstN, string lastN, string em, DateTime bd ) : this(firstN, lastN, em, bd, 0)
            {

            }

        public Employee( string firstN, string lastN, string em, DateTime bd, double rate )
            {
            firstName = firstN;
            lastName = lastN;
            email = em;
            birthday = bd;
            hourlyRate = rate;
            }

        //public Employee()
        //    {

        //    }

        // performed work from employees
        public void PerformWork()
            {
            //numberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
            }
        public void PerformWork( int numberOfHours )
            {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
            }
        // method to calculate employee wage
        public double ReceiveWage( bool resetHours = true )
            {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");
            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
            }
        // displaying employee details
        public void DisplayEmployeeDetails()
            {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthday.ToShortDateString()}\n");
            }

        }
    }
