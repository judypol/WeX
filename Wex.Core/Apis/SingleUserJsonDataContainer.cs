﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class SingleUserJsonDataContainer : IJsonRequestContainer
    {
        [JsonProperty("openid")]
        public string OpenId { get; set; }
    }
}
