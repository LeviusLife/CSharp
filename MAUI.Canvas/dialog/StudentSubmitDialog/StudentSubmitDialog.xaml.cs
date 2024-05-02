using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class StudentSubmitDialog : ContentPage
    {
    	public StudentSubmitDialog()
    	{
    		InitializeComponent();
			BindingContext = new StudentSubmitDialogViewModel(0);
    	}

		public StudentSubmitDialog(int aId)
    	{
    		InitializeComponent();
			BindingContext = new StudentSubmitDialogViewModel(aId);
    	}



		public void SubmitClicked(object sender, EventArgs e){

			//Shell.Current.GoToAsync("//AbsoluteDetail");
			(BindingContext as StudentSubmitDialogViewModel)?.AddSubmissiontoAssignment();
			Shell.Current.GoToAsync("//AbsoluteDetail");
			BindingContext = new StudentSubmitDialogViewModel(0);
		}
		
		public void SubmitCancelClicked(object sender, EventArgs e){

			Shell.Current.GoToAsync("//AbsoluteDetail");

		}
    }
}