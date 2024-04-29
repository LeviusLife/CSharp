namespace Library.Canvas.Models {
    public class Assignment {

        public string? Name{get; set;}

        public string? Description{get; set;}

        public decimal TotalAvailablePoints{get; set;}

        public int AssignmentId {get; set;}
        public DateTime DueDate;


        public Assignment() {



        }

         public override string ToString()
        {
            //return Name;
            //possible null reference return with Name in the above line ^

            //return $"{Code} - {Name}";
            return $"{AssignmentId} - {Name} ";

        }




    }

}