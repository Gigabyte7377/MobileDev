using MvvmApp.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmApp.ViewModels
{
    public class FriendsListViewModel : INotifyPropertyChanged
    {
        private INavigation _navigation;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<FriendViewModel> Friends { get; }
        public ICommand CreateFriendCommand { get; }
        public ICommand DeleteFriendCommand { get; }
        public ICommand SaveFriendCommand { get; }
        public ICommand BackCommand { get; }

        public FriendsListViewModel(INavigation navigation)
        {
            _navigation = navigation ??
                throw new System.ArgumentNullException(nameof(navigation));
            Friends = new ObservableCollection<FriendViewModel>();
            CreateFriendCommand = new Command(CreateFriend);
            DeleteFriendCommand = new Command(DeleteFriend);
            SaveFriendCommand = new Command(SaveFriend);
            BackCommand = new Command(Back);
        }

        private FriendViewModel _SelectedFriend;
        public FriendViewModel SelectedFriend
        {
            get => _SelectedFriend;
            set
            {
                if (_SelectedFriend != value)
                {
                    FriendViewModel tempFriend = value;
                    _SelectedFriend = null;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(SelectedFriend)));
                    _navigation.PushAsync(new FriendPage(tempFriend));
                }
            }
        }

        private void CreateFriend()
        {
            _navigation.PushAsync(new FriendPage(new FriendViewModel { ListViewModel = this }));
        }

        private void Back()
        {
            _navigation.PopAsync();
        }

        private void SaveFriend(object friendObject)
        {
            var friend = friendObject as FriendViewModel;
            if (friend != null && friend.IsValid)
            {
                Friends.Add(friend);
            }
            Back();
        }

        private void DeleteFriend(object friendObject)
        {
            var friend = friendObject as FriendViewModel;
            if (friend != null)
            {
                Friends.Remove(friend);
            }
            Back();
        }
    }
}
