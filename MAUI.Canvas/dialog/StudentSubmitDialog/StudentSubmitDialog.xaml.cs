using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class StudentSubmitDialog : ContentPage
    {
    	public StudentSubmitDialog()
    	{
    		InitializeComponent();
    	}

		public void SubmitClicked(object sender, EventArgs e){

			//Shell.Current.GoToAsync("//AbsoluteDetail");

		}
		
		public void SubmitCancelClicked(object sender, EventArgs e){

			Shell.Current.GoToAsync("//AbsoluteDetail");

		}
    }
}