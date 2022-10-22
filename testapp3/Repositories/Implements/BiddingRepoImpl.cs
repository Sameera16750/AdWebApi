using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using testapp3.Modals.DBAuth;
using testapp3.Modals.Entity;
using testapp3.Repositories.Interfaces;

namespace testapp3.Repositories.Implements
{
    public class BiddingRepoImpl : IBiddingRepo
    {
        private readonly DBAuthContext dBAuthContext;
        public BiddingRepoImpl(DBAuthContext dBAuthContext)
        {
            this.dBAuthContext = dBAuthContext;
        }

        public long addBiddingRecord(EBidding bidding)
        {
            dBAuthContext.biddings.Add(bidding);
            dBAuthContext.SaveChanges();
            return bidding.id;
        }

        public List<EBidding> getPendingBiddings()
        {
            try
            {
                return dBAuthContext.biddings.Include(b=>b.player).Include(b=>b.player.player.user).
                    Include(b=>b.player.player).Include(b=>b.player.player.user.type).Include(b=>b.player.trophy).
                    Include(b=>b.player).Where(b => b.status == 1).ToList();
            }catch(NullReferenceException e)
            {
                return null;
            }
        }

        public long updateBiddingRecord(EBidding bidding)
        {
            dBAuthContext.biddings.Update(bidding);
            dBAuthContext.SaveChanges();
            return bidding.id;
        }
    }
}
