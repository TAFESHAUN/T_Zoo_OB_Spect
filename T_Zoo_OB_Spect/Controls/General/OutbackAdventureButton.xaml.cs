namespace T_Zoo_OB_Spect.Controls;

public partial class OutbackAdventureButton : ContentView
{
	//Explore CUSTOM props later

	public OutbackAdventureButton()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		string msg = "You click for some adventure" + advBtn.Text; //This should be updated to be a CUSTOM property

		App.Current.MainPage.DisplayAlert(
			"Adventure Button", 
			msg, 
			"Have fun!");
    }
}