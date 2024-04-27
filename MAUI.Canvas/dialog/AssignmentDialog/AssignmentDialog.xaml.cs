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
			//this is where we willcall the (BindingContext as ) thingy
			//(BindingContext as AssignmentDialogViewModel)?.AddAssignmenttoCourse();
			//(BindingContext as ModulesAndAssignmentsViewModel)?.
			Shell.Current.GoToAsync("//ModulesAndAssignments");
		}

		public void AssignmentCancelClicked(object sender, EventArgs e) {

			Shell.Current.GoToAsync("//ModulesAndAssignments");

		}

    }
}