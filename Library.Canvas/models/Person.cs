

namespace Library.Canvas.Models {

    public class Person {


        public string? Name{get; set;}
        //the name 

        public int Id {get; set;}
        
        public string? Classification{get; set;}
        //I dont have to worry about putting a ? by the classification because
        //chars are set to \0 by default which is the null character

        public int Grades{get; set;}


        public Person() {

            Name = string.Empty;



        }


        public override string ToString()
        {
            //return Name;
            //possible null reference return with Name in the above line ^

            return $"{Id} - {Name} - {Classification}";

        }


    }


    public enum StudentClassification {

        Freshman, Sophmore, Junior, Senior


    }



}

//what does it mean for a string to be nullable or not?
//