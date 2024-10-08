using LibraryManager.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Commands.BookCommands.InsertBook
{
    public class InsertBookHandler : IRequestHandler<InsertBookCommand, ResultViewModel>
    {
        public Task<ResultViewModel> Handle(InsertBookCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
