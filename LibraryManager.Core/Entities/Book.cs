using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Core.Entities
{
    public class Book : BaseEntity
    {
        protected Book()
        {

        }

        public Book(string titulo, string author, DateTime publisher, string isbn) : base()
        {
            Titulo = titulo;
            Author = author;
            PublisherDate = publisher;
            ISBN = isbn;

        }

        public string Titulo { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public DateTime PublisherDate { get; private set; }
    }
}
