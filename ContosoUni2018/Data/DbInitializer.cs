using ContosoUni2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUni2018.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            //EnsureCreated method will automaticaly create the database if it doesn't 
            //already exists.
            context.Database.EnsureCreated();

            //First look for any students
            //============================= Students =============================//
            if(context.Students.Any()) //checks to see if there is students
            {
                //database has already been populated with students
                return;//exits
            }
            //if we get here - students do not already exits (populated)
            //we create a new Student array
            var students = new Student[]
            {
                new Student
                {
                    FirstName = "carson",
                    LastName = "alexander",
                    Email = "calexander@contoso.com",
                    EnrollmentDate = DateTime.Parse("2017-09-01"),
                    Address = "4 Flanders court",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "e1c 0k6",
                },
                new Student
                {
                    FirstName = "meridith",
                    LastName = "alonso",
                    Email = "malonso@contoso.com",
                    EnrollmentDate = DateTime.Parse("2017-09-01"),
                    Address = "205 argle street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "e1c 4k1",
                }
            };

            //loop the student array and add each student to the database context
            foreach(Student s in students)
            {
                context.Students.Add(s);
            }

            //save the context
            context.SaveChanges();

            //============================== Instructors ==========================//
            var instructors = new Instructor[]
            {
                new Instructor
                {
                    FirstName = "denis",
                    LastName = "gaudet",
                    Email = "jabrony@hotmail.com",
                    HireDate = DateTime.Parse("2009-12-06"),
                    Address = "123 jabrony drive",
                    City = "12 Here",
                    Province = "BNT",
                    PostalCode = "3e3 4r5"
                },
                new Instructor
                {
                    FirstName = "luc",
                    LastName = "smith",
                    Email = "jab@hotmail.com",
                    HireDate = DateTime.Parse("2009-12-06"),
                    Address = "145 jabrony ave",
                    City = "12 Here",
                    Province = "BNT",
                    PostalCode = "3e3 4r5"
                }
            };
            foreach(Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            //save is
            context.SaveChanges();

            //============================== Courses ==========================//
            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4055,Title="MIcroEconomics",Credits=3},
            };
            foreach(Course c in courses)
            {
                context.Add(c);
            }
            context.SaveChanges();

            //============================== Enrollment ==========================//
            var enrollments = new Enrollment[]
            {
                new Enrollment{CourseID= 1050,
                               StudentID= students.Single(s=>s.LastName=="gaudet").ID,
                               Grade = Grade.A},
                new Enrollment{CourseID= 4022,
                               StudentID= students.Single(s=>s.LastName=="smith").ID,
                                Grade = Grade.B},
            };
            foreach(Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
