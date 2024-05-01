using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class StudentAbsoluteDetail : ContentPage
    {
    	public StudentAbsoluteDetail()
    	{
    		InitializeComponent();
			BindingContext = new StudentAbsoluteDetailViewModel(0);
    	}

		public StudentAbsoluteDetail(int cId) {

			InitializeComponent();
			BindingContext = new StudentAbsoluteDetailViewModel(cId);
		}


		public void AbsoluteDetailBackClicked(object sender, EventArgs e){

			Shell.Current.GoToAsync("//CoursesView");


		}	

		private void ContentPage_NavigatedTo(object sender, EventArgs e) {

			(BindingContext as StudentAbsoluteDetailViewModel)!.RefreshModules();


		}

		private void SubmitNavigateButtonClicked(object sender, EventArgs e) {

				Shell.Current.GoToAsync("//StudentSubmitDialog");

		}
    }
}