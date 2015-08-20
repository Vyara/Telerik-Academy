using EventScheduler.Data;
using EventScheduler.Data.Enumerations;
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
    /// Interaction logic for ParticipantAdding.xaml
    /// </summary>
    public partial class ParticipantAdding : Window
    {
        public ParticipantAdding()
        {
            InitializeComponent();
        }

        private void BtnAddParticipant_Click(object sender, RoutedEventArgs e)
        {
            if (BtnAddParticipant.Content.ToString() == "Click Me")
            {
                BtnAddParticipant.Content = "Then Implement Me";
            }
            else
            {
                BtnAddParticipant.Content = "Click Me";
            }
            //TODO implement Adding a participant when button is clicked.
        }
        public bool ChechInput()
        {
            if (string.IsNullOrEmpty(TxtGSM.Text) && string.IsNullOrEmpty(TxtMail.Text) && string.IsNullOrEmpty(TxtFirstNAme.Text) && string.IsNullOrEmpty(TxtBoxSecondName.Text))
            {
                return false;
            }
            int a;
            decimal b;
            if (int.TryParse(TxtAge.Text, out a) && decimal.TryParse(TxtMoney.Text, out b))
            {
                if (a > 15 && a < 50)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
