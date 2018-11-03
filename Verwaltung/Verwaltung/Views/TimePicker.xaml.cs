using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Verwaltung.Views
{
    /// <summary>
    ///     Interaction logic for TimePicker.xaml
    /// </summary>
    public partial class TimePicker : UserControl
    {
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(TimeSpan), typeof(TimePicker),
                new UIPropertyMetadata(DateTime.Now.TimeOfDay, OnValueChanged));

        public static readonly DependencyProperty HoursProperty =
            DependencyProperty.Register("Hours", typeof(int), typeof(TimePicker),
                new UIPropertyMetadata(0, OnTimeChanged));

        public static readonly DependencyProperty MinutesProperty =
            DependencyProperty.Register("Minutes", typeof(int), typeof(TimePicker),
                new UIPropertyMetadata(0, OnTimeChanged));


        public static readonly DependencyProperty SecondsProperty =
            DependencyProperty.Register("Seconds", typeof(int), typeof(TimePicker),
                new UIPropertyMetadata(0, OnTimeChanged));

        public TimePicker()
        {
            InitializeComponent();
        }

        public TimeSpan Value

        {
            get => (TimeSpan) GetValue(ValueProperty);

            set => SetValue(ValueProperty, value);
        }


        public int Hours

        {
            get => (int) GetValue(HoursProperty);

            set => SetValue(HoursProperty, value);
        }


        public int Minutes

        {
            get => (int) GetValue(MinutesProperty);

            set => SetValue(MinutesProperty, value);
        }


        public int Seconds

        {
            get => (int) GetValue(SecondsProperty);

            set => SetValue(SecondsProperty, value);
        }


        private static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)

        {
            var control = obj as TimePicker;

            control.Hours = ((TimeSpan) e.NewValue).Hours;

            control.Minutes = ((TimeSpan) e.NewValue).Minutes;

            control.Seconds = ((TimeSpan) e.NewValue).Seconds;
        }


        private static void OnTimeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)

        {
            var control = obj as TimePicker;

            control.Value = new TimeSpan(control.Hours, control.Minutes, control.Seconds);
        }


        private void Down(object sender, KeyEventArgs args)

        {
            switch (((Grid) sender).Name)

            {
                case "sec":

                    if (args.Key == Key.Up)

                        Seconds++;

                    if (args.Key == Key.Down)

                        Seconds--;

                    break;


                case "min":

                    if (args.Key == Key.Up)

                        Minutes++;

                    if (args.Key == Key.Down)

                        Minutes--;

                    break;


                case "hour":

                    if (args.Key == Key.Up)

                        Hours++;

                    if (args.Key == Key.Down)

                        Hours--;

                    break;
            }
        }
    }
}