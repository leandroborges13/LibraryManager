using LibraryManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.UnitTests.Core.Entities
{
    public class BookTests
    {
        [Fact]
        public void TestIfBookValidWorks()
        {
            var book = new Book("title test", "author test", DateTime.Now, "isbn test");


            Assert.NotNull(book.Titulo);
            Assert.NotEmpty(book.Titulo);

            Assert.NotNull(book.Author);
            Assert.NotEmpty(book.Author);

        }
    }
}
