using MAUI.Canvas.viewmodels;


namespace MAUI.Canvas.Views;

public partial class InstructorsView : ContentPage
{
	public InstructorsView()
	{
		InitializeComponent();
	}


	private void BackClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//MainPage");

	}


	private void AddClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//InstructorDetail");
		

	}


}