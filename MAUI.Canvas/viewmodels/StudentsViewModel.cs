using AddressBook;
using Library.Canvas.Models;

namespace MAUI.Canvas.viewmodels
{

    public class StudentsViewModel
    {

        private Person underlyingPerson;


        public string StudentName {

            get  {

                return underlyingPerson?.Name ?? string.Empty;
            }

            set {

                underlyingPerson.Name = value;

            }


        }

        public StudentsViewModel() {

            underlyingPerson = new Person { Name = "My Test Student"};
        }
    }


}
