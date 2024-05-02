namespace Library.Canvas.Models
{
    public class Submission
    {
        public string? Answer{ get; set; }

        public int StudentId { get; set; }

        public int AssignmentId { get; set; }

        public decimal Grade{ get; set; }

        public int SubmissionId { get; set; }

        public Submission() {


        }

         public override string ToString()
        {
            //return Name;
            //possible null reference return with Name in the above line ^

            //return $"{Code} - {Name}";
            return $"AssignmentId:{AssignmentId} - StudentId: {StudentId} - Answer: {Answer} ";

        }


    }
}
