﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AddressBook;
using Library.Canvas.Models;
using Library.Canvas.Services;



namespace MAUI.Canvas.viewmodels
{
    internal class InstructorsViewModel: INotifyPropertyChanged
    {

         private StudentService studentSvc;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }



        public ObservableCollection<Person> Students {


            get
            {
                return new ObservableCollection<Person>(studentSvc.Students);
            }


        }


        public void AddStudent() {

            studentSvc.Add(new Person { Name = "This is a new client"});
            NotifyPropertyChanged(nameof(Students));

        }

        public void Refresh() {

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


         public InstructorsViewModel() {

            //underlyingPerson = new Person { Name = "My Test Student"};

            studentSvc = StudentService.Current;
        }





    }
}