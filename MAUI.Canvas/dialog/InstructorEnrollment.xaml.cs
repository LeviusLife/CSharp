namespace MAUI.Canvas.Dialogs;

public partial class InstructorEnrollment : ContentPage
{
	public InstructorEnrollment()
	{
		InitializeComponent();
	}


	private void ConfirmEnrollmentClicked(object sender, EventArgs e) {

		//Shell.Current.GoToAsync("//InstructorsView");

	}

	private void EnrollingBackClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//InstructorsView");

	}


}