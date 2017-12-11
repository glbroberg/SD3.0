using System;
using FSI.Mobile.SD.UWP.ViewModels;
using FSI.Mobile.SD.UWP.Views;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FSI.Mobile.SD.UWP.ViewModels
{
    public sealed partial class DispatchDetailsPage : Page
    {
        private List<LaborLog> LaborLogs;
        private string key = "AIzaSyAvQkliLCYwJ4lf9Rpy7I3-K_UyAxD3-sQ";
        public DispatchDetailsPage()
        {
            this.InitializeComponent();
            CurrentStatusCode.Text = "Current: " + StatusCode.Text;
            LaborLogs = LaborLogManager.GetLaborLog();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DetailsMainPage));
        }

        private void BackButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void detailsButton3_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(https://www.google.com/maps);

        }

        private void SiteInfoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DetailsMainPage));
        }

        private async void launchURI_MAP(object sender, RoutedEventArgs e)
        {

            RootObject myLocation = await LatLong.GetCoordinances("Strongsville+OH");
            var LatLongURI = new Uri(@"https://maps.googleapis.com/maps/api/geocode/json?address=strongsville,+OH&key=" + key);


            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(LatLongURI);

            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
            }
        }

        private async void launchURI_Directions(object sender, RoutedEventArgs e)
        {
            string city1 = "strongville";
            string state1 = "OH";
            string city2 = "University Heights";
            string state2 = "OH";

            var MapURI = new Uri(@"https://www.google.com/maps/place/" + city1 + ",+" + state1);

            // key = AIzaSyAvQkliLCYwJ4lf9Rpy7I3-K_UyAxD3-sQ

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(MapURI);

            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
            }
        }

        private void EquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EquipmentPage));
        }

        private void UDFButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DescriptionAddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddDetailsPage));
        }

        private void LaborAddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddLaborPage));
        }

        private void MaterialAddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddMaterialPage));
        }

        private async void ChangeStatus_Click(object sender, TappedRoutedEventArgs e)
        {
            ChangeStatusContentDialog dialog = new ChangeStatusContentDialog();
            ContentDialogResult result = await dialog.ShowAsync();


            //ContentDialog ChangeStatusDialog = new ContentDialog
            //{
            //    Title = "Select Status Code",
            //    Content = "something",

            //    PrimaryButtonText = "Button One",
            //    SecondaryButtonText = "Button Two",
            //    CloseButtonText = "Close"

            //};

            //ContentDialogResult result = await ChangeStatusDialog.ShowAsync();

        }

        private async void ClockInButton_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void StackPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            testButtonPanel.Background = new SolidColorBrush(Windows.UI.Colors.Gray);
        }

        private void testButtonPanel_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            testButtonPanel.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(0xFF, 0x1A, 0xBC, 0x9C));
        }

        private void Assign_Click(object sender, RoutedEventArgs e)
        {
            StatusCode.Text = "Assign";
            CurrentStatusCode.Text = "Current: " + StatusCode.Text;
            TestFly.Hide();
        }

        private void FUN_Click(object sender, RoutedEventArgs e)
        {
            StatusCode.Text = "Follow up needed";
            CurrentStatusCode.Text = "Current: " + StatusCode.Text;
            TestFly.Hide();
        }

        private void DateCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (DateCheckBox.IsChecked == true)
            {
                DateColumn.Visibility = Visibility.Visible;

            }

            else
            {
                DateColumn.Visibility = Visibility.Collapsed;
            }
        }

        private void TechnicianCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void StartTimeCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void EndTimeCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void BillingHoursCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void DescriptionCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void EarnCodeCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void EquipmentCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void HourlyCostCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void PriceLevelCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void BillingRateCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ShiftCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void PhaseCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void CostCodeCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void PayrollHoursCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
