using System;
using System.Diagnostics;
using System.Net;

namespace Canvas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool something = true;
            var PersonHelper = new PersonHelper();
            var CourseHelper = new CourseHelper();
            Console.WriteLine("Welcome to Canvas!");
            while (something) {

                

                
                Console.WriteLine("A. Add a Student");
                Console.WriteLine("B. Update Student");
                Console.WriteLine("C. List all Students");
                Console.WriteLine("D. Search for Student");
                Console.WriteLine("E. Add a new course");
                Console.WriteLine("F. Update Course Info");
                Console.WriteLine("G. List all Courses");
                Console.WriteLine("H. Search for Course");
                Console.WriteLine("I. Exit the program");
                string? choice = Console.ReadLine();

                var length = choice?.Length ?? 0;


                switch (choice) {

                    case "A":
                    case "a":
                    PersonHelper.CreateStudentRecord();

                    break;


                    case "B":
                    case "b":
                    PersonHelper.UpdateStudent();

                    break;



                    case "C":
                    case "c":
                    PersonHelper.ListAll();

                    break;




                    case "D":
                    case "d":
                    PersonHelper.SearchStudent();

                    break;



                    case "E":
                    case "e":
                    CourseHelper.CreateCourseRecord();

                    break;



                    case "F":
                    case "f":
                    CourseHelper.UpdateCourse();

                    break;





                    case "G":
                    case "g":
                    CourseHelper.ListCourses();

                        break;



                    case "H":
                    case "h":
                    CourseHelper.SearchCourse();

                        break;


                    case "I":
                    case "i":
                        something = false;
                        break;




                }



            }
            

            


        }
    }





}

//a field is just a data member within a class or struct
//what does the word api mean?


//frontend deals with how the application feels and looks on the user's side
//backend deals with the server side. it deals with the business logic, data base operations,
//etc.


//FRE , SOP, JUN, SEN
