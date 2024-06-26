
using System.Reflection.Metadata.Ecma335;
using Library.Canvas.Models;



namespace Library.Canvas.Services {


    public class StudentService {

        //private List<Person> studentList = new List<Person>();
        private List<Person> studentList;

        private static object _lock = new object();
        private static StudentService? _instance;

        private int LastId
        {

            get
            {
                return studentList.Select(c => c.Id).Max();
            }

        }

         public int CurrentId {

            get; set;

         }

        private StudentService() {

            studentList = new List<Person> {

                new Person{Name= "TestStudent 1", Classification="Freshman", Id=1},
                new Person{Name= "TestStudent 2", Classification="Freshman", Id=2},
                new Person{Name= "TestStudent 3", Classification="Freshman", Id=3},
                new Person{Name= "TestStudent 4", Classification="Freshman", Id=4},
                new Person{Name= "TestStudent 5", Classification="Freshman", Id=5},

            };

        }

        public Person? Get(int id) {

            return studentList.FirstOrDefault(c => c.Id == id);

        }

        public static StudentService Current {

            get {

                lock(_lock){

                      if (_instance == null) {

                    _instance = new StudentService();
                    
                }
                }
              

                return _instance;


            }


        }

        public void AddorUpdate(Person student) {

            if(student.Id <= 0 )
            {
                student.Id = LastId + 1;
                studentList.Add(student);
            }

            

        }

        public void Remove(Person student) {

            studentList.Remove(student);

        }

        public List<Person> Students {


            get {

                return studentList;

            }


        }


        public List<Person> Search(string query) {

            var searchQuery = from person in studentList
                                where person.Name.ToUpper().Contains(query.ToUpper())
                                select person;


            List<Person> queryList = searchQuery.ToList();

            return queryList;


        }


        public void UpdateStu(Person giggity) {


            
            
            Console.WriteLine("What's the student's new id?");
            var id = Console.ReadLine();
            giggity.Id = int.Parse(id ?? "0");

            Console.WriteLine("What's the name of the student?");
            var name = Console.ReadLine() ?? string.Empty;
            giggity.Name = name ?? string.Empty;
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


            giggity.Classification = studentEnum.ToString();

           
           

            //studentList.ForEach(student => Console.WriteLine(student));
            //studentService.studentList.ForEach(Console.WriteLine);


            //what the hell does ?? do again?
            //what does

        


        
        }



    }

}