using DotNetBay.Core;
using DotNetBay.Data.Entity;
using DotNetBay.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBay.WPF.ViewModel
{
    class MainViewModel: ViewModelBase
    {
        private AuctionService auctionService;
        ObservableCollection<Auction> auctions = new ObservableCollection<Auction>();
        public ObservableCollection<Auction> Auctions { get => auctions; }

        public MainViewModel(IMainRepository mainRepository)
        {
            this.auctionService = new AuctionService(mainRepository, new SimpleMemberService(mainRepository));
            this.auctions = new ObservableCollection<Auction>(this.auctionService.GetAll());
        }
    }
}
