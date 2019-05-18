namespace ExchangeSharp.BitMEX
{
    /*
     example sell:
     
  {
    "symbol": "XBTUSD",
    "id": 8799483500,
    "side": "Sell",
    "size": 1635621,
    "price": 5165
  }

  example buy:

  {
    "symbol": "XBTUSD",
    "id": 8799483550,
    "side": "Buy",
    "size": 273296,
    "price": 5164.5
  }

    */
    class OrderBookItem
    {
        public string Symbol { get; set; }
        public long Id { get; set; }
        public OrderSide Side { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Commonly known as Amount / Qty
        /// </summary>
        public decimal Size { get; set; }

        public bool IsAsk => Side == OrderSide.Sell;
    }

    enum OrderSide
    {
        Sell,
        Buy
    }
}
