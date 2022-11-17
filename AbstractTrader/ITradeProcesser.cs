using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTrader
{
    public interface ITradeProcesser
    {
        void ProcessTrades(Stream stream);

    }
}
