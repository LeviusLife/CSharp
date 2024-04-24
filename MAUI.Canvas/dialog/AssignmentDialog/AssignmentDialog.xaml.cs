using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class AssignmentDialog : ContentPage
    {
    	public AssignmentDialog()
    	{
    		InitializeComponent();
    	}

		public void AssignmentOkClicked(object sender, EventArgs e) {

			//jknsfdl
		}

		public void AssignmentCancelClicked(object sender, EventArgs e) {

			Shell.Current.GoToAsync("//ModulesAndAssignments");

		}

    }
}