using Infrastructure.Bot.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Bot
{
    public interface IBotResponseFactory
    {
        IBotResponseStrategy GetStrategy(string userInput);
    }

    public class BotResponseFactory : IBotResponseFactory
    {
        public IBotResponseStrategy GetStrategy(string userInput)
        {
            if (userInput.Trim().ToLower() == "sair")
                return new ExitResponseStrategy();
            return new RandomResponseStrategy();
        }
    }

}
