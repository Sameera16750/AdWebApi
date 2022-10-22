using System.Collections.Generic;
using testapp3.Payloads;

namespace testapp3.Services.InterFaces
{
    public interface IBidding
    {
        public List<BiddingResponse> GetAllPendingPayloads();

        public DefaultResponse updateBiddingRecord(BiddingPayload bidding);
    }
}
