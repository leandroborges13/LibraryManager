using LibraryManager.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Queries.UserQuery.GetUserDetailsById
{
    public class GetUserDetailsByIdQuery : IRequest<ResultViewModel<UserViewModel>>
    {
        public GetUserDetailsByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
