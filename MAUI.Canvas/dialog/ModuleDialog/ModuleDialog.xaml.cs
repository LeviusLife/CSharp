using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Dialogs
{
    public partial class ModuleDialog : ContentPage
    {
    	public ModuleDialog()
    	{
    		InitializeComponent();
    	}


		public void ModuleConfirmClicked(object sender, EventArgs e)
		{

			//kshdfkuhsdfkuh

		}


		public void ModuleCancelClicked(object sender, EventArgs e)
		{

			Shell.Current.GoToAsync("//ModulesAndAssignments");

		}


    }
}