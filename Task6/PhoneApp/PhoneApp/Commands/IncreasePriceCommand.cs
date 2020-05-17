using PhoneApp.ViewModel;
using System;
using System.Windows.Input;

namespace PhoneApp.Commands
{
    class IncreasePriceCommand : ICommand
    {
        private readonly PhoneViewModel _viewModel;

        public IncreasePriceCommand(PhoneViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _viewModel.Price < 60000;
        }

        public void Execute(object parameter)
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            if (CanExecute(parameter))
            {
                _viewModel.OnIncreasePrice();
            }
        }
    }
}
