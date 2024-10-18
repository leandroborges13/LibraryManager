using LibraryManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.UnitTests.Core.Entities
{
    public class UserTests
    {
        [Fact]
        public void TestIfUserValidWorks()
        {
            var user = new User("Name Test", "emailtest@emaitest.com.br", "teds323423", "user");


            Assert.NotNull(user.Name);
            Assert.NotEmpty(user.Name);

            Assert.NotNull(user.Email);
            Assert.NotEmpty(user.Email);

        }
    }
}
