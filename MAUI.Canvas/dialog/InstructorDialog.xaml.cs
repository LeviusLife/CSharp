

namespace MAUI.Canvas.Dialogs
{
    public partial class InstructorDialog : ContentPage
    {
    	public InstructorDialog()
    	{
    		InitializeComponent();
    	}

		private void CancelClicked(object sender, EventArgs e) {

			Shell.Current.GoToAsync("//InstructorsView");

		}

    }
}