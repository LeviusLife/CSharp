using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class AssignmentDialog : ContentPage
    {

		
		public int AssignmentId { get; set; }
    	public AssignmentDialog()
    	{
    		InitializeComponent();
			BindingContext = new AssignmentDialogViewModel(0);
    	}

		public AssignmentDialog(int assignmentId) {
			InitializeComponent();
			BindingContext = new AssignmentDialogViewModel(assignmentId);

		}

		public void AssignmentOkClicked(object sender, EventArgs e) {
			/*
			if ((BindingContext is ModulesAndAssignmentsViewModel viewModel) == true)
    			{
        			int courseIdForAssignment = viewModel.CourseIdForMA;

        			(BindingContext as AssignmentDialogViewModel)?.AddAssignmenttoCourse(courseIdForAssignment);
        			Shell.Current.GoToAsync("//ModulesAndAssignments");
        			BindingContext = new AssignmentDialogViewModel(0);
    			}
    		else
    			{
        			// Handle unexpected binding context type or null context
        			// Log an error or display a message to indicate the issue
        			//Debug.WriteLine("Unexpected or null BindingContext type in AssignmentDialog");


    			}
			*/



			
			//(BindingContext as AssignmentDialogViewModel)?.AddAssignment();
			//(BindingContext as ModulesAndAssignmentsViewModel)?.
			Shell.Current.GoToAsync("//ModulesAndAssignments");
			BindingContext = new AssignmentDialogViewModel(0);
			

		}

		public void AssignmentCancelClicked(object sender, EventArgs e) {

			Shell.Current.GoToAsync("//ModulesAndAssignments");

		}

    }
}