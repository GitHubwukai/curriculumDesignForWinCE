
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
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using Microsoft.Phone.UserData;

namespace ReminderSample
{
    public partial class AddReminder : PhoneApplicationPage
    {
        const string TxbName = "TxbName";
        const string TxbPhoneNum = "TxbPhoneNum";
        const string FriendsPhoneList = "FriendsPhoneList";
        PhoneNumberChooserTask phoneChooser;
        IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
        IDictionary<string, object> appState = PhoneApplicationService.Current.State;
        public AddReminder()
        {
            InitializeComponent();
            phoneChooser = new PhoneNumberChooserTask();
            phoneChooser.Completed += new EventHandler<PhoneNumberResult>(phoneChooser_Completed);

            //从独立存储中加载预设号码列表
            if (settings.Contains(FriendsPhoneList))
            {
                string[] phones = (string[])settings[FriendsPhoneList];
                txbName.Text = phones[0];
                txbPhoneNum.Text = phones[1];
            }
        }

        private void ApplicationBarSaveButton_Click(object sender, EventArgs e)
        {
            // Generate a unique name for the new reminder. You can choose a
            // name that is meaningful for your app, or just use a GUID.
            String name = System.Guid.NewGuid().ToString();

        

            // Get the begin time for the reminder by combining the DatePicker
            // value and the TimePicker value.
            DateTime date = (DateTime)beginDatePicker.Value;
            DateTime time = (DateTime)beginTimePicker.Value;
            DateTime beginTime = date + time.TimeOfDay;

            // Make sure that the begin time has not already passed.
            if (beginTime < DateTime.Now)
            {
                MessageBox.Show("the begin date must be in the future.");
                return;
            }

            // Get the expiration time for the reminder
            date = (DateTime)expirationDatePicker.Value;
            time = (DateTime)expirationTimePicker.Value;
            DateTime expirationTime = date + time.TimeOfDay;

            // Make sure that the expiration time is after the begin time.
            if (expirationTime < beginTime)
            {
                MessageBox.Show("expiration time must be after the begin time.");
                return;
            }
            if (txbPhoneNum.Text == "")
            {
                MessageBox.Show("请先预设号码！");
                return;
            }

            // Determine which recurrence radio button is checked.
            RecurrenceInterval recurrence = RecurrenceInterval.None;
            if (dailyRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.Daily;
            }
            else if (weeklyRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.Weekly;
            }
            else if (monthlyRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.Monthly;
            }
            else if (endOfMonthRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.EndOfMonth;
            }
            else if (yearlyRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.Yearly;
            }


            // Create a Uri for the page that will be launched if the user
            // taps on the reminder. Use query string parameters to pass 
            // content to the page that is launched.
            string param1Value = txbName.Text;
            string param2Value = txbPhoneNum.Text;
            string queryString = "";
            if (param1Value != "" && param2Value != "")
            {
                queryString = "?name=" + param1Value + "&phoneNum=" + param2Value;
            }
            else if(param1Value != "" || param2Value != "")
            {
                queryString = (param1Value!=null) ? "?name="+param1Value : "?phoneNum="+param2Value;
            }

            //Uri navigationUri = new Uri("/ShowParams.xaml" + queryString, UriKind.Relative);
            Uri navigationUri = new Uri("/ToPhone.xaml"+queryString,UriKind.Relative);

            Reminder reminder = new Reminder(name);
            reminder.Title = txbName.Text;
            reminder.Content = txbPhoneNum.Text;
            reminder.BeginTime = beginTime;
            reminder.ExpirationTime = expirationTime;
            reminder.RecurrenceType = recurrence;
            reminder.NavigationUri = navigationUri;

            // Register the reminder with the system.
            ScheduledActionService.Add(reminder);

            // Navigate back to the main reminder list page.
            NavigationService.GoBack();

        }

        private void btnSelectPhone_Click(object sender, RoutedEventArgs e)
        {
            appState[TxbName] = txbName.Text;
            appState[TxbPhoneNum] = txbPhoneNum.Text;

            phoneChooser.Show();
        }

        void phoneChooser_Completed(object sender, PhoneNumberResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                txbName.Text = e.DisplayName;
                txbPhoneNum.Text = e.PhoneNumber;
            }
        }
    }
}