using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace basic_data_binding
{
    public class Nicknames : ObservableCollection<Nickname> { }

    public partial class MainWindow : Window
    {

        Nicknames names;

        public MainWindow()
        {
            InitializeComponent();

            this.addButton.Click += addButton_Click;

            this.names = (Nicknames)this.FindResource("names");

            dockPanel.DataContext = this.names;

        }

        void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.names.Add(new Nickname());
        }
    }
}
