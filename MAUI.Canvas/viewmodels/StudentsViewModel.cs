using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AddressBook;
using Library.Canvas.Models;
using Library.Canvas.Services;

namespace MAUI.Canvas.viewmodels
{

    internal class StudentsViewModel : INotifyPropertyChanged
    {

        //private Person underlyingPerson;

        private StudentService studentSvc;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


         public string Query {get; set;}



        public ObservableCollection<Person> Students {


            get
            {
                return new ObservableCollection<Person>(studentSvc.Students);
            }


        }


        public void AddStudent() {

            studentSvc.AddorUpdate(new Person { Name = "This is a new client"});
            NotifyPropertyChanged(nameof(Students));

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
