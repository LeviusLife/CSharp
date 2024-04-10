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

    }

     private CourseService courseSvcForEnrollment;

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



         public Course? SelectedCourse{

            get; set;

        } = new Course();


        public void RefreshView()
        {
            //NotifyPropertyChanged(nameof(People));
            NotifyPropertyChanged(nameof(Coursez));
        }


}

