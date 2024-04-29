using Library.Canvas.Models;



namespace Library.Canvas.Services
{
    public class ModuleService
    {
         private List<Module> moduleList;
        private static ModuleService? _instance;

        public CourseService courseService;

        private static object _lock = new object();

                  private int LastId
            {

                get
                {
                    if (moduleList.Count == 0)
                        {
                            return 0; // Return 0 when the list is empty
                        }
                     else
                    {
                        return moduleList.Select(c => c.ModuleId).Max();
                    }
                }

            }

            private ModuleService() {

            moduleList = new List<Module>();
            courseService = CourseService.Current;

            }


             public static ModuleService Current {

                get 
                {

                    lock(_lock)
                    {

                      if (_instance == null) 
                        {

                        _instance = new ModuleService();
                    
                        }
                    }
              

                    return _instance;


                }


        }

         public Module? Get(int id) {

            return moduleList.FirstOrDefault(c => c.ModuleId == id);

        }


         public List<Module> Modules {


            get {

                return moduleList;

            }


        }

         public void AddorUpdateModule(Module module, Course course) {

            

            if(module.ModuleId <= 0 )
            {
                moduleList = course.Modules;
                module.ModuleId = LastId + 1;
                course.Modules.Add(module);
            }
     

        }



    }
}
