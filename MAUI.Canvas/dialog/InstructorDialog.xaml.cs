
using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
	[QueryProperty(nameof(StudentId), "studentId")]
    public partial class InstructorDialog : ContentPage
    {
		
		public int StudentId
		{
			get; set;
		}

		

    	public InstructorDialog(int studentId)
    	{
    		InitializeComponent();
    		BindingContext = new InstructorDialogViewModel(studentId);
    	}

		public InstructorDialog(){

			InitializeComponent();
			BindingContext = new InstructorDialogViewModel(0);

		}
    		private void CancelClicked(object sender, EventArgs e) {

    			Shell.Current.GoToAsync("//InstructorsView");

    		}

    		private void OkClicked(object sender, EventArgs e) {

    			(BindingContext as InstructorDialogViewModel)?.AddStudent();
    			Shell.Current.GoToAsync("//InstructorsView");
				BindingContext = new InstructorDialogViewModel(0);

    		}


			
    		private void ContentPage_NavigatedTo(object sender, EventArgs e) {

    			//BindingContext = new InstructorDialogViewModel(StudentId);

    		}
			

    }
}