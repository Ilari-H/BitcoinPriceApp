using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3._1.Model
{
    internal class BTC_Model
    {
        [JsonProperty("prices")]
        public List<List<double>> Prices;

        [JsonProperty("market_caps")]
        public List<List<double>> MarketCaps;

        [JsonProperty("total_volumes")]
        public List<List<double>> TotalVolumes;
    }
}
