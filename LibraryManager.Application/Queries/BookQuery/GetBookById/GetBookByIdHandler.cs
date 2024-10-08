using LibraryManager.Application.Models;
using LibraryManager.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Queries.BookQuery.GetBookById
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, ResultViewModel<BookViewModel>>
    {
        private readonly IBookRepository _repository;
        public GetBookByIdHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<BookViewModel>> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _repository.GetById(request.Id);

            if (book is null)
            {
                return ResultViewModel<BookViewModel>.Error("Livro não existe.");
            }

            var model = BookViewModel.FromEntity(book);

            return ResultViewModel<BookViewModel>.Success(model);
        }
    }
}
