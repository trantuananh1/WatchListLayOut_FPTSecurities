using FPT_Securities.Models;
using FPT_Securities.Views;
using MvvmHelpers;
using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Rg.Plugins.Popup.Services;

namespace FPT_Securities.ViewModels
{
    public class WatchListViewModel : INotifyPropertyChanged
    {
        public bool IsVisibleChange
        {
            get => isVisibleChange;
            set {
                isVisibleChange = value;
                OnPropertyChanged();
            }
        }

        private bool isVisibleChange;
       
        public List<WatchList> WatchLists { get; set; }
        public IEnumerable<WatchList> GetWatchLists()
        {
            return new List<WatchList>
            {
                new WatchList{Symbol="FTS", MatchPrice=13.8, Change=3.2, ChangePct=0.5, Quantity=45504400, MatchColor="Green"},
                new WatchList{Symbol="HPG", MatchPrice=2.8, Change=3, ChangePct=-0.2, Quantity=254000, MatchColor="Red"},
                new WatchList{Symbol="ACB", MatchPrice=5.1, Change=5, ChangePct=3.2, Quantity=354000, MatchColor="Green"},
                new WatchList{Symbol="SSI", MatchPrice=23.1, Change=1, ChangePct=-3.5, Quantity=124000, MatchColor="Red"},
                new WatchList{Symbol="LSB", MatchPrice=32.2, Change=6, ChangePct=1.2, Quantity=14000, MatchColor="Black"},
                new WatchList{Symbol="VNM", MatchPrice=7.2, Change=6, ChangePct=1.8, Quantity=145000, MatchColor="Green"},
                new WatchList{Symbol="MTA", MatchPrice=1.2, Change=0, ChangePct=0, Quantity=40300, MatchColor="Orange"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=6, ChangePct=6.2, Quantity=140200, MatchColor="Black"},
                new WatchList{Symbol="MNA", MatchPrice=36.2, Change=0, ChangePct=-0, Quantity=140200, MatchColor="Orange"},
                new WatchList{Symbol="MIC", MatchPrice=36.2, Change=16, ChangePct=1.2, Quantity=140200, MatchColor="Black"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=64, ChangePct=6.2, Quantity=140200, MatchColor="Black"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=61, ChangePct=-5.2, Quantity=140200, MatchColor="Red"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=64, ChangePct=6.2, Quantity=140200, MatchColor="Black"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=23, ChangePct=-6.2, Quantity=140200, MatchColor="Red"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=46, ChangePct=5.2, Quantity=140200, MatchColor="Green"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=53, ChangePct=1.2, Quantity=140200, MatchColor="Green"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=64, ChangePct=6.2, Quantity=140200, MatchColor="Black"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=16, ChangePct=6.2, Quantity=140200, MatchColor="Black"},
                new WatchList{Symbol="MBS", MatchPrice=36.2, Change=6, ChangePct=6.2, Quantity=140200, MatchColor="Black"},

            };
        }
        private readonly INavigation _navigation;

        public event PropertyChangedEventHandler PropertyChanged;

        public Command SearchStockCommand { get; }
        public Command WatchlistCommand { get; }
        public Command CategoryPopupCommand { get; }
        public Command ChangeClickedCommand { get; }

        //-----------------------excute function ---------------------
        public WatchListViewModel(INavigation navigation)
        {
            WatchLists = new List<WatchList>(GetWatchLists());

            SearchStockCommand = new Command(SearchStock);
            WatchlistCommand = new Command(Watchlist);
            CategoryPopupCommand = new Command(CategoryPopup);
            ChangeClickedCommand = new Command(ChangeClicked);
            _navigation = navigation;

            IsVisibleChange = true;

        }
        private void SearchStock()
        {
            _navigation.PushAsync(new SearchStockPage());
        }
        private void Watchlist()
        {
            _navigation.PushAsync(new WatchlistPage());
        }

        [Obsolete]
        private void CategoryPopup()
        {
            PopupNavigation.PushAsync(new CategoryPopupPage());
        }

        private void ChangeClicked()
        {
           IsVisibleChange = !IsVisibleChange;
        }
       
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
