using PhoneApp.Commands;
using PhoneApp.Model;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhoneApp.ViewModel
{
    public class PhoneViewModel : INotifyPropertyChanged
    {
        private Phone _phone;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand Increase { get; }

        public PhoneViewModel()
        {
            _phone = new Phone();

            //реализация собственным классом
            //Increase = new IncreasePriceCommand(this);
            //использование встроенной реализации
            Increase = new Command(execute: OnIncreasePrice, canExecute: CanIncreasePrice);
        }

        public void OnIncreasePrice()
        {
            if (_phone != null)
                Price += 1000;
            //вызываем событие CanExecuteChanged
            (Increase as Command).ChangeCanExecute();
        }

        private bool CanIncreasePrice()
        {
            return Price < 60000;
        }

        public string Title
        {
            get => _phone.Title;
            set
            {
                if (_phone.Title != value)
                {
                    _phone.Title = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Title)));
                }
            }
        }

        public string Company
        {
            get => _phone.Company;
            set
            {
                if (_phone.Company != value)
                {
                    _phone.Company = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Company)));
                }
            }
        }

        public int Price
        {
            get => _phone.Price;
            set
            {
                if (_phone.Price != value)
                {
                    _phone.Price = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Price)));
                }
            }
        }
    }

}
