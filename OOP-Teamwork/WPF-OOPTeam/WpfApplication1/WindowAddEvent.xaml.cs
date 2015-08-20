using EventScheduler.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for WindowAddEvent.xaml
    /// </summary>
    public partial class WindowAddEvent : Window
    {
        public static WindowAddEvent winAdEv;// = new WindowAddEvent();
        public WindowAddEvent()
        {
            InitializeComponent();
            //NewDateTime.Tag = false;
            NewLocationX.Tag = false;
            NewMeetingPoint.Tag = false;
            NewLocationY.Tag = false;
            NewMoneyNeed.Tag = false;
            NewTitle.Tag = false;
           
        }
        public static void ShowME()
        {
            winAdEv = new WindowAddEvent();
            //winAdEv.Show();
            winAdEv.ShowDialog();
        }
        public void ActivateButton()
        {
            if ((bool)NewLocationX.Tag == true && (bool)NewTitle.Tag == true && (bool)NewMeetingPoint.Tag == true && (bool)NewMoneyNeed.Tag == true)
            {
                this.ButtonNewEvent.IsEnabled = true;
            }
        }
        private void NewTitle_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NewTitle.Text.Length < 5)
            {
                NewTitle.Tag = false;
                NewTitle.Background = Brushes.Red;
            }
            else
            {
                NewTitle.Tag = true;
                NewTitle.Background = Brushes.White;
            }
            ActivateButton();

        }

        private void NewMeetingPoint_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NewMeetingPoint.Text.Length < 5)
            {
                NewMeetingPoint.Tag = false;
                NewMeetingPoint.Background = Brushes.Red;
            }
            else
            {
                NewMeetingPoint.Tag = true;
                NewMeetingPoint.Background = Brushes.White;
            }
            ActivateButton();

        }

        private void NewMoneyNeed_LostFocus(object sender, RoutedEventArgs e)
        {

            decimal res;
            if (decimal.TryParse(NewMoneyNeed.Text, out res))
            {
                NewMoneyNeed.Tag = true;
                NewMoneyNeed.Background = Brushes.White;
            }
            else
            {
                NewMoneyNeed.Tag = false;
                NewMoneyNeed.Background = Brushes.Red;
            }
            ActivateButton();

        }

        private void NewLocationY_TextChanged(object sender, TextChangedEventArgs e)
        {
            ///facking shit Do not delete this method 
        }

        private void NewLocationX_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NewLocationX.Text == null || NewLocationY.Text == null)
            {
                NewLocationY.Tag = false;
                NewLocationX.Tag = false;
                NewLocationX.Background = Brushes.Red;
                NewLocationY.Background = Brushes.Red;
            }
            else
            {
                NewLocationY.Tag = true;
                NewLocationX.Tag = true;
                NewLocationX.Background = Brushes.White;
                NewLocationY.Background = Brushes.White;
            }
            ActivateButton();
        }

        private void ButtonNewEvent_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(MyDaTePicker.SelectedDate);
            var money = Convert.ToDecimal(NewMoneyNeed.Text);
            var x = Convert.ToDecimal(NewLocationX.Text);
            var y = Convert.ToDecimal(NewLocationY.Text);
            Location loc = new Location(new Coordinates(x, y));
            Event currentEv = new Event() { Title = NewTitle.Text, Budget = money, Location = loc, MeetingPoint = NewMeetingPoint.Text, DateTime = date};
            if (!string.IsNullOrEmpty(NewCommentBox.Text))
            {
                currentEv.Comment = NewCommentBox.Text;
            }
            foreach (Window item in Application.Current.Windows)
            {
                if (item.GetType() == typeof(MainWindow))
                {
                    (item as MainWindow).eventsList.Add(currentEv);
                    SerializeEvent.SerializeEventList((item as MainWindow).eventsList, "AllEvents.bin");
                    (item as MainWindow).MyComboBox.ItemsSource = null;
                    
                   
                }
               
            }            /////
            MessageBox.Show("EventAdded");
            winAdEv.Close();
        }




    }
}
