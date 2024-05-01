using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Library.Canvas.Models;
using Library.Canvas.Services;


namespace MAUI.Canvas.viewmodels
{
    public class CoursesViewModel: INotifyPropertyChanged
    {

        public StudentService studentSVCthingy;
        public CourseService courseSVCthingy;
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

         private Person? student;

        public CoursesViewModel(int sId) {

            studentSVCthingy = StudentService.Current;
            courseSVCthingy = CourseService.Current;

             if(sId == 0) 
            {
                //course = new Course();

            }

            else {

                studentSVCthingy.CurrentId = sId;
                student = StudentService.Current.Get(sId) ?? new Person();


            }



        }


         public ObservableCollection<Course> Coursezaz {

            
            get {
                
                   int somethin = studentSVCthingy.CurrentId;

                if (somethin == 0)
                    {
                        // Handle case when CourseIdForMA is 0
                        return new ObservableCollection<Course>();
                    }
                else
                    {

                        //List<Course> coursesWithStudent = courseSVCthingy.Courses.Where(c => c.Roster.Any(p => p.Id == somethin)).ToList();

                        /*
                        .Select(e => e.Id)
                        .Where(c => c.Id == somethin)
                        */

                        return new ObservableCollection<Course>(courseSVCthingy.Courses.Where(c => c.Roster.Any(p => p.Id == somethin)).ToList());
                    }
                //return new ObservableCollection<Assignment>(IdForShippment.Get(CourseIdForMA).Assignments);

            }


        }


         public Course? SelectedCourse{

            get; set;

        } = new Course();


        public void Refresh() {

          
            NotifyPropertyChanged(nameof(Coursezaz));
            

        }



    }
}
