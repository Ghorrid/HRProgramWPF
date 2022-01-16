using HRProgramWPF.Models.Domains;
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
    /// Interaction logic for AddEditEmpolyee.xaml
    /// </summary>
    public partial class AddEditEmpolyee : MetroWindow
    {
        public AddEditEmpolyee( Employees employees = null)
        {
            InitializeComponent();
            DataContext = new AddEditEmpolyeeViewModel(employees);
        }
    }
}
