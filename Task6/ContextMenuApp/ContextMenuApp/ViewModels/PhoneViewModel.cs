using ContextMenuApp.Models;
using System.ComponentModel;

namespace ContextMenuApp.ViewModels
{
    public class PhoneViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Phone Phone { get; }
        public PhonesListViewModel ListViewModel { get; set; }
        public PhoneViewModel()
        {
            Phone = new Phone();
        }

        public string Title
        {
            get => Phone.Title;
            set
            {
                if (Phone.Title != value)
                {
                    Phone.Title = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Title)));
                }
            }
        }
        public string Company
        {
            get => Phone.Company;
            set
            {
                if (Phone.Company != value)
                {
                    Phone.Company = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Company)));
                }
            }
        }
        public int Price
        {
            get => Phone.Price;
            set
            {
                if (Phone.Price != value)
                {
                    Phone.Price = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Price)));
                }
            }
        }
    }
}
