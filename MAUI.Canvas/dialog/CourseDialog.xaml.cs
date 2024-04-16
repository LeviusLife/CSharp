using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class CourseDialog : ContentPage
    {
    	public CourseDialog()
    	{
    		InitializeComponent();
    		BindingContext = new CourseDialogViewModel();
    	}

		private void CancelCourseClicked(object sender, EventArgs e) {

    			Shell.Current.GoToAsync("//InstructorsView");

    		}

    		private void OkCourseClicked(object sender, EventArgs e) {

				/*
    			(BindingContext as InstructorDialogViewModel)?.AddStudent();
    			Shell.Current.GoToAsync("//InstructorsView");
				*/

    		}




    }
}