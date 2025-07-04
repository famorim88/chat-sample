using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Bot
{
    public interface IBotResponseStrategy
    {
        Task<string> GetResponse();
    }

}
