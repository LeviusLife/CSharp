using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Library.Canvas.Models;
using Library.Canvas.Services;

namespace MAUI.Canvas.viewmodels
{
    public class StudentSubmitDialogViewModel
    {

        AssignmentService assignmentSvcForSubmission;

        StudentService studentSvcForSubmission;

         private Assignment? Assignment;

         private Submission? Submission;

         public int assignmentIdForSubmission { get; set; }


          public int AssignmentIdForStorage {

            get; set;


        }

         public int StudentIdForStorage {

            get; set;


        }



         public string Answer {
            get {return Submission?.Answer ?? string.Empty;}
            set {

                if(Submission == null) Submission = new Submission();
                
                Submission.Answer = value;

            }
        }

        public StudentSubmitDialogViewModel(){

            
        
            //studentSvcForAssignment = StudentService.Current;
            assignmentSvcForSubmission = AssignmentService.Current;
            studentSvcForSubmission = StudentService.Current;


        }

        public StudentSubmitDialogViewModel(int aId){

            
        
            //studentSvcForAssignment = StudentService.Current;
            assignmentSvcForSubmission = AssignmentService.Current;
            studentSvcForSubmission = StudentService.Current;

             if (aId == 0) {

                assignmentIdForSubmission = 0; 
                Assignment = new Assignment();
                //I might need to make a new Assignment and store the property as a 0 here

            }

            else {

                assignmentSvcForSubmission.CurrentId = aId;
                Assignment = AssignmentService.Current.Get(aId) ?? new Assignment();
                //the property will have the value set and stored here

            }



        }

        public void AddSubmissiontoAssignment() {


            var assignId = assignmentSvcForSubmission.CurrentId;

            if (assignId > 0) {

                var assignment = assignmentSvcForSubmission.Get(assignId);

                if(assignment != null) {

                    assignmentIdForSubmission = assignId;
                    StudentIdForStorage = studentSvcForSubmission.CurrentId;
                    SubmissionService.Current.AddorUpdateSubmission(Submission, assignment);


                }


            }

        }






    }
}
