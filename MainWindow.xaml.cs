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

namespace Years
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            DateTime birthDate = (DateTime)BirthDate.SelectedDate;
            AmountTime(birthDate);
        }
        private void AmountTime(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            
            if((today.Month - birthDate.Month)<0)
            {
                AmountMonths.Text = ((today.Month - birthDate.Month) + 12).ToString();
                AmountYears.Text = ((today.Year - birthDate.Year) - 1).ToString();
            }
            else
            {
                AmountMonths.Text = (today.Month - birthDate.Month).ToString();
                AmountYears.Text = (today.Year - birthDate.Year).ToString();
            }
            if(today.Day - birthDate.Day < 0)
            {
                AmountDays.Text = (today.Day - birthDate.Day + DateTime.DaysInMonth(today.Year, today.Month-1)).ToString();
            }
            else
            {
                AmountDays.Text = (today.Day - birthDate.Day).ToString();
            }
        }
    }
}
