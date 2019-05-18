using System;
namespace ExchangeSharp.BitMEX
{
    /// <summary>
    /// See:
    /// https://www.bitmex.com/app/wsAPI#Subscriptions,
    /// https://www.bitmex.com/api/explorer/#!/Execution/Execution_get,
    /// and
    /// http://www.onixs.biz/fix-dictionary/5.0.SP2/msgType_8_8.html
    ///
    /// Each ws message looks like WSMessage<T>, where T is `ExecutionRecord` in this case
    /// </summary>
    class ExecutionRecord
    {
        public string ExecId { get; set; }
        public string OrderId { get; set; }
        public string ClOrdId { get; set; }
        public string ClOrdLinkId { get; set; }
        public long Account { get; set; }
        public string Symbol { get; set; }
        public string Side { get; set; }
        public long LastQty { get; set; }
        public long LastPx { get; set; }
        public long UnderlyingLastPx { get; set; }
        public string LastMkt { get; set; }
        public string LastLiquidityInd { get; set; }
        public long SimpleOrderQty { get; set; }
        public long OrderQty { get; set; }
        public long Price { get; set; }
        public long DisplayQty { get; set; }
        public long StopPx { get; set; }
        public long PegOffsetValue { get; set; }
        public string PegPriceType { get; set; }
        public string Currency { get; set; }
        public string SettlCurrency { get; set; }
        public string ExecType { get; set; }
        public string OrdType { get; set; }
        public string TimeInForce { get; set; }
        public string ExecInst { get; set; }
        public string ContingencyType { get; set; }
        public string ExDestination { get; set; }
        public string OrdStatus { get; set; }
        public string Triggered { get; set; }
        public bool WorkingIndicator { get; set; }
        public string OrdRejReason { get; set; }
        public long SimpleLeavesQty { get; set; }
        public long LeavesQty { get; set; }
        public long SimpleCumQty { get; set; }
        public long CumQty { get; set; }
        public long AvgPx { get; set; }
        public long Commission { get; set; }
        public string TradePublishIndicator { get; set; }
        public string MultiLegReportingType { get; set; }
        public string Text { get; set; }
        public string TrdMatchId { get; set; }
        public long ExecCost { get; set; }
        public long ExecComm { get; set; }
        public long HomeNotional { get; set; }
        public long ForeignNotional { get; set; }
        public DateTimeOffset TransactTime { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}

