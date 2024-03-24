using MAUI.Canvas.viewmodels;

namespace MAUI.Views;

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

		(BindingContext  as StudentsViewModel)?.AddStudent();

	}

}