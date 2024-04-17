using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
	[QueryProperty(nameof(CourseId), "courseId")]

    public partial class CourseDialog : ContentPage
    {

		public int CourseId
		{
			get; set;
		}

    	public CourseDialog(int courseId)
    	{
    		InitializeComponent();
    		BindingContext = new CourseDialogViewModel(courseId);
    	}

		public CourseDialog()
    	{
    		InitializeComponent();
    		BindingContext = new CourseDialogViewModel(0);
    	}


		private void CancelCourseClicked(object sender, EventArgs e) {

    			Shell.Current.GoToAsync("//InstructorsView");

    		}

    		private void OkCourseClicked(object sender, EventArgs e) {

				
    			(BindingContext as CourseDialogViewModel)?.AddCourse();
    			Shell.Current.GoToAsync("//InstructorsView");
				BindingContext = new CourseDialogViewModel(0);
				

    		}


			private void ContentPage_NavigatedTo(object sender, EventArgs e) {

    			//BindingContext = new CourseDialogViewModel(CourseId);

    		}




    }
}