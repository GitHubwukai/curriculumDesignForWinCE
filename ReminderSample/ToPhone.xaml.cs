using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Shell;
using Microsoft.Phone.UserData;

namespace ReminderSample
{
    public partial class ToPhone : PhoneApplicationPage
    {
        public ToPhone()
        {
            InitializeComponent();
        }
        private void btnPhone_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCall = new PhoneCallTask();
            phoneCall.PhoneNumber = number.Text;
            phoneCall.Show();
            name.Text = "";
            number.Text = "";
        }

        private void btnCanel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string Pname = "";
            string phoneNum = "";

            NavigationContext.QueryString.TryGetValue("name",out Pname);
            NavigationContext.QueryString.TryGetValue("phoneNum", out phoneNum);

            name.Text = Pname;
            number.Text = phoneNum;
        }

    }
}