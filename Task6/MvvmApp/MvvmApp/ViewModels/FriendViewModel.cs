using MvvmApp.Models;
using System.ComponentModel;

namespace MvvmApp.ViewModels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Friend Friend { get; }
        public FriendViewModel()
        {
            Friend = new Friend();
        }

        private FriendsListViewModel _ListViewModel;
        public FriendsListViewModel ListViewModel
        {
            get => _ListViewModel;
            set
            {
                if (_ListViewModel != value)
                {
                    _ListViewModel = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(ListViewModel)));
                }
            }
        }

        public string Name
        {
            get => Friend.Name;
            set
            {
                if (Friend.Name != value)
                {
                    Friend.Name = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }

        public string Email
        {
            get => Friend.Email;
            set
            {
                if (Friend.Email != value)
                {
                    Friend.Email = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        public string Phone
        {
            get => Friend.Phone;
            set
            {
                if (Friend.Phone != value)
                {
                    Friend.Phone = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Phone)));
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name?.Trim())) &&
                    (!string.IsNullOrEmpty(Phone?.Trim())) &&
                    (!string.IsNullOrEmpty(Email?.Trim())));
            }
        }
    }
}
