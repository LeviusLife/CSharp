using MAUI.Canvas.viewmodels;

namespace MAUI.Canvas.Views;

public partial class ModulesAndAssignments : ContentPage
{
	public ModulesAndAssignments()
	{
		InitializeComponent();
		BindingContext = new ModulesAndAssignmentsViewModel();
	}

	private void Toolbar_ModulesClicked(object sender, EventArgs e)
    {
        (BindingContext as ModulesAndAssignmentsViewModel)!.ShowModules();
    }


	private void Toolbar_AssignmentsClicked(object sender, EventArgs e)
    {
        (BindingContext as ModulesAndAssignmentsViewModel)!.ShowAssignments();
    }

	//*************************************************
	//Module Event Handlers
	//*************************************************

	private void AddModuleClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();
    }

	private void DeleteModuleClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();
    }

	private void BackModuleClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();
    }


	//***************************************************
	//Assignments EventHandlers
	//***************************************************

	private void AddAssignmentClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();
    }

	private void DeleteAssignmentClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();
    }

	private void BackAssignmentClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();
    }





}