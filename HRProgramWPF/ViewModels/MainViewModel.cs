using DiaryWPF.Commands;
using HRProgramWPF.Models.Domains;
using HRProgramWPF.Views;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace HRProgramWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Repository _repository = new Repository();
        public MainViewModel()
        {
            AddEmpolyeeCommand = new RelayCommand(AddEmpolyee);
            EditEmpolyeeCommand = new RelayCommand(EditEmpolyee);
            FireEmpolyeeCommand = new RelayCommand(FireEmpolyee);
            FiltrDataCommand = new RelayCommand(FiltrData);
            ShowSettingsCommand = new RelayCommand(ShowSettings);
//            LoadedWindowCommand = new RelayCommand(LoadedWindow);
            ClosingWindowCommand = new RelayCommand(ClosingWindow);

            GetAllEmpolyes();
            SetFiltr();
        }

        public ICommand AddEmpolyeeCommand { get; set; }
        public ICommand EditEmpolyeeCommand { get; set; }
        public ICommand FireEmpolyeeCommand { get; set; }
        public ICommand FiltrDataCommand { get; set; }
        public ICommand ShowSettingsCommand { get; set; }
//        public ICommand LoadedWindowCommand { get; set; }
        public ICommand ClosingWindowCommand { get; set; }
        



        private Employee _selectedEmployee;

        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { _selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Employee> _employees;

        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { 
                
                _employees = value; 
                OnPropertyChanged();
            }
        }


        private int _selectedFiltrId;

        public int SelectedFiltrId
        {
            get { return _selectedFiltrId; }
            set
            {
                _selectedFiltrId = value;
                OnPropertyChanged();
            }
        }




        private ObservableCollection<string> _dataFiltr;

        public ObservableCollection<string> DataFiltr
        {
            get { return _dataFiltr; }
            set { _dataFiltr = value;
                OnPropertyChanged();
            }
        }


        private void SetFiltr ()
        {
            DataFiltr = new ObservableCollection<string> { "Wszyscy", "Zatrudnieni", "Zwolnieni" };
            _selectedFiltrId = 0;
        }


        private void GetAllEmpolyes()
        {

            Employees = new ObservableCollection<Employee>(_repository.GetEmployees());
        }

        private void ShowSettings(object obj)
        {
            var dbWindow = new DbSettings(true);
            dbWindow.ShowDialog();
        }

        private void FiltrData(object _selectedFiltrId)
        {
            if ((int)_selectedFiltrId == 0) GetAllEmpolyes();
            else if ((int)_selectedFiltrId == 1)
                Employees= new ObservableCollection<Employee>(_repository.SelectEmployed());
            else Employees = new ObservableCollection<Employee>(_repository.SelectUnempolyed());
        }

        private void FireEmpolyee(object obj)
        {
           var selectedEmp = SelectedEmployee;
            _repository.FireEmpolyee(selectedEmp);
        }

        private void EditEmpolyee(object obj)
        {
            var addEmpWindow = new AddEditEmpolyee(SelectedEmployee);
            addEmpWindow.ShowDialog();
        }

        private void AddEmpolyee(object obj)
        {
            var addEmpWindow = new AddEditEmpolyee(obj as Employee);
            addEmpWindow.ShowDialog();
            GetAllEmpolyes();
        }

        private void ClosingWindow(object obj)
        {
            Application.Current.Shutdown();
        }


        //private async void LoadedWindow(object obj)
        //{
        //    if (!IsConnectionStringValid())
        //    {
        //        var metroWindow = Application.Current.MainWindow as MetroWindow;

        //        var dialog = await metroWindow.ShowMessageAsync("Błąd połaczenia do bazy danych", "Czy chcesz poprawić ustawienia do bazy danych?", MessageDialogStyle.AffirmativeAndNegative);

        //        if (dialog == MessageDialogResult.Negative)
        //        {
        //            Application.Current.Shutdown();
        //        }
        //        else
        //        {
        //            var settingsWindow = new DbSettings(false);
        //            settingsWindow.ShowDialog();
        //        }
        //    }
        //    else
        //    {
        //        GetAllEmpolyes();
        //        SetFiltr();
        //    }
        //}

        //private bool IsConnectionStringValid()
        //{
        //    try
        //    {
        //        using (var context = new ApplicationDbContext())
        //        {
        //            context.Database.Connection.Open();
        //            context.Database.Connection.Close();
        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

    }
}
