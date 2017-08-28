using MediatR;
using System;
using Yuxi.Notifications.Application.Commands.UserCommand;
using Yuxi.Notifications.Domain.AggregatesModel.UserAggregate;

namespace Yuxi.Notifications.Application.Handlers.UserHandler
{
    public class RegisterUserNotificationHandler : IRequestHandler<RegisterUserNotificationCommand, bool>
    {

        private readonly IUserRegistryRepository _repository;

        public RegisterUserNotificationHandler(IUserRegistryRepository repository)
        {
            _repository = repository;
        }

        public bool Handle(RegisterUserNotificationCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
