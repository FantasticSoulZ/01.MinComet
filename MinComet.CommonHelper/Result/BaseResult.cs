using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.CommonHelper.Result
{
    public class BaseResult
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("other")]
        public object Other { get; set; }
    }
}
