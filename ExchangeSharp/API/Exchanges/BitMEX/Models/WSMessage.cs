namespace ExchangeSharp.BitMEX
{
    class WSMessage<T>
    {
        public string Error { get; set; }
        public T[] Data { get; set; }
    }
}
