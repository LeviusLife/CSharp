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
    }
}
