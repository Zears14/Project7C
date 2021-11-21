using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project7C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Storyboard storyboard = new Storyboard();
        TimeSpan halfsecconds = TimeSpan.FromMilliseconds(500);
        TimeSpan Secconds = TimeSpan.FromSeconds(1);

        private IEasingFunction Smooth
        {
            get;
            set;
        }
        = new QuarticEase
        {
            EasingMode = EasingMode.EaseOut
        };

        public void Fade(DependencyObject Object)
        {
            DoubleAnimation FadeIn = new DoubleAnimation()
            {
                From = 0.0,
                To = 1.0,
                Duration = new Duration(halfsecconds),

            };
            Storyboard.SetTarget(FadeIn, Object);
            Storyboard.SetTargetProperty(FadeIn, new PropertyPath("Opacity", 1));
            storyboard.Children.Add(FadeIn);
            storyboard.Begin();
        }

        public void FadeOut(DependencyObject Object)
        {

            DoubleAnimation FadeOut = new DoubleAnimation()
            {
                From = 1.0,
                To = 0.0,
                Duration = new Duration(halfsecconds),

            };
            Storyboard.SetTarget(FadeOut, Object);
            Storyboard.SetTargetProperty(FadeOut, new PropertyPath("Opacity", 1));
            storyboard.Children.Add(FadeOut);
            storyboard.Begin();
        }

        public void ObjectShifPos(DependencyObject Object, Thickness Get, Thickness Set)
        {
            ThicknessAnimation ShiftAnnimation = new ThicknessAnimation()
            {
                From = Get,
                To = Set,
                Duration = Secconds,
                EasingFunction = Smooth,
            };
            Storyboard.SetTarget(ShiftAnnimation, Object);
            Storyboard.SetTargetProperty(ShiftAnnimation, new PropertyPath(MarginProperty));
            storyboard.Children.Add(ShiftAnnimation);
            storyboard.Begin();
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.Fade(this.MainBorder);
            ObjectShifPos(MainBorder, MainBorder.Margin, new Thickness(0));
            await Task.Delay(2000);
            ObjectShifPos(MainBorder, MainBorder.Margin, new Thickness(0, 0, -300, 0));
            this.FadeOut(this.MainBorder);
            await Task.Delay(500);
            this.Hide();
            ExploitWindows UI = new ExploitWindows();
            UI.Show();
        }
    }
}
