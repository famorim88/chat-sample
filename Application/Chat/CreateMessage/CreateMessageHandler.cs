using Domain.Entites;
using Infrastructure.Bot;
using Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Chat.CreateMessage
{
    public class CreateMessageHandler : IRequestHandler<CreateMessageCommand, List<Message>>
    {
        private readonly ChatDbContext _context;
        private readonly IUnitOfWork _uow;
        private readonly IBotResponseFactory _botFactory;

        public CreateMessageHandler(ChatDbContext context, IUnitOfWork uow, IBotResponseFactory botFactory)
        {
            _context = context;
            _uow = uow;
            _botFactory = botFactory;
        }

        public async Task<List<Message>> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var userMsg = new Message { Text = request.Text, Sender = SenderType.User };
            _context.Messages.Add(userMsg);

            var botStrategy = _botFactory.GetStrategy(request.Text);
            var botResponseText = botStrategy.GetResponse();
            var botMsg = new Message { Text = botResponseText, Sender = SenderType.Bot };
            _context.Messages.Add(botMsg);

            await _uow.CommitAsync();

            return new List<Message> { userMsg, botMsg };
        }
    }

}
