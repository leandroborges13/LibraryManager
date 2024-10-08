using LibraryManager.Application.Models;
using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
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
        private readonly IBookRepository _repository;
        public InsertBookHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(InsertBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Titulo, request.Author, request.PublisherDate, request.ISBN);

            await _repository.Add(book);

            return ResultViewModel.Success();
        }
    }
}
