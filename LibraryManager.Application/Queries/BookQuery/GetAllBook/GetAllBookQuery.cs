using LibraryManager.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Queries.BookQuery
{
    public class GetAllBookQuery : IRequest<ResultViewModel<List<BookViewModel>>>
    {

    }
}
