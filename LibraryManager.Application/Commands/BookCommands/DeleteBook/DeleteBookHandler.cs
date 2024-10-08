using LibraryManager.Application.Models;
using LibraryManager.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Commands.BookCommands.DeleteBook
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, ResultViewModel>
    {
        private readonly IBookRepository _repository;
        public DeleteBookHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _repository.GetById(request.Id);

            if (book is null)
            {
                return ResultViewModel.Error("Livro não existe.");
            }

            book.SetAsDeleted();
            await _repository.Update(book);

            return ResultViewModel.Success();
        }
    }
}
