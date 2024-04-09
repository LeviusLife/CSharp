using MAUI.Canvas.Dialogs;
using MAUI.Canvas.viewmodels;


namespace MAUI.Canvas.Views;

public partial class InstructorsView : ContentPage
{
	public InstructorsView()
	{
		InitializeComponent();
		BindingContext = new InstructorsViewModel();
	}


	private void BackClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//MainPage");

	}


	private void AddClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//InstructorDetail?studentId=0");
		

	}

	private void UpdateClicked(object sender, EventArgs e) {

		var studentId = (BindingContext as InstructorsViewModel)?.SelectedStudent?.Id;

		if (studentId != null)
		{

			//Shell.Current.GoToAsync($"//InstructorDetail?studentId={studentId}");

			 Navigation.PushAsync(new InstructorDialog(studentId.Value));

		}
		
		

	}

	
	

	private void ContentPage_NavigatedTo(object sender, EventArgs e) {

			(BindingContext as InstructorsViewModel)!.Refresh();

	}

	



	private void RemoveClicked(object sender, EventArgs e) {

		(BindingContext as InstructorsViewModel).Remove();

	}


	private void SearchClicked(object sender, EventArgs e) {

		(BindingContext as InstructorsViewModel)?.Refresh();

	}

	private void Toolbar_EnrollmentsClicked(object sender, EventArgs e)
    {
        (BindingContext as InstructorsViewModel).ShowEnrollments();
    }

    private void Toolbar_CoursesClicked(object sender, EventArgs e)
    {
        (BindingContext as InstructorsViewModel).ShowCourses();
    }


	//Course EventHandlers
	
	private void AddCourseClicked(object sender, EventArgs e) {

		//Shell.Current.GoToAsync("//InstructorDetail");

	}


	private void UpdateCourseClicked(object sender, EventArgs e) {

		//Shell.Current.GoToAsync("//InstructorDetail");

	}


	private void RemoveCourseClicked(object sender, EventArgs e) {

		//Shell.Current.GoToAsync("//InstructorDetail");

	}


	private void BackCourseClicked(object sender, EventArgs e) {

		//Shell.Current.GoToAsync("//InstructorDetail");

	}






}