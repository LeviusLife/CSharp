﻿namespace MAUI.Canvas
{
		//eat my ass
		
    public partial class MainPage : ContentPage
    {
    	//int count = 0;

    	public MainPage()
    	{
    		InitializeComponent();
    		
    	}

    	private void StudentViewClicked(object sender, EventArgs e) {

    		Shell.Current.GoToAsync("//StudentsView");

    	}


    	private void InstructorViewClicked(object sender, EventArgs e) {

    		Shell.Current.GoToAsync("//InstructorsView");
		
    	}

    	/*
    	private void OnCounterClicked(object sender, EventArgs e)
    	{
    		count++;

    		if (count == 1)
    			CounterBtn.Text = $"Clicked {count} time";
    		else
    			CounterBtn.Text = $"Clicked {count} times";

    		SemanticScreenReader.Announce(CounterBtn.Text);
    	}
    	*/
    }

}
