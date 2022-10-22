using System.Collections.Generic;
using testapp3.Modals.Entity;
using testapp3.Payloads;

namespace testapp3.Repositories.Interfaces
{
    public interface IBiddingRepo
    {
        public long addBiddingRecord(EBidding bidding);
        public List<EBidding> getPendingBiddings();

        public long updateBiddingRecord(EBidding bidding);
    }
}
