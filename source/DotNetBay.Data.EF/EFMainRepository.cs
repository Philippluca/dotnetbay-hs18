using DotNetBay.Data.Entity;
using DotNetBay.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBay.Data.EF
{
    class EFMainRepository : IMainRepository
    {
        private MainDbContext context { get; set; }
        EFMainRepository()
        {
            context = new MainDbContext();
        }

        public Auction Add(Auction auction)
        {
            return context.Auctions.Add(auction);
        }

        public Bid Add(Bid bid)
        {
            return context.Bids.Add(bid);
        }

        public Member Add(Member member)
        {
            return context.Members.Add(member);

        }

        public IQueryable<Auction> GetAuctions()
        {
            return context.Auctions;
        }

        public Bid GetBidByTransactionId(Guid transactionId)
        {
            return context.Bids.Where(b => b.TransactionId == transactionId).First();
        }

        public IQueryable<Member> GetMembers()
        {
            return context.Members;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public Auction Update(Auction auction)
        {
            var item = context.Auctions.First(a => a.Id == auction.Id);
            item.Image = auction.Image;
            item.IsClosed = auction.IsClosed;
            item.IsRunning = auction.IsRunning;
            item.Seller = auction.Seller;
            item.StartDateTimeUtc = auction.StartDateTimeUtc;
            item.StartPrice = auction.StartPrice;
            item.Title = auction.Title;
            item.Winner = auction.Winner;
            context.SaveChanges();
            return item;
        }
    }
}
