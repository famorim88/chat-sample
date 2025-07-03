using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Bot.Strategies
{
    public class RandomResponseStrategy : IBotResponseStrategy
    {
        private static readonly string[] Responses = {
        "Como posso te ajudar?", "Tudo certo por aqui!", "Pode repetir por favor?", "Estou aqui para ajudar."
    };

        public string GetResponse()
        {
            var rnd = new Random();
            return Responses[rnd.Next(Responses.Length)];
        }
    }

}
