using Library.Canvas.Models;
using Library.Canvas.Services;


namespace Canvas {


    public class CourseHelper {

        private CourseService courseService;
        private StudentService personService;

        public CourseHelper() {

            personService = StudentService.Current;
            courseService = CourseService.Current;

        }


        public void CreateCourseRecord() {

            Console.WriteLine("What's the code of the course?");
            var code  = Console.ReadLine();
            Console.WriteLine("What's the name of the course?");
            var name  = Console.ReadLine();
            Console.WriteLine("What's the description of the course? ");
            var description = Console.ReadLine() ?? string.Empty;


            var course = new Course {

                Code = code,
                Name = name,
                Description = description

            };

            Console.WriteLine("Which students would like to add to this course? Press 'X' to quit");
            //var decision = Console.ReadLine() ?? string.Empty;
            var decision = "Y";
            var roster = new List<Person>();

            while(decision == "Y") {

                personService.Students.Where(s => !roster.Any(s2 => s2.Id == s.Id)).ToList().ForEach(Console.WriteLine);
                var selection = Console.ReadLine() ?? string.Empty;


                //Console.WriteLine("Would you like to add another student?");

                if(selection.Equals("X", StringComparison.InvariantCultureIgnoreCase)) {

                    decision = "X";

                }

                else {

                    var selectedId = int.Parse(selection);
                    var selectedStudent = personService.Students.FirstOrDefault(s => s.Id == selectedId);

                    if(selectedStudent != null) {

                        roster.Add(selectedStudent);

                    }
                    

                    Console.WriteLine("Which students would like to add to this course? Press 'X' to quit");
                }

            }


            Console.WriteLine("Would you like to add assignments to this course? (Y/N)");
            var assignResponse = Console.ReadLine() ?? "N";
            var assignments = new List<Assignment>();
            if(assignResponse.Equals("Y", StringComparison.InvariantCultureIgnoreCase )) {
                decision = "Y";
                while(decision.Equals("Y")) {

                    Console.WriteLine("What's the name of the assignment?");
                var assignName  = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("What's the description of the assignment?");
                var assignDescription  = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("What are the total points of the assignment? ");
                var totalPoints = decimal.Parse(Console.ReadLine() ?? "100");
                Console.WriteLine("What's the due date of said assignment?");
                var assignDueDate = DateTime.Parse(Console.ReadLine() ?? "01/01/1900");

                assignments.Add(new Assignment {

                    Name = assignName,
                    Description = assignDescription,
                    TotalAvailablePoints = totalPoints,
                    DueDate = assignDueDate


                });


                Console.WriteLine("Would you like to add more courses? (Y/N)");
                assignResponse = Console.ReadLine() ?? "N";
                if(assignResponse.Equals("N", StringComparison.InvariantCultureIgnoreCase)) {

                    decision = "N";

                }


                }

                




            }





            course.Roster = roster;
            course.Assignments = assignments;


            courseService.Add(course);



        }




         public void UpdateCourse() {

            Console.WriteLine("Select a course to update: ");
            ListCourses();

            var selectionStr = Console.ReadLine();


                var selectedCourse = courseService.Courses.FirstOrDefault(s => s.Code.Equals(selectionStr, StringComparison.InvariantCultureIgnoreCase));
                if(selectedCourse == null) {

                    CreateCourseRecord();

                }

                else if (selectedCourse != null) {

                    courseService.UpdateCo(selectedCourse);


                }


            


        }





         public void ListCourses() {

            Action<Course> printCourses = course => Console.WriteLine($"{course.Code} - {course.Name}");
            courseService.Courses.ForEach(printCourses);

            


        }

       public void SearchCourse() {

            Console.WriteLine("Which course would you like to search for: ");
            var query = Console.ReadLine() ?? string.Empty;

            
            courseService.Search(query).ForEach(Console.WriteLine);

            
            
            
        }

       

    }




}