using DiaryWPF.Commands;
using HRProgramWPF.Models.Domains;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HRProgramWPF.ViewModels
{
    public class AddEditEmpolyeeViewModel : ViewModelBase
    {

        private  Repository _repository  = new Repository();

        public bool IsUpdate = false;

        public AddEditEmpolyeeViewModel( Employee employee = null)
        {
             CancelCommand = new RelayCommand(Cancel);
             ConfirmCommand = new RelayCommand(Confirm);

            if (employee == null)
            {
                Employees = new Employee();
            }
            else
            {
                Employees = employee;
                IsUpdate = true;
            }

        }

        public ICommand CancelCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        private Employee _employees;

        public Employee Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                OnPropertyChanged();
            }
        }

        private Employee _selectedEmpolyee;
        public Employee SelectedEmpoloyee
        {
            get { return _selectedEmpolyee; }
            set
            {
                _selectedEmpolyee = value;
                OnPropertyChanged();
            }
        }

        private void Confirm(object obj)
        {

            if (IsUpdate) _repository.EdidEmployee(Employees);
            else
            _repository.AddNewEmployee(Employees);
            CloseWindow(obj as Window);
        }

        private void Cancel(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }

    }
}
