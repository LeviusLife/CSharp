using System.ComponentModel;
using Library.Canvas.Models;
using Library.Canvas.Services;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace MAUI.Canvas.viewmodels;

//put INotifyPropertyChanged right ***************** here

//[QueryProperty(nameof(StudentId), "studentId")]
public class InstructorEnrollmentViewModel
{

   /*
    public int StudentId
		{
			get; set;
		}
        */
    private Person? studentEnroll;
  
      public string Name {
            get {return studentEnroll?.Name ?? string.Empty;}
            set {

                if(studentEnroll == null) studentEnroll = new Person();
                
                studentEnroll.Name = value;

            }
        }


        
        //what are these properties for? I've already forgotten. 
        public string Classification  {

            get {return studentEnroll?.Classification ?? string.Empty;}
            set { 
                if(studentEnroll == null) studentEnroll = new Person();
                studentEnroll.Classification = value;}

        }


        public int studentIdForEnrollment {

            get; set;
            
            /*
            set {

                if (studentIdForEnrollment != value) 
                {

                    studentIdForEnrollment = value;

                }

            }
            */
        }
        
    public InstructorEnrollmentViewModel() {
        
        courseSvcForEnrollment = CourseService.Current;
        studentSvcForEnrollment = StudentService.Current;
        
    }

    public InstructorEnrollmentViewModel(int sId)
    {


        courseSvcForEnrollment = CourseService.Current;
        studentSvcForEnrollment = StudentService.Current;
        
        if (sId == 0) {

            //what should I do if it is 0?

        }

        else {

            studentIdForEnrollment = sId;

        }



    }
   
   /*
    
     public InstructorEnrollmentViewModel(int sId) {
      
      /*
        
       if(sId == 0) 
            {
                studentEnroll = new Person();

            }

            else {

                studentEnroll = StudentService.Current.Get(sId) ?? new Person();


            }
            
    }

    */
    
    
    
     private CourseService courseSvcForEnrollment;
     private StudentService studentSvcForEnrollment;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


         public string? QueryForEnrollment {get; set;}

         public ObservableCollection<Course> Coursez {

            get{

                return new ObservableCollection<Course>(courseSvcForEnrollment.Courses);

            }


        }
        

      /*  
        public ObservableCollection<Person> Roster {

            get {

                return new ObservableCollection<Person>(SelectedCourse?.Roster);

            }


        }
        */

        
        public List<Person> Roster => SelectedCourse?.Roster;

        /*
        public ObservableCollection<Course> Roster {

            get {

                return new ObservableCollection<Course>(courseSvcForEnrollment.Current)
            }


        }

    */


        
         public Course? SelectedCourse{

            get; set;

        } = new Course();
        


        public void RefreshView()
        {
            //NotifyPropertyChanged(nameof(People));
            NotifyPropertyChanged(nameof(Coursez));
            NotifyPropertyChanged(nameof(Roster));
        }



       public void AddFakeStudents(string cId)
       {
            foreach(var studentstuff in studentSvcForEnrollment.Students){
                 SelectedCourse?.Roster.Add(studentstuff);
            }

            RefreshView();
           

       }

       public void AddStudenttoCourse(int cId) 
       {    
        
            //courseSvcForEnrollment.Get(cId).Roster.Contains();
            //this is checking to see if a specific item with the course's list of rosters has the id studentEnrollment
            var found = courseSvcForEnrollment.Get(cId)!.Roster.FirstOrDefault( c => c.Id == studentIdForEnrollment);

            //if there isnt a specific item within the course's list of rosters that have the same id as StudentEnrollment
            if (found == null) {

                courseSvcForEnrollment.Get(cId)!.Roster.Add(studentSvcForEnrollment.Get(studentIdForEnrollment)!);


             }
            //int realNumber = int.Parse(cId);
            //if(courseSvcForEnrollment.Get(cId).Contain)
         
           
        
       }

      



}

