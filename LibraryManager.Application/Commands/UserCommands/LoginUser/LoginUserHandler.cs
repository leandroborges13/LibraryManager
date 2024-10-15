
using LibraryManager.Core.Services;
using LibraryManager.Application.Models;
using MediatR;
using LibraryManager.Core.Repositories;


namespace LibraryManager.Application.Commands.LoginUser
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, ResultViewModel<LoginUserViewModel>>
    {
        private readonly IAuthService _authService;
        private readonly IUserRepository _userRepository;
        public LoginUserHandler(IAuthService authService, IUserRepository userRepository)
        {
            _authService = authService;
            _userRepository = userRepository;
        }
        public async Task<ResultViewModel<LoginUserViewModel>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);
            var user = await _userRepository.GetByEmailAndPasswordAsync(request.Email, passwordHash);

            if (user is null)
            {
                return ResultViewModel<LoginUserViewModel>.Error("Usuário não existe.");
            }

            var token = _authService.GenerateJWTToken(user.Email, user.Role);

            var model = new LoginUserViewModel(user.Email, token);

            return ResultViewModel<LoginUserViewModel>.Success(model);
        }
    }
}

