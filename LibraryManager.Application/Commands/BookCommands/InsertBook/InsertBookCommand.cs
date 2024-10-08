using LibraryManager.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Commands.BookCommands.InsertBook
{
    public class InsertBookCommand : IRequest<ResultViewModel>
    {
        public string Titulo { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublisherDate { get; set; }
    }
}
