namespace MAUI.Canvas.Dialogs
{
    public partial class StudentDialog : ContentPage
    {
    	public StudentDialog()
    	{
    		InitializeComponent();
    	}

		private void CancelClicked(object sender, EventArgs e) {

			Shell.Current.GoToAsync("//StudentsView");


		}


    }
}