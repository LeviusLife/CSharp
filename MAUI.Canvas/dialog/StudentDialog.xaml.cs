using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class StudentDialog : ContentPage
    {
    	public StudentDialog()
    	{
    		InitializeComponent();
			BindingContext = new StudentDialogViewModel();
    	}

		private void CancelClicked(object sender, EventArgs e) {

			Shell.Current.GoToAsync("//StudentsView");


		}


    }
}