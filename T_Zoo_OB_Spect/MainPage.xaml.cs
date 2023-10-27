using T_Zoo_OB_Spect.Controls;

namespace T_Zoo_OB_Spect
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFormSubmit(object sender, FormSubmitEventArgs e)
        {
            // Display a user-friendly alert with the form data
            string message = $"Name: {e.Name}\nEmail: {e.Email}\nParticipants: {e.Participants}";
            DisplayAlert("Form Data", message, "OK");
        }

    }
}