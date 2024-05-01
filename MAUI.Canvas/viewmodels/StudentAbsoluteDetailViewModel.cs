using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Library.Canvas.Models;
using Library.Canvas.Services;

namespace MAUI.Canvas.viewmodels;

public class StudentAbsoluteDetailViewModel: INotifyPropertyChanged
{

    public CourseService courseSvcShenanigans;
     public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        
        
         public ObservableCollection<Module> Moduleszsz {

            
            get {
                
                   int somethin = courseSvcShenanigans.CurrentId;

                if (somethin == 0)
                    {
                        // Handle case when CourseIdForMA is 0
                        return new ObservableCollection<Module>();
                    }
                else
                    {
                     
                        return new ObservableCollection<Module>(courseSvcShenanigans.Get(somethin).Modules);

                        
                    }
                //return new ObservableCollection<Assignment>(IdForShippment.Get(CourseIdForMA).Assignments);

            }


        }
        

         public StudentAbsoluteDetailViewModel(int cId)
    {

       
        courseSvcShenanigans = CourseService.Current;
        //moduleSvcShit = ModuleService.Current;
      

         if (cId == 0) {

            //what should I do if it is 0?

        }

        else {

            courseSvcShenanigans.CurrentId = cId;

        }
        

    }

     public void RefreshModules() {

            NotifyPropertyChanged(nameof(Moduleszsz));


        }


        

}
