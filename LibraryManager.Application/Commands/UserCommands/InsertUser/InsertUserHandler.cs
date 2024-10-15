using LibraryManager.Application.Models;
using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
using LibraryManager.Core.Services;
using MediatR;


namespace LibraryManager.Application.Commands.UserCommands.InsertUser
{
    public class InsertUserHandler : IRequestHandler<InsertUserCommand, ResultViewModel>
    {
        private readonly IUserRepository _repository;
        private readonly IAuthService _authService;
        public InsertUserHandler(IUserRepository repository, IAuthService authService)
        {
            _repository = repository;
            _authService = authService;
        }

        public async Task<ResultViewModel> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);
            var user = new User(request.Name, request.Email, passwordHash, request.Role);

            await _repository.Add(user);

            return ResultViewModel.Success();
        }
    }
}
