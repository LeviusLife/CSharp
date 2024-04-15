using MAUI.Canvas.viewmodels;


namespace MAUI.Canvas.Views
{
    public partial class CoursesView : ContentPage
    {
    	public CoursesView()
    	{
    		InitializeComponent();
    	}


		private void CoursesViewClicked(object sender, EventArgs e) {

		Shell.Current.GoToAsync("//StudentsView");

	}
    }
}