using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : AItem{

        public Author author { get; private set; }

        public Article(string title) : base(title) {
            this.title = title;
        }



        public void addAuthor(Author author)
        {
            this.author = author;
        }
    }
}
