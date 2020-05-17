using MvvmApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendsListPage : ContentPage
    {
        public FriendsListPage()
        {
            InitializeComponent();
            BindingContext = new FriendsListViewModel(this.Navigation);
        }
    }
}