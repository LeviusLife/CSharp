using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class ModuleDialog : ContentPage
    {
    	public ModuleDialog()
    	{
    		InitializeComponent();
			BindingContext = new ModuleDialogViewModel(0);
    	}

		public ModuleDialog(int moduleId) {

			InitializeComponent();
			BindingContext = new ModuleDialogViewModel(moduleId);

		}


		public void ModuleConfirmClicked(object sender, EventArgs e)
		{

			(BindingContext as ModuleDialogViewModel)?.AddModuletoCourse();
			//(BindingContext as ModulesAndAssignmentsViewModel)?.
			Shell.Current.GoToAsync("//ModulesAndAssignments");
			BindingContext = new ModuleDialogViewModel(0);

		}


		public void ModuleCancelClicked(object sender, EventArgs e)
		{

			Shell.Current.GoToAsync("//ModulesAndAssignments");

		}


    }
}