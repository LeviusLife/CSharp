﻿using Library.Canvas.Models;



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
                    return assignmentList.Select(c => c.AssignmentId).Max();
                }

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




    }
}