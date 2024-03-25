using Library.Canvas.Models;

namespace MAUI.Canvas.viewmodels
{
    public class InstructorDialogViewModel
    {

         private Person? student;


        public string Name {
            get {return student?.Name ?? string.Empty;}
            set {

                if(student != null) student = new Person();
                
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

            student = new Person { Id=101, Name="Terry",  Classification="Freshmen"};

        }







    }
}
