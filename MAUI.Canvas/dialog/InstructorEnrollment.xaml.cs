using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs;

public partial class InstructorEnrollment : ContentPage
{
	public InstructorEnrollment()
	{
		InitializeComponent();
		BindingContext = new InstructorEnrollmentViewModel();
	}


	private void ConfirmEnrollmentClicked(object sender, EventArgs e) {

		//Shell.Current.GoToAsync("//InstructorsView");

	}

	private void EnrollingBackClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//InstructorsView");

	}

	private void CourseEnrollmentSearchClicked(object sender, EventArgs e) {

		//Shell.Current.GoToAsync("//InstructorsView");

	}

	 private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        //(BindingContext as InstructorViewViewModel).ResetView();
        (BindingContext as InstructorEnrollmentViewModel).RefreshView();
    }

}