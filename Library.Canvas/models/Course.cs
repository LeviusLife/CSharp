

namespace Library.Canvas.Models {

    public class Course {

        public string Code{get; set;}

        public string Name{get; set;}

        public string Description{get; set;}

        public List<Person> Roster{get; set;}

        public List<Assignment> Assignments{get; set;}

        public List<Module> Modules{get; set;}



        public Course() {

            Name = string.Empty;

            Code = string.Empty;

            Description = string.Empty;
    
            Roster = new List<Person>();

            Assignments = new List<Assignment>();

            Modules = new List<Module>();



        }


         public override string ToString()
        {
            //return Name;
            //possible null reference return with Name in the above line ^

            //return $"{Code} - {Name}";
            return $"{Code} - {Name} \n Description: {Description}";

        }




    }
}