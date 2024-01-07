using Com.Sportradar.Mbs.Sdk.Entities.Request;
using Com.Sportradar.Mbs.Sdk.Entities.Response;

namespace Com.Sportradar.Mbs.Sdk.Protocol;

public interface ITicketProtocol
{
    Task<TicketResponse> SendTicketAsync(TicketRequest request);
    Task<TicketAckResponse> SendTicketAckAsync(TicketAckRequest request);

    Task<CancelResponse> SendCancelAsync(CancelRequest request);
    Task<CancelAckResponse> SendCancelAckAsync(CancelAckRequest request);

    Task<CashoutResponse> SendCashoutAsync(CashoutRequest request);
    Task<CashoutAckResponse> SendCashoutAckAsync(CashoutAckRequest request);

    Task<ExtSettlementResponse> SendExtSettlementAsync(ExtSettlementRequest request);
    Task<ExtSettlementAckResponse> SendExtSettlementAckAsync(ExtSettlementAckRequest request);
}