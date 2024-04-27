using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Library.Canvas.Models;
using Library.Canvas.Services;



namespace MAUI.Canvas.viewmodels;

internal class ModulesAndAssignmentsViewModel: INotifyPropertyChanged
{


         public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public int CourseIdForMA
        {
            get; set;

        }

             public bool IsModulesVisible
        {
            get; set;
        }


         public bool IsAssignmentsVisible
        {
            get; set;
        }

         public void ShowModules()
        {
            IsModulesVisible = true;
            IsAssignmentsVisible = false;
            NotifyPropertyChanged("IsModulesVisible");
            NotifyPropertyChanged("IsAssignmentsVisible");
        }

         public void ShowAssignments()
        {
            IsModulesVisible = false;
            IsAssignmentsVisible = true;
           NotifyPropertyChanged("IsModulesVisible");
            NotifyPropertyChanged("IsAssignmentsVisible");
        }

    public ModulesAndAssignmentsViewModel()
    {

        IsModulesVisible = true;
        IsAssignmentsVisible = false;
        

    }

    public ModulesAndAssignmentsViewModel(int cId)
    {

        IsModulesVisible = true;
        IsAssignmentsVisible = false;

         if (cId == 0) {

            //what should I do if it is 0?

        }

        else {

            CourseIdForMA = cId;

        }
        

    }







}
