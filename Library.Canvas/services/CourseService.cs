using Library.Canvas.Models;



namespace Library.Canvas.Services {


    public class CourseService {

        StudentService studentCervice;

       

         private List<Course> courseList;
         private static CourseService? _instance;

        


         private CourseService() {

            courseList = new List<Course>();
            studentCervice = StudentService.Current;
        }


        public static CourseService Current {


            get {

                if (_instance == null) {

                    _instance = new CourseService();

                }
                
                return _instance;
            }



        }
        public void Add(Course courseC) {

            courseList.Add(courseC);

        }


        public List<Course> Courses {


            get {

                return courseList;

            }


        }

        public IEnumerable<Course> Search(string query) {

            /*
            var searchQuery = from courseF in courseList
                                where courseF.Name.ToUpper().Contains(query.ToUpper()) || courseF.Code.ToUpper().Contains(query.ToUpper()) || courseF.Description.ToUpper().Contains(query.ToUpper())
                                select courseF;



            List<Course> queryList = searchQuery.ToList();

            return queryList;
            */

            
            return courseList.Where(s => s.Name.ToUpper().Contains(query.ToUpper())
                || s.Description.ToUpper().Contains(query.ToUpper())
                || s.Code.ToUpper().Contains(query.ToUpper()));

            
        }


        public void UpdateCo(Course info) {

            Console.WriteLine("What's the code of the course?");
            var code  = Console.ReadLine();
            info.Code = code ?? string.Empty;
            Console.WriteLine("What's the name of the course?");
            var name  = Console.ReadLine();
            info.Name = name ?? string.Empty;
            Console.WriteLine("What's the description of the course? ");
            var description = Console.ReadLine() ?? string.Empty;
            info.Description = description ?? string.Empty;

            Console.WriteLine("Which students would like to add to this course? Press 'X' to quit");
            //var decision = Console.ReadLine() ?? string.Empty;
            var decision = "Y";
            var roster = new List<Person>();

            while(decision == "Y") {

                studentCervice.Students.Where(s => !roster.Any(s2 => s2.Id == s.Id)).ToList().ForEach(Console.WriteLine);
                var selection = Console.ReadLine() ?? string.Empty;


                //Console.WriteLine("Would you like to add another student?");

                if(selection.Equals("X", StringComparison.InvariantCultureIgnoreCase)) {

                    decision = "X";

                }

                else {

                    var selectedId = int.Parse(selection);
                    var selectedStudent = studentCervice.Students.FirstOrDefault(s => s.Id == selectedId);

                    if(selectedStudent != null) {

                        roster.Add(selectedStudent);

                    }
                    

                    Console.WriteLine("Which students would like to add to this course? Press 'X' to quit");
                }

            }

            info.Roster = roster;



        }








    }








}