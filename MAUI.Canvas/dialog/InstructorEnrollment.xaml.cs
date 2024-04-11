using Library.Canvas.Models;
using Library.Canvas.Services;
using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs;

public partial class InstructorEnrollment : ContentPage
{
	public InstructorEnrollment()
	{
		InitializeComponent();
		BindingContext = new InstructorEnrollmentViewModel();
	}

/*
	public void OnCourseSelected(object sender, SelectedItemChangedEventArgs e) {

		
		if(e.SelectedItem != null) {

			var selectedCourse = e.SelectedItem as Course;
			RosterListView.ItemsSource = selectedCourse?.Roster;

		}




	}
*/

	private void ConfirmEnrollmentClicked(object sender, EventArgs e) {

		var courseId = (BindingContext as InstructorEnrollmentViewModel)?.SelectedCourse?.Code;

		
		if (courseId != null)
		{
			

			(BindingContext as InstructorEnrollmentViewModel)?.AddFakeStudents(courseId);

			//Shell.Current.GoToAsync($"//InstructorDetail?studentId={studentId}");
			 //Navigation.PushAsync(new InstructorDialog(studentId.Value));

		}

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
        (BindingContext as InstructorEnrollmentViewModel)?.RefreshView();
    }

}