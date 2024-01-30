using Reactive.Bindings;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            SelectedDate = new(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));

            InitializeComponent();
        }

        public ReactivePropertySlim<DateTime> SelectedDate { get; }

        //変数の更新通知用
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}