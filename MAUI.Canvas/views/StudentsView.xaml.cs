using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Views;

public partial class StudentsView : ContentPage
{
	public StudentsView()
	{
		InitializeComponent();
		BindingContext = new StudentsViewModel();
	 
	}

	

	private void BackClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//MainPage");

	}


	private void AddClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//StudentDetail");
		//(BindingContext  as StudentsViewModel)?.AddStudent();

	}

	private void StudentSearchClicked(object sender, EventArgs e) {

		//(BindingContext  as StudentsViewModel)?.AddStudent();

	}

	private void StudentCourseClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//CoursesView");

	}


}