using T_Zoo_OB_Spect.Controls;

namespace T_Zoo_OB_Spect
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFormSubmitInMainPage(object sender, FormSubmitEventArgs e)
        {
            string message = $"Name: {e.Name}\nEmail: {e.Email}\nParticipants: {e.Participants}";
            DisplayAlert("Form Data", message, "OK");
        }

    }
}