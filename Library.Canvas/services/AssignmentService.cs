using Library.Canvas.Models;



namespace Library.Canvas.Services
{
    public class AssignmentService
    {

        private List<Assignment> assignmentList;
        private static AssignmentService? _instance;

        public CourseService courseService;
        private static object _lock = new object();

        
             private int LastId
            {

                get
                {
                    if (assignmentList.Count == 0)
                        {
                            return 0; // Return 0 when the list is empty
                        }
                     else
                    {
                        return assignmentList.Select(c => c.AssignmentId).Max();
                    }
                }

            }

             public int CurrentId {

                get; set;


            }


         private AssignmentService() {

            assignmentList = new List<Assignment>();
            courseService = CourseService.Current;

        }

         public static AssignmentService Current {

            get {

                lock(_lock){

                      if (_instance == null) {

                    _instance = new AssignmentService();
                    
                }
                }
              

                return _instance;


            }


        }


         public Assignment? Get(int id) {

            return assignmentList.FirstOrDefault(c => c.AssignmentId == id);

        }

         public List<Assignment> Assignments {


            get {

                return assignmentList;

            }


        }

         public void AddorUpdateAssignment(Assignment assignment) {

            

            if(assignment.AssignmentId <= 0 )
            {

                assignment.AssignmentId = LastId + 1;
                assignmentList.Add(assignment);
            }
     

        }

        public void AddorUpdateAssignment(Assignment assignment, Course course) {

            

            if(assignment.AssignmentId <= 0 )
            {
                assignmentList = course.Assignments;
                assignment.AssignmentId = LastId + 1;
                course.Assignments.Add(assignment);
            }
     

        }

        public int GiveMeTheIdPlease() {

            int differentLastId;

            return differentLastId = LastId;


        }




    }
}
