﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public interface IWeChatRequestEventMessage:IWeChatRequestXmlMessage
    {
        EventType Event { get; }
    }
}
