using LibraryManager.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Queries.UserQuery.GetAllUser
{
    public class GetAllUserQuery : IRequest<ResultViewModel<List<UserViewModel>>>
    {
    }
}
