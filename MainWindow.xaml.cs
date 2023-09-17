using System;
using System.Collections.Generic;
using System.Globalization;
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
        private void Slav_Click(object sender, RoutedEventArgs e)
        {
            DateTime birthDate = (DateTime)BirthDate.SelectedDate;
            if ((birthDate.Day >= 24 && birthDate.Month == 12) || (birthDate.Day >= 01 && birthDate.Day <= 30 && birthDate.Month == 01))
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Мороз";
            }
            else if ((birthDate.Day == 31 && birthDate.Month == 01) || (birthDate.Month == 02))
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Велес";
            }
            else if (birthDate.Month == 03)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Макошь";
            }
            else if (birthDate.Month == 04)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Жива";
            }
            else if (birthDate.Month == 05 && birthDate.Day >= 01 && birthDate.Day <= 14)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Ярило";
            }
            else if ((birthDate.Month == 05 && birthDate.Day >= 15) || (birthDate.Month == 06 && birthDate.Day >= 1 && birthDate.Day <= 2))
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Леля";
            }
            else if (birthDate.Month == 06 && birthDate.Day >= 3 && birthDate.Day <= 12)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Кострома";
            }
            else if ((birthDate.Month == 06 && birthDate.Day >= 13 && birthDate.Day <= 23 || birthDate.Day >= 25) || (birthDate.Month == 07 && birthDate.Day <= 6))
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Додола";
            }
            else if (birthDate.Month == 06 && birthDate.Day == 24)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Иван Купала";
            }
            else if (birthDate.Month == 07 && birthDate.Day >= 7 && birthDate.Day <= 31)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Лада";
            }
            else if (birthDate.Month == 08 && birthDate.Day <= 28)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Перун";
            }
            else if ((birthDate.Month == 08 && birthDate.Day >= 29) || (birthDate.Month == 09 && birthDate.Day <= 13))
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Сева";
            }
            else if (birthDate.Month == 09 && birthDate.Day >= 14 && birthDate.Day <= 27)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Рожаница";
            }
            else if ((birthDate.Month == 09 && birthDate.Day >= 28) || (birthDate.Month == 10 && birthDate.Day <= 15))
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Сварожичи";
            }
            else if ((birthDate.Month == 10 && birthDate.Day >= 16) || (birthDate.Month == 11 && birthDate.Day <= 8))
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Морена";
            }
            else if (birthDate.Month == 11 && birthDate.Day >= 9 && birthDate.Day <= 28)
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Зима";
            }
            else
            {
                CalendarResult.Text = "Ваш знак по древанеславянскому календарю - Карачун";
            }
        }
        private void East_Click(object sender, RoutedEventArgs e)
        {
            DateTime birthDate = (DateTime)BirthDate.SelectedDate;
            int rem = birthDate.Year % 12;
            switch(rem)
            {
                case 4:
                    CalendarResult.Text = "Ваш знак по восточному календарю - крыса";
                    break;
                case 5:
                    CalendarResult.Text = "Ваш знак по восточному календарю - бык";
                    break;
                case 6:
                    CalendarResult.Text = "Ваш знак по восточному календарю - тигр";
                    break;
                case 7:
                    CalendarResult.Text = "Ваш знак по восточному календарю - кролик";
                    break;
                case 8:
                    CalendarResult.Text = "Ваш знак по восточному календарю - дракон";
                    break;
                case 9:
                    CalendarResult.Text = "Ваш знак по восточному календарю - змея";
                    break;
                case 10:
                    CalendarResult.Text = "Ваш знак по восточному календарю - лошадь";
                    break;
                case 11:
                    CalendarResult.Text = "Ваш знак по восточному календарю - овца";
                    break;
                case 0:
                    CalendarResult.Text = "Ваш знак по восточному календарю - обезьяна";
                    break;
                case 1:
                    CalendarResult.Text = "Ваш знак по восточному календарю - петух";
                    break;
                case 2:
                    CalendarResult.Text = "Ваш знак по восточному календарю - собака";
                    break;
                case 3:
                    CalendarResult.Text = "Ваш знак по восточному календарю - свинья";
                    break;
                default:
                    break;

            }
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
                Calendar.Visibility = Visibility.Visible;
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
            WeekDay.Text = birthDate.ToString("dddd");
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
