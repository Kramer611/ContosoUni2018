using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUni2018.Models
{
    public class Student:Person //student inherits from Person
    {
        //student specific property
        [Display(Name = "Enrollment Date")]//every place that you need to display the date, it will display
                                            // the same name
        // this will format the date using the year, month and day
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        //will display a date picker
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        //1 - student: many enrollments - this is a navigation property between student and enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        /* The enrollments property is a navigation property EF core (entity framework core).
         * Navigation properties hold other entities that are related to this entity. in this case, 
         * the enrollments property of a student entity will hold all of the enrollments that are
         * related ot that student.
         * 
         * In other words, if a gifen sutdent row in the database has two related enrollment rows
         * (rows that contain that stutdent's PK value in their foreign key column), that the student
         * entity's enrollment navigation property will contain those two enrollment entities.
         * 
         * Navigation properties are typically defined as virtual so that they can take advantage of 
         * certain EF functionality such as lazy loading.
         * 
         * Note: lazy loading is not yet available in EF Core (but has in EF 5, 6...)
         * 
         * Lazy loading is not enable by default - so tha tmeans that wen a particular student entity
         * is instantiated it will automatically load all related entities.
         *
         * 
         * 
         */
    }
}
