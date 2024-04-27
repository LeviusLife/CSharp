using Library.Canvas.Models;
using Library.Canvas.Services;


namespace MAUI.Canvas.viewmodels
{
    public class AssignmentDialogViewModel
    {
         private CourseService courseSvcForAssignment;
        private StudentService studentSvcForAssignment;

        private Assignment? Assignment;
    

        public int assignmentIdForCourse { get; set; }


        public string Name {
            get {return Assignment?.Name ?? string.Empty;}
            set {

                if(Assignment == null) Assignment = new Assignment();
                
                Assignment.Name = value;

            }
        }


        public string Description {

            get {return Assignment?.Description ?? string.Empty;}
            set{

                 if(Assignment == null) Assignment = new Assignment();
                
                Assignment.Description = value;

            }

        }



        public AssignmentDialogViewModel(){

            
        courseSvcForAssignment = CourseService.Current;
        studentSvcForAssignment = StudentService.Current;

        }

        public AssignmentDialogViewModel(int aId){

            
        courseSvcForAssignment = CourseService.Current;
        studentSvcForAssignment = StudentService.Current;

             if (aId == 0) {

                assignmentIdForCourse = 0; 
                //I might need to make a new Assignment and store the property as a 0 here

            }

            else {

                assignmentIdForCourse = aId;
                //the property will have the value set and stored here


            }



        }


        public void AddAssignmenttoCourse(int cId) {
            /*
            if (assignmentIdForCourse > 0) {

                (BindingContext as ModulesAndAssignmentsViewModel)?.AddAssignmentS(assignmentIdForCourse);

            }
            */

        }



    }








}
