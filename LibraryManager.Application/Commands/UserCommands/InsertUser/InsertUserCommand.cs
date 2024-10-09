using LibraryManager.Application.Models;
using MediatR;

namespace LibraryManager.Application.Commands.UserCommands.InsertUser
{
    public class InsertUserCommand : IRequest<ResultViewModel>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
