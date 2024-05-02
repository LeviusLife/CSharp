
using Library.Canvas.Models;
using Library.Canvas.Services;


namespace MAUI.Canvas.viewmodels
{
    public class AssignmentDialogViewModel
    {
         private CourseService courseSvcForAssignment;
        private StudentService studentSvcForAssignment;

        private AssignmentService assignmentSvcForAssignment;

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


        public decimal TotalAvailablePoints{

            get;

            set;
            

        }


         public DateTime DueDate{

            get;

            set;

            

        }

        public int CourseIdForSending {

            get; set;


        }


/*
         public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

      */ 



        public AssignmentDialogViewModel(){

            
        courseSvcForAssignment = CourseService.Current;
        studentSvcForAssignment = StudentService.Current;
        assignmentSvcForAssignment = AssignmentService.Current;

        }

        public AssignmentDialogViewModel(int aId){

            
        courseSvcForAssignment = CourseService.Current;
        studentSvcForAssignment = StudentService.Current;
        assignmentSvcForAssignment = AssignmentService.Current;

             if (aId == 0) {

                assignmentIdForCourse = 0; 
                Assignment = new Assignment();
                //I might need to make a new Assignment and store the property as a 0 here

            }

            else {

                assignmentIdForCourse = aId;
                Assignment = AssignmentService.Current.Get(aId) ?? new Assignment();
                //the property will have the value set and stored here


            }



        }


        public void AddAssignmenttoCourse() {
              
            var courseId = courseSvcForAssignment.CurrentId;

            if (courseId > 0)
                {
                    var course = courseSvcForAssignment.Get(courseId);

                    if (course != null)
                        {
                            //if the course exists then fill in this viewmodel's property for courses
                            CourseIdForSending = courseId;
                            AssignmentService.Current.AddorUpdateAssignment(Assignment, course);
                        }

                }
                
            
            

        }




         public void AddAssignment() {

            if(Assignment != null){

                AssignmentService.Current.AddorUpdateAssignment(Assignment);

            }


        }



    }








}
