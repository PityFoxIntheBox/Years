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
        private void ClickOnDate(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Вводимый формат даты ДД.ММ.ГГГГ");
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime birthDate = (DateTime)BirthDate.SelectedDate;
                DateTime today = DateTime.Today;
                AmountTime(birthDate, today);
                DayWeek(birthDate, today);
                LeapYears(birthDate, today);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nВведите корректную дату");
            }
        }
        private void AmountTime(DateTime birthDate, DateTime today)
        {


            if ((today.Month - birthDate.Month)<0)
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
                if(today.Month == 1)
                {
                    AmountDays.Text = (today.Day - birthDate.Day + DateTime.DaysInMonth(today.Year, 12)).ToString();
                }
                else
                {
                    AmountDays.Text = (today.Day - birthDate.Day + DateTime.DaysInMonth(today.Year, today.Month - 1)).ToString();
                }
            }
            else
            {
                AmountDays.Text = (today.Day - birthDate.Day).ToString();
            }
        }
        private void DayWeek(DateTime birthDate, DateTime today)
        {
            WeekDay.Text = birthDate.DayOfWeek.ToString();
            int amountWeekDays = 0;
            for(int i = birthDate.Year; i <= today.Year;i++)
            {
                DateTime time = new DateTime(i, birthDate.Month, birthDate.Day);
                if(time.DayOfWeek == birthDate.DayOfWeek)
                {
                    amountWeekDays++;
                }
            }
            AmountWeekDays.Text = amountWeekDays.ToString();
        }
        private void LeapYears(DateTime birthDate, DateTime today)
        {
            int amountLeapYears = 0;
            List<int> years = new List<int>();
            for (int i = birthDate.Year; i <= today.Year; i++)
            {
                if (DateTime.IsLeapYear(i) == true)
                {
                    amountLeapYears++;
                    years.Add(i);
                }
            }
            AmountLeaps.Text = amountLeapYears.ToString();
            Leaps.ItemsSource = years;
        }
    }
}
