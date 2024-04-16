
using Library.Canvas.Models;
using Library.Canvas.Services;




namespace MAUI.Canvas.viewmodels
{
    public class CourseDialogViewModel
    {

         private Course? course;


         public string Description {

            get { return course?.Description ?? string.Empty;}
            set {

                if(course == null) course = new Course();
                course.Description = value;
            }

        }

        public string Code {

            get { return course?.Code ?? string.Empty;}
            set {

                if(course == null) course = new Course();
                course.Code = value;
            }



        }

        public string Name {

            get { return course?.Name ?? string.Empty;}
            set {

                if(course == null) course = new Course();
                course.Name = value;

            }

        }
        

        public CourseDialogViewModel() {
            
        }



    }
}
