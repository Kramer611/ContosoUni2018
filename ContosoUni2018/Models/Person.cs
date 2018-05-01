using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUni2018.Models
{
    public abstract class Person
    {       //person properties - characteristics goes to the database

        /*
         * --These properties will become database fields within the Person table by using the 
         * Entity Framework Core
         * --the ID property will become the primary key column of the database table that 
         * corresponds to thei class (Person).
         * --By default the EF (entity framework) interprets a property that's named
         * ID or ClassNameID as the PK, for example:
         *              -ID
         *              -PersonID
         */
        public int ID { get; set; }
        [Display(Name = "First Name")]//just displays the word 
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        [Display(Name = "Postal Code")]
        public string Province { get; set; }

        //read only properties get the fullname and fullname with the ID
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                //return LastName + ", " + FirstName;
                return FirstName + ", " + LastName;
            }
        }
        public string IDFullName
        {
            get
            {
                return "(" + ID + ") " + LastName + ", " + FirstName;
            }
        }
    }
}
