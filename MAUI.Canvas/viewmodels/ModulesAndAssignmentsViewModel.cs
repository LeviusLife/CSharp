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

        public ModuleService moduleSvcShit;

         public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public string? Query {get; set;} = "";

        public ObservableCollection<Assignment> Assignmentz {


            get
            {


                return new ObservableCollection<Assignment>(assignmentSvcShit.Assignments.Where(c => c?.Name?.ToUpper()?.Contains(Query?.ToUpper() ?? string.Empty)?? false));
            }


        }

        /*
        public ObservableCollection<Assignment> Assignmentzaz {


            get {

                return new ObservableCollection<Assignment>(IdForShippment.Get(CourseIdForMA).Assignments);

            }


        }
        */

        public ObservableCollection<Assignment> Assignmentzaz {

            
            get {
                
                   int somethin = IdForShippment.CurrentId;

                if (somethin == 0)
                    {
                        // Handle case when CourseIdForMA is 0
                        return new ObservableCollection<Assignment>();
                    }
                else
                    {
                     
                        return new ObservableCollection<Assignment>(IdForShippment.Get(somethin).Assignments);
                    }
                //return new ObservableCollection<Assignment>(IdForShippment.Get(CourseIdForMA).Assignments);

            }


        }


         public ObservableCollection<Module> Modulez {

            
            get {
                
                   int somethin = IdForShippment.CurrentId;

                if (somethin == 0)
                    {
                        // Handle case when CourseIdForMA is 0
                        return new ObservableCollection<Module>();
                    }
                else
                    {
                     
                        return new ObservableCollection<Module>(IdForShippment.Get(somethin).Modules);

                        
                    }
                //return new ObservableCollection<Assignment>(IdForShippment.Get(CourseIdForMA).Assignments);

            }


        }

        public Assignment? SelectedAssignment{

            get; set;

        } = new Assignment();

        public Module? SelectedModule{

            get; set;

        } = new Module();




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
        moduleSvcShit = ModuleService.Current;
        Query = "";
        
        //if the default constructor is called then what should be stored within the CourseIdForMA?
    }

    public ModulesAndAssignmentsViewModel(int cId)
    {

        IsModulesVisible = true;
        IsAssignmentsVisible = false;
        IdForShippment = CourseService.Current;
        assignmentSvcShit = AssignmentService.Current;
        moduleSvcShit = ModuleService.Current;
        Query = "";

         if (cId == 0) {

            //what should I do if it is 0?

        }

        else {

            CourseIdForMA = cId;
            IdForShippment.CurrentId = cId;

        }
        

    }

    public void RemoveAssignment() {

            if(SelectedAssignment != null) {
                //studentSvc.Remove(SelectedStudent);
                assignmentSvcShit.Assignments.Remove(SelectedAssignment);
                 Refresh();
            }
            
           
        }

    public void RemoveModule() {

            //I'm not sure if that's doing what i think its doing
            //i think its only deleting from the list of Modules and not deleting from the course's list of Modules

            if(SelectedModule != null) {
                //studentSvc.Remove(SelectedStudent);
                moduleSvcShit.Modules.Remove(SelectedModule);
                 Refresh();
            }
            
           
        }

     public void Refresh() {

          
            NotifyPropertyChanged(nameof(Assignmentzaz));
            NotifyPropertyChanged(nameof(Modulez));


        }








}
