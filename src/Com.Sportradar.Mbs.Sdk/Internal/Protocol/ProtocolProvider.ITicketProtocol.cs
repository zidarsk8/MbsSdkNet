using Com.Sportradar.Mbs.Sdk.Entities.Request;
using Com.Sportradar.Mbs.Sdk.Entities.Response;
using Com.Sportradar.Mbs.Sdk.Protocol;

namespace Com.Sportradar.Mbs.Sdk.Internal.Protocol;

internal partial class ProtocolProvider : ITicketProtocol
{
    internal ITicketProtocol TicketProtocol => this;

    public async Task<TicketResponse> SendTicketAsync(TicketRequest request)
    {
        return await ProcessRequestAsync<TicketResponse>("ticket-placement", request).ConfigureAwait(false);
    }

    public async Task<TicketAckResponse> SendTicketAckAsync(TicketAckRequest request)
    {
        return await ProcessRequestAsync<TicketAckResponse>("ticket-ack", request).ConfigureAwait(false);
    }

    public async Task<CancelResponse> SendCancelAsync(CancelRequest request)
    {
        return await ProcessRequestAsync<CancelResponse>("cancel", request).ConfigureAwait(false);
    }

    public async Task<CancelAckResponse> SendCancelAckAsync(CancelAckRequest request)
    {
        return await ProcessRequestAsync<CancelAckResponse>("cancel-ack", request).ConfigureAwait(false);
    }

    public async Task<CashoutResponse> SendCashoutAsync(CashoutRequest request)
    {
        return await ProcessRequestAsync<CashoutResponse>("cashout", request).ConfigureAwait(false);
    }

    public async Task<CashoutAckResponse> SendCashoutAckAsync(CashoutAckRequest request)
    {
        return await ProcessRequestAsync<CashoutAckResponse>("cashout-ack", request).ConfigureAwait(false);
    }

    public async Task<ExtSettlementResponse> SendExtSettlementAsync(ExtSettlementRequest request)
    {
        return await ProcessRequestAsync<ExtSettlementResponse>("ext-settlement", request).ConfigureAwait(false);
    }

    public async Task<ExtSettlementAckResponse> SendExtSettlementAckAsync(ExtSettlementAckRequest request)
    {
        return await ProcessRequestAsync<ExtSettlementAckResponse>("ext-settlement-ack", request).ConfigureAwait(false);
    }
}