using Library.Canvas.Models;
using Library.Canvas.Services;

namespace MAUI.Canvas.viewmodels
{
    public class InstructorDialogViewModel
    {

         private Person? student;


        public string Name {
            get {return student?.Name ?? string.Empty;}
            set {

                if(student == null) student = new Person();
                
                student.Name = value;

            }
        }

        
        public string Classification  {

            get {return student?.Classification ?? string.Empty;}
            set { 
                if(student == null) student = new Person();
                student.Classification = value;}

        }
        


        public InstructorDialogViewModel(){

            student = new Person();

        }


        public void AddStudent() {

            if(student != null){

                StudentService.Current.AddorUpdate(student);

            }


        }






    }
}
