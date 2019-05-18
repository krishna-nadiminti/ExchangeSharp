/*
MIT LICENSE

Copyright 2018 - Krishna Nadiminti

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace ExchangeSharp
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>Result of a user's trade on an exchange</summary>
    public sealed class UserTradeResult
    {
        public UserTradeResult(params KeyValuePair<string, object>[] otherProperties)
        {
            OtherProperties =
                (otherProperties ?? Enumerable.Empty<KeyValuePair<string, object>>())
                .ToDictionary(k => k.Key, v => v.Value);
        }

        /// <summary>Order id</summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Trade amount in the market currency.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The price of the trade in the ratio of base/market currency.
        /// E.g. 0.000342 ADA/ETH
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The fees on the trade (not a percent).
        /// E.g. 0.0025 ETH
        /// </summary>
        public decimal Fees { get; set; }

        /// <summary>The id of the trade</summary>
        public string TradeId { get; set; }

        public IReadOnlyDictionary<string, object> OtherProperties { get; }

        /// <summary>Returns a string that represents this instance.</summary>
        /// <returns>A string that represents this instance.</returns>
        public override string ToString()
        {
            return $"[Trade: {TradeId} in order {OrderId}. Amount {Amount}, Fees: {Fees}";
        }
    }
}
