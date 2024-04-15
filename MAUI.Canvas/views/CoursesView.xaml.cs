using MAUI.Canvas.viewmodels;


namespace MAUI.Canvas.Views
{
    public partial class CoursesView : ContentPage
    {
    	public CoursesView()
    	{
    		InitializeComponent();
    	}


		private void ViewCourseClicked(object sender, EventArgs e) 
		{

			//Shell.Current.GoToAsync("//StudentsView");

		}


		private void CoursesViewBackClicked(object sender, EventArgs e) 
		{

			Shell.Current.GoToAsync("//StudentsView");

		}


	    private void CoursesViewSearchClicked(object sender, EventArgs e) 
		{

			//Shell.Current.GoToAsync("//StudentsView");

		}


    }
}