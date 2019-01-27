using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MFoxGame.Models;
using MFoxGame.ViewModels;

namespace MFoxGame.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharactersPage : ContentPage
    {
        private CharactersViewModel _viewModel;

        public CharactersPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = CharactersViewModel.Instance;
        }
    }
}