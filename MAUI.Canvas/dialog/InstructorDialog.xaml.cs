
using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class InstructorDialog : ContentPage
    {
    	public InstructorDialog()
    	{
    		InitializeComponent();
			BindingContext = new InstructorDialogViewModel();
    	}

		private void CancelClicked(object sender, EventArgs e) {

			Shell.Current.GoToAsync("//InstructorsView");

		}

    }
}