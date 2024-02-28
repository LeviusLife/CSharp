namespace MauiApp1;

public partial class StudentsView : ContentPage
{
	public StudentsView()
	{
		InitializeComponent();
	 
	}

	private void BackClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//MainPage");

	}

}