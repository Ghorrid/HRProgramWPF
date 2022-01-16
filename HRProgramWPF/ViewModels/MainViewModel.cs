using DiaryWPF.Commands;
using HRProgramWPF.Models.Domains;
using HRProgramWPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            RefreshDataCommand = new RelayCommand(RefreshData);
            ShowSettingsCommand = new RelayCommand(ShowSettings);

            GetData();
        }

        public ICommand AddEmpolyeeCommand { get; set; }
        public ICommand EditEmpolyeeCommand { get; set; }
        public ICommand FireEmpolyeeCommand { get; set; }
        public ICommand RefreshDataCommand { get; set; }
        public ICommand ShowSettingsCommand { get; set; }

        private Employees _selectedEmployee;

        public Employees SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { _selectedEmployee = value;
                OnPropertyChanged();
            }
        }



        private ObservableCollection<Employees> _employees;

        public ObservableCollection<Employees> Employees
        {
            get { return _employees; }
            set { 
                
                _employees = value; 
                OnPropertyChanged();
            }
        }

        public List<string> DataFiltr = new List<string> { "Wszyscy", "zatrudnieni", "zwolnieni" };


        private void GetData()
        {

            Employees = new ObservableCollection<Employees>(_repository.GetEmployees());
        }

        private void ShowSettings(object obj)
        {
            var dbWindow = new DbSettings();
            dbWindow.ShowDialog();
        }

        private void RefreshData(object obj)
        {
            GetData();
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
            var addEmpWindow = new AddEditEmpolyee(obj as Employees);
            addEmpWindow.ShowDialog();
        }


    }
}
