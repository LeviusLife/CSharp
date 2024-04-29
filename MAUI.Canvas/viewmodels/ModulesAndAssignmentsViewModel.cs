using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Library.Canvas.Models;
using Library.Canvas.Services;



namespace MAUI.Canvas.viewmodels;

internal class ModulesAndAssignmentsViewModel: INotifyPropertyChanged
{
        public CourseService IdForShippment;

        public AssignmentService assignmentSvcShit;

         public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public string Query {get; set;}

        public ObservableCollection<Assignment> Assignmentz {


            get
            {


                return new ObservableCollection<Assignment>(assignmentSvcShit.Assignments.Where(c => c?.Name?.ToUpper()?.Contains(Query?.ToUpper() ?? string.Empty)?? false));
            }


        }

        public Assignment? SelectedAssignment{

            get; set;

        } = new Assignment();




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
        IdForShippment = CourseService.Current;
        assignmentSvcShit = AssignmentService.Current;

        
        //if the default constructor is called then what should be stored within the CourseIdForMA?
    }

    public ModulesAndAssignmentsViewModel(int cId)
    {

        IsModulesVisible = true;
        IsAssignmentsVisible = false;
        IdForShippment = CourseService.Current;
        assignmentSvcShit = AssignmentService.Current;

         if (cId == 0) {

            //what should I do if it is 0?

        }

        else {

            CourseIdForMA = cId;
            IdForShippment.CurrentId = cId;

        }
        

    }

     public void Refresh() {

          
            NotifyPropertyChanged(nameof(Assignmentz));

        }








}
