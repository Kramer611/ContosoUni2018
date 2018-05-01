using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUni2018.Models
{
    public class Course
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]// this is like a filter

        /*
         * you can turn off IDENTITY  (is on by default) by using the option above
         * you have the following 3 options:
         *          -None: database does not generate a value
         *          -Identity: database generates a value
         *          -computed: database generates a value when a row is inserted or  updated
         */
         
        public int CourseID { get; set; } //PK
        public string Title { get; set; }
        public int Credits { get; set; }

        //Navigation properties
        //one course many enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}