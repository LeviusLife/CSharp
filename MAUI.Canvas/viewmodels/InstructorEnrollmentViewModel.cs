using System.ComponentModel;
using Library.Canvas.Models;
using Library.Canvas.Services;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace MAUI.Canvas.viewmodels;

public class InstructorEnrollmentViewModel: INotifyPropertyChanged
{

    public InstructorEnrollmentViewModel() {

         courseSvcForEnrollment = CourseService.Current;
         studentSvcForEnrollment = StudentService.Current;

    }

     private CourseService courseSvcForEnrollment;
     private StudentService studentSvcForEnrollment;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


         public string? Query {get; set;}

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



}

