using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class AuthorTest
{
        [Test]
        public void authorForBooks()
        {
            Book book = new Book("Hitchhiker's Guide to the Galaxy");
            Author douglasAdams = new Author("Douglas Adams", "", "http://douglasadams.com/");
            book.addAuthor(douglasAdams);
            Assert.That(book.author, Is.EqualTo(douglasAdams));
        }

        [Test]
        public void authorForNewspaper()
        {
            Article article = new Article("Hitchhiker's Guide to the Galaxy");
            Author douglasAdams = new Author("Douglas Adams", "", "http://douglasadams.com/");
            article.addAuthor(douglasAdams);
            Assert.That(article.author, Is.EqualTo(douglasAdams));
        }
    }
}
