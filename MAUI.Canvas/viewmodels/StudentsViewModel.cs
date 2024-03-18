using System.Collections.ObjectModel;
using AddressBook;
using Library.Canvas.Models;
using Library.Canvas.Services;

namespace MAUI.Canvas.viewmodels
{

    public class StudentsViewModel
    {

        //private Person underlyingPerson;

        private StudentService studentSvc;

        public ObservableCollection<Person> Students {


            get
            {
                return new ObservableCollection<Person>(studentSvc.Students);
            }


        }

        /*
        public string StudentName {

            get  {

                return underlyingPerson?.Name ?? string.Empty;
            }

            set {

                underlyingPerson.Name = value;

            }


        }

        */

        public StudentsViewModel() {

            //underlyingPerson = new Person { Name = "My Test Student"};

            studentSvc = StudentService.Current;
        }
    }


}
