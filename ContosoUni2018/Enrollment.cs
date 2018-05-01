namespace ContosoUni2018.Models
{
    public class Enrollment
    {

        /*
         * The EnrollmentID property will be the primary key: thei entity used the ClassNameID pattern
         * instead of the ID by itself that ou have in the Student Entity
         */
        public int EnrollmentID { get; set; } //PK
        public int CourseID { get; set; } //FK with the corresponding navigation property Course
        public int StudentID { get; set; } //FK with the corresponding navigation property Student
        public Grade? Grade { get; set; } // the ? is nullable because we dont' start with a grade

        //navigation propety: each enrollment must be for one student
        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }

    //grade enumeration
    public enum Grade
    {
        A, B, C, D, F
    }
}