using HRProgramWPF.ViewModels;
using MahApps.Metro.Controls;
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

namespace HRProgramWPF.Views
{
    /// <summary>
    /// Interaction logic for DbSettings.xaml
    /// </summary>
    public partial class DbSettings : MetroWindow
    {
        public DbSettings(bool canCloseWindow)
        {
            InitializeComponent();
            DataContext = new DbSettingsViewModel(canCloseWindow);
        }
    }
}
