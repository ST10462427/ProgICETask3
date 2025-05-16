using System.Windows;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Media3D;
using System.Xml.Linq;

namespace RoomRentalApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the values from the text boxes
            string firstName = ((TextBox)FindName("FirstNameTextBox")).Text;
            string lastName = ((TextBox)FindName("LastNameTextBox")).Text;
            string phoneNumber = ((TextBox)FindName("PhoneNumberTextBox")).Text;
            string streetAddress = ((TextBox)FindName("StreetAddressTextBox")).Text;
            string city = ((TextBox)FindName("CityTextBox")).Text;
            string postalCode = ((TextBox)FindName("PostalCodeTextBox")).Text;

            // Validate the input
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter both first and last names.");
                return;
            }

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(streetAddress) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(postalCode))
            {
                MessageBox.Show("Please enter a valid address.");
                return;
            }

            // Submit the application
            MessageBox.Show("Application submitted successfully!");
        }
    }
}



