using System.Configuration.Assemblies;
using System.Data.Common;

using Library.Canvas.Models;
using Library.Canvas.Services;

namespace Canvas {

    internal class PersonHelper {

        //private List<Person> studentList = new List<Person>();
        private StudentService studentService;
        private CourseService courseService;


        public PersonHelper() {

            studentService = StudentService.Current;
            courseService = CourseService.Current;

        }


        public void CreateStudentRecord() {
            
            Console.WriteLine("What's the student's id?");
            var id = Console.ReadLine();

            Console.WriteLine("What's the name of the student?");
            var name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("What's the classification of the student? [FRE for Freshmen, SOP for Sophmore, JUN for junior, and SEN for Senior]");
            var classification = Console.ReadLine() ?? string.Empty;

            StudentClassification studentEnum;


            
            if (classification.Equals("FRE", StringComparison.InvariantCultureIgnoreCase)) {

                studentEnum = StudentClassification.Freshman;


            }

            else if (classification.Equals("SOP", StringComparison.InvariantCultureIgnoreCase)) {

                 studentEnum = StudentClassification.Sophmore;
            }

            else if (classification.Equals("JUN", StringComparison.InvariantCultureIgnoreCase)) {

                 studentEnum = StudentClassification.Junior;

            }

            else if (classification.Equals("SEN", StringComparison.InvariantCultureIgnoreCase)) {

                 studentEnum = StudentClassification.Senior;

            }


            else {

                studentEnum = StudentClassification.Freshman;


            }

            var student = new Person 
            {

                Id = int.Parse(id ?? "0"),

                Name = name ?? string.Empty,
                
                
                //Classification = string.IsNullOrEmpty(classification) ? "FRE" : classification.ToUpper()

                Classification = studentEnum.ToString()

            };


            studentService.Add(student);

            //studentList.ForEach(student => Console.WriteLine(student));
            //studentService.studentList.ForEach(Console.WriteLine);


            //what the hell does ?? do again?
            //what does

        }


         public void UpdateStudent() {

            Console.WriteLine("Select a student to update: ");
            ListAll();

            var selectionStr = Console.ReadLine();

            if(int.TryParse(selectionStr, out int selectionInt)) {

                var selectedStudent = studentService.Students.FirstOrDefault(s => s.Id == selectionInt);
                if(selectedStudent == null) {

                    CreateStudentRecord();

                }

                else if (selectedStudent != null) {

                    studentService.UpdateStu(selectedStudent);


                }


            }


        }


        public void ListAll() {


            studentService.Students.ForEach(Console.WriteLine);
            
            Console.WriteLine("Select a student");
            var selectionStr = Console.ReadLine();
            var selectionInt = int.Parse(selectionStr ?? "0");

            Console.WriteLine("Student Course List");
            var query = from item in courseService.Courses
                        where (item.Roster.Any(s => s.Id == selectionInt))
                        select item;

            List<Course> queryList = query.ToList();
            queryList.ForEach(Console.WriteLine);

        }


        public void SearchStudent() {

            Console.WriteLine("Which student would you like to search for: ");
            var query = Console.ReadLine() ?? string.Empty;

            
            studentService.Search(query).ForEach(Console.WriteLine);
            //
            Console.WriteLine("Select a student");
            var selectionStr = Console.ReadLine();
            var selectionInt = int.Parse(selectionStr ?? "0");

            Console.WriteLine("Student Course List");
            var queryC = from item in courseService.Courses
                        where (item.Roster.Any(s => s.Id == selectionInt))
                        select item;

            List<Course> queryList = queryC.ToList();
            queryList.ForEach(Console.WriteLine);



        }




    }






}