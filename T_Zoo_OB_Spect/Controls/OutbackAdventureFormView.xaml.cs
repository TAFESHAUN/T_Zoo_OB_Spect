namespace T_Zoo_OB_Spect.Controls;

public partial class OutbackAdventureFormView : ContentView
{
    public event EventHandler<FormSubmitEventArgs> OnFormSubmit;

    public OutbackAdventureFormView()
    {
        InitializeComponent();
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        // Get user input from Entry controls
        string name = NameEntry.Text;
        string email = EmailEntry.Text;

        // Validate and parse the number of participants
        if (int.TryParse(ParticipantsEntry.Text, out int participants))
        {
            // Create an event argument with the form data
            var formData = new FormSubmitEventArgs(name, email, participants);

            // Raise the event to pass the data to the parent
            OnFormSubmit?.Invoke(this, formData);
        }
        else
        {
            // Display an alert for invalid input
            App.Current.MainPage.DisplayAlert("Error", "Please enter a valid number of participants.", "OK");
        }
    }
}

public class FormSubmitEventArgs : EventArgs
{
    public string Name { get; }
    public string Email { get; }
    public int Participants { get; }

    public FormSubmitEventArgs(string name, string email, int participants)
    {
        Name = name;
        Email = email;
        Participants = participants;
    }

}