using Library.Canvas.Models;

namespace MAUI.Canvas.viewmodels
{
    public class StudentDialogViewModel
    {
        private Person? student;


        public string Name {
            get {return student?.Name ?? string.Empty;}
            set {

                if(student != null) student.Name = value;

            }
        }

        /*
        public string Code {

            

        }
        */

        public StudentDialogViewModel(){


        }

    }
}
