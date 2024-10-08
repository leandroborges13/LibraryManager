using LibraryManager.Application.Models;
using LibraryManager.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Commands.BookCommands.UpdateBook
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, ResultViewModel>
    {
        private readonly IBookRepository _repository;
        public UpdateBookHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _repository.GetById(request.Id);

            if (book is null)
            {
                return ResultViewModel.Error("Livro não existe.");
            }

            book.Update(request.Titulo, request.Author, request.ISBN, request.PublisherDate);

            await _repository.Update(book);

            return ResultViewModel.Success();
        }
    }
}
