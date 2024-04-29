using Library.Canvas.Models;
using Library.Canvas.Services;

namespace MAUI.Canvas.viewmodels
{
    public class ModuleDialogViewModel
    {

        private CourseService courseSvcForModules;

        private Module? Module;


         public int moduleIdForCourse { get; set; }

         public string Name {
            get {return Module?.Name ?? string.Empty;}
            set {

                if(Module == null) Module = new Module();
                
                Module.Name = value;

            }
        }


        public string Description {

            get {return Module?.Description ?? string.Empty;}
            set{

                 if(Module == null) Module = new Module();
                
                Module.Description = value;

            }

        }

        public int CourseIdForMending {

            get; set;


        }

        public ModuleDialogViewModel(){

            courseSvcForModules = CourseService.Current;

        }

         public ModuleDialogViewModel(int mId){


            courseSvcForModules = CourseService.Current;

             if (mId == 0) {

                moduleIdForCourse = 0; 
                Module = new Module();
                //I might need to make a new Assignment and store the property as a 0 here

            }

            else {

                moduleIdForCourse = mId;
                Module = ModuleService.Current.Get(mId) ?? new Module();
                //the property will have the value set and stored here


            }




        }


         public void AddModuletoCourse() {
              
            var courseId = courseSvcForModules.CurrentId;

            if (courseId > 0)
                {
                    var course = courseSvcForModules.Get(courseId);

                    if (course != null)
                        {
                            //if the course exists then fill in this viewmodel's property for courses
                            CourseIdForMending = courseId;
                            ModuleService.Current.AddorUpdateModule(Module, course);
                        }

                }
                
            
            

        }




    }
}
