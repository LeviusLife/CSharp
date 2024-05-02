using Library.Canvas.Models;


namespace Library.Canvas.Services
{
    public class SubmissionService
    {

        public AssignmentService assignmentService;

         private List<Submission> submissionList;
        private static SubmissionService? _instance;

        private static object _lock = new object();

        private SubmissionService() {

            submissionList = new List<Submission>();
            assignmentService = AssignmentService.Current;
        }

         private int LastId
                {

                    get
                    {
                        if (submissionList.Count == 0)
                            {
                                return 0; // Return 0 when the list is empty
                            }
                         else
                        {
                            return submissionList.Select(c => c.SubmissionId).Max();
                        }
                    }

                }


         public static SubmissionService Current {

                get {

                    lock(_lock){

                          if (_instance == null) {

                        _instance = new SubmissionService();
                    
                    }
                    }
              

                    return _instance;


                }


            }

            public void AddorUpdateSubmission(Submission submission, Assignment assignment) {

            

                if(submission.SubmissionId <= 0 )
                {
                    submissionList = assignment.Submissions;
                    submission.SubmissionId = LastId + 1;
                    assignment.Submissions.Add(submission);

                }
     

            }







    }
}
