using LibraryManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Models
{
    public class BookViewModel
    {
        public BookViewModel(string titulo, string author, string iSBN, DateTime publisherDate)
        {
            Titulo = titulo;
            Author = author;
            ISBN = iSBN;
            PublisherDate = publisherDate;
        }

        public string Titulo { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublisherDate { get; set; }

        public static BookViewModel FromEntity(Book book) => new(book.Titulo, book.Author, book.ISBN, book.PublisherDate);
    }
}
