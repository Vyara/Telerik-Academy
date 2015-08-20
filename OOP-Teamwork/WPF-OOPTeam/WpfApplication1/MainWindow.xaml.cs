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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using EventScheduler.Data;
using EventScheduler.Data.Staff;
using System.Threading;
using System.Globalization;
using EventScheduler.Data.Enumerations;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;




namespace WpfApplication1
{
    using EventScheduler.Data;


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        public List<Event> eventsList;

        public MainWindow()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            InitializeComponent();
            /*var colllect = new List<Admin>
                {
                        
                        new Admin { Event = 1, Name = "Nomer1"},
                        new Admin { Event = 2, Name = "Nomer2"},
                        new Admin { Event = 3, Name = "Nomer3"},
                        new Admin { Event = 4, Name = "Nomer4"},
                        new Admin { Event = 5, Name = "Nomer5"},
                        new Admin { Event = 6, Name = "Nomer6"},
                };

            
            MyDataGrid.ItemsSource = colllect;*/

            var rnd = new Random();
            var eventOne = new Event();
            var eventTwo = new Event();
            var eventThree = new Event();
            var eventFour = new Event();
            var eventFive = new Event();


            #region ParticipantsMaking
            var pesho = new Participant("Petar", "Petrov", Gender.Male, "Pepo@vgz.shtb", "02/02020202", 13, 25);
            var hasan = new Participant("Hasan", "Asenov", Gender.Male, "kyp@vgz.shtb", "0888888888", 0.20m, 26);
            var aishe = new Participant("Aishe", "AsAnova", Gender.Female, "pitka@vgz.shtb", "080808888", 10, 27);
            var moni = new Participant("Simeon", "Vtori", Gender.NotSpecified, "tzar@kyp.com", "08888813564", 15, 28);
            var ciganIN = new Participant("Ivan", "Mostov", Gender.Male, "DeSeEbe@shtb.vgz", "0034/606666666", 15, 29);
            var siuleiman = new Participant("Siuleiman", "Pasi", Gender.NotSpecified, "trabant@yahoo.yes", "02/87087078", 134, 30);
            var analiq = new Participant("Analiq", "Bezfamiliq", Gender.Female, "payner@payner.begay", "08callme", 5500, 31);
            var tazi = new Participant("TaziBe", "KakIBesheImeto", Gender.Female, "tazi@onazi.com", "ZvaniMiINeMiVdiga", 10, 33);
            var krisko = new Participant("Krisko", "Drisko", Gender.NotSpecified, "BEATS@payner.begay", "0887 777 777", 0.01m, 32);
            var mariq = new Participant("Iliq", "Marieva", Gender.Female, "GZgolem@payner.begay", "0888 889 999", 1200, 34);

            #endregion


            #region enventMakeing



            eventOne.Budget = 1205.00m;
            eventOne.DateTime = DateTime.Parse("01.12.2015 20:00:00");
            eventOne.EventStaff = new List<EventStaff>() { new DJ("MC Grozen", eventOne, 200), new Cook("Bai Ivan", eventOne, 50, true) };
            eventOne.Location = new Location(new Coordinates(40.25m, 10.12m), "Limoncheto");
            eventOne.MeetingPoint = "Pazara";
            eventOne.Organizer = new Organizer("Ivailo", "Kenov", EventScheduler.Data.Enumerations.Gender.Male, "i_k@abv.bg", "+359 888 888 888", 1300, 25);
            eventOne.ParticipantsList = new List<Participant>();

            eventOne.Title = "Naj ludoto party ever";
            //for (int i = 0; i < 20; i++)
            //{
            //    var gender = rnd.Next(0, 3);
            //    eventOne.ParticipantsList.Add(
            //        new Participant("Participant" + (i + 1).ToString(), "LastName" + (i + 1).ToString(),(Gender)gender, eventOne,
            //            "p" + (i + 1).ToString() + "@gmail.com", "0888 888 8" + (i + 1).ToString(), 25));
            //}
            eventOne.ParticipantsList.Add(pesho);
            eventOne.ParticipantsList.Add(moni);
            eventOne.ParticipantsList.Add(aishe);
            eventOne.ParticipantsList.Add(ciganIN);
            eventOne.ParticipantsList.Add(mariq);



            eventTwo.Budget = 6500.00m;
            eventTwo.DateTime = new DateTime(2015, 12, 08, 22, 00, 00);
            eventTwo.EventStaff = new List<EventStaff>() { new DJ("MC Typ", eventTwo, 200), new Singer("Analiq", eventTwo, 5000, true), new Cook("Bai Ivan", eventTwo, 50, true) };
            eventTwo.Location = new Location(new Coordinates(80.25m, 120.12m), "Riblja Corba");
            eventTwo.MeetingPoint = "NDK";
            eventTwo.Organizer = new Organizer("Doncho", "Minkov", EventScheduler.Data.Enumerations.Gender.Male, "D_M@abv.bg", "+359 888 888 666", 6500, 25);
            eventTwo.ParticipantsList = new List<Participant>();
            //for (int i = 0; i < 20; i++)
            //{
            //    var gender = rnd.Next(0, 3);
            //    eventTwo.ParticipantsList.Add(
            //        new Participant("Participant" + (i + 21).ToString(), "LastName" + (i + 21).ToString(), (Gender)gender, eventTwo,
            //            "p" + (i + 21).ToString() + "@gmail.com", "0888 888 8" + (i + 21).ToString(), 25));
            //}
            eventTwo.ParticipantsList.Add(hasan);
            eventTwo.ParticipantsList.Add(analiq);
            eventTwo.ParticipantsList.Add(krisko);
            eventTwo.ParticipantsList.Add(tazi);

            eventTwo.Title = "Narko party";

            eventThree.Budget = 26500.00m;
            eventThree.DateTime = new DateTime(2015, 12, 31, 22, 00, 00);
            eventThree.EventStaff = new List<EventStaff>() { new Singer("Jochan Strauss JR", eventThree, 25000, true) };
            eventThree.Location = new Location(new Coordinates(54.25m, 50.12m), "NDK");
            eventThree.MeetingPoint = "NDK";
            eventThree.Organizer = new Organizer("Evlogi", "Georgiev", EventScheduler.Data.Enumerations.Gender.Male, "EG@abv.bg", "+359 888 888 686", 26500, 25);
            eventThree.ParticipantsList = new List<Participant>();
            //for (int i = 0; i < 20; i++)
            //{
            //    var gender = rnd.Next(0, 3);
            //    eventThree.ParticipantsList.Add(
            //        new Participant("Participant" + (i + 321).ToString(), "LastName" + (i + 321).ToString(), (Gender)gender, eventThree,
            //            "p" + (i + 321).ToString() + "@gmail.com", "0888 888 8" + (i + 321).ToString(), 125));
            //}
            eventThree.ParticipantsList.Add(hasan);
            eventThree.ParticipantsList.Add(analiq);
            eventThree.ParticipantsList.Add(krisko);
            eventThree.ParticipantsList.Add(tazi);
            eventThree.ParticipantsList.Add(mariq);
            eventThree.ParticipantsList.Add(ciganIN);
            eventThree.ParticipantsList.Add(moni);
            eventThree.ParticipantsList.Add(pesho);

            eventThree.Title = "Forever Classics";

            eventFour.Budget = 0.00m;
            eventFour.DateTime = DateTime.Now.AddDays(1);
            eventFour.Location = new Location(new Coordinates(4.25m, 0.12m), "U vas");
            eventFour.MeetingPoint = "Mr. Popa";
            eventFour.Organizer = new Organizer("Nikolai", "Kostov", EventScheduler.Data.Enumerations.Gender.Male, "nikiIT@abv.bg", "+359 888 888 000", 2.5m, 25);
            eventFour.ParticipantsList = new List<Participant>();
            //for (int i = 0; i < 20; i++)
            //{
            //    var gender = rnd.Next(0, 3);
            //    eventFour.ParticipantsList.Add(
            //        new Participant("Participant" + (i + 4321).ToString(), "LastName" + (i + 4321).ToString(), (Gender)gender, eventFour,
            //            "p" + (i + 4321).ToString() + "@gmail.com", "0888 888 8" + (i + 4321).ToString(), 0));
            //}
            eventFour.ParticipantsList.Add(hasan);
            eventFour.ParticipantsList.Add(analiq);
            eventFour.ParticipantsList.Add(krisko);
            eventFour.ParticipantsList.Add(tazi);
            eventFour.ParticipantsList.Add(mariq);
            eventFour.ParticipantsList.Add(ciganIN);
            eventFour.ParticipantsList.Add(moni);
            eventFour.ParticipantsList.Add(pesho);
            eventFour.ParticipantsList.Add(siuleiman);
            eventFour.ParticipantsList.Add(aishe);
            eventFour.Title = "Pijama party";
            #endregion


            //IFormatter formatter = new BinaryFormatter();
            ////SerializeEvent.SerializeEventType(eventOne, "EventOne", formatter);
            //FileStream s = new FileStream("EventName", FileMode.Create);
            //formatter.Serialize(s, eventFour);
            //s.Close();

            SerializeEvent.SerializeEventType(eventFour, "Event.txt");
            Event Deserialized = SerializeEvent.DeserializeEvent("Event.txt");


            //eventsList = new List<Event> { eventOne, eventTwo, eventThree, eventFour, eventFive,Deserialized };
            // eventsList.Add(eventOne);
            // eventsList.Add(eventTwo);
            // eventsList.Add(eventThree);
            // eventsList.Add(eventFour);
            // eventsList.Add(eventFive);
            //SerializeEvent.SerializeEventList(eventsList, "AllEvents.bin");

            List<Event> returnedList = SerializeEvent.DeserializeEventList("AllEvents.bin");
            eventsList = returnedList;
            MyComboBox.ItemsSource = returnedList;


        }


        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            Login form = new Login();
            form.ShowDialog();//.Show();
            //ButtonLogin.IsEnabled = false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = MyComboBox.SelectedIndex;
            if (index == -1)
            {
                //MessageBox.Show("Nothing selected!");
                return;
            }
            var list = eventsList[index].ParticipantsList;
            var comment = eventsList[index].Comment;
            this.MyTextBlock.Text = comment;
            this.MyDataGrid.ItemsSource = list;
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            // Show form for iput information for event.........
            WindowAddEvent.ShowME();
            //Event az = new Event() { Title = "Some stupid Event"};
            //this.eventsList.Add(az);
            // TODO SERIALIZE HERE
            MyComboBox.ItemsSource = null;
            MyComboBox.ItemsSource = eventsList;


            return;
        }

        private void AddButtoin_Click(object sender, RoutedEventArgs e)
        {
            ParticipantAdding corko = new ParticipantAdding();
            
            corko.ShowDialog();
            
        }


    }
}
