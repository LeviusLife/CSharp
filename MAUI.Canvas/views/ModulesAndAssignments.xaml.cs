using MAUI.Canvas.viewmodels;
using MAUI.Canvas.Dialogs;

namespace MAUI.Canvas.Views;

public partial class ModulesAndAssignments : ContentPage
{
	public ModulesAndAssignments()
	{
		InitializeComponent();
		BindingContext = new ModulesAndAssignmentsViewModel();
	}

    
   public ModulesAndAssignments(int courseId)
	{
		InitializeComponent();
		BindingContext = new ModulesAndAssignmentsViewModel(courseId);
	}
    

	private void Toolbar_ModulesClicked(object sender, EventArgs e)
    {
        (BindingContext as ModulesAndAssignmentsViewModel)!.ShowModules();
         //(BindingContext as ModulesAndAssignmentsViewModel)!.Refresh();
    }


	private void Toolbar_AssignmentsClicked(object sender, EventArgs e)
    {
        (BindingContext as ModulesAndAssignmentsViewModel)!.ShowAssignments();
        //(BindingContext as ModulesAndAssignmentsViewModel)!.Refresh();
    }

	//*************************************************
	//Module Event Handlers
	//*************************************************

	private void ModulesSearchClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();
    }
    
    
    
    
    private void AddModuleClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ModuleDetail");
    }

    private void EditModuleClicked(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync("//ModuleDetail");

         var moduleId = (BindingContext as ModulesAndAssignmentsViewModel)?.SelectedModule?.ModuleId;

		if (moduleId != 0 && moduleId != null) 
		{


			 Navigation.PushAsync(new ModuleDialog(moduleId.Value));

		}
    }

	private void DeleteModuleClicked(object sender, EventArgs e)
    {
        (BindingContext as ModulesAndAssignmentsViewModel)!.RemoveModule();
    }

	private void BackModuleClicked(object sender, EventArgs e)
    {
      Shell.Current.GoToAsync($"//InstructorsView");
    }


	//***************************************************
	//Assignments EventHandlers
	//***************************************************

    private void AssignmentsSearchClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();
    }




	private void AddAssignmentClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//AssignmentDetail?assignmentId={0}");
    }

    private void EditAssignmentClicked(object sender, EventArgs e)
    {
         //Shell.Current.GoToAsync($"//AssignmentDetail");

         var assignmentId = (BindingContext as ModulesAndAssignmentsViewModel)?.SelectedAssignment?.AssignmentId;

		if (assignmentId != 0 && assignmentId != null) 
		{


			 Navigation.PushAsync(new AssignmentDialog(assignmentId.Value));

		}
		
		//(BindingContext as InstructorsViewModel)?.ResetCourse();
    }

	private void DeleteAssignmentClicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorsViewModel)!.ShowEnrollments();

          var assignmentId = (BindingContext as ModulesAndAssignmentsViewModel)?.SelectedAssignment?.AssignmentId;

		if (assignmentId != 0 && assignmentId != null) 
		{


			 //Navigation.PushAsync(new AssignmentDialog(assignmentId.Value));
             (BindingContext as ModulesAndAssignmentsViewModel)!.RemoveAssignment();

		}
    }

	private void BackAssignmentClicked(object sender, EventArgs e)
    {
       Shell.Current.GoToAsync($"//InstructorsView");
    }


    private void ContentPage_NavigatedTo(object sender, EventArgs e) {

			(BindingContext as ModulesAndAssignmentsViewModel)!.Refresh();


	}




}