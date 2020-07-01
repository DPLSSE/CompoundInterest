using System;

namespace CompoundInterestBackend.Common.Contracts
{
    public class AmbientContext
    {
        public string AuthToken { get; set; }

        public Guid SessionId { get; set; }

        public int SellerId { get; set; }
    }
}
