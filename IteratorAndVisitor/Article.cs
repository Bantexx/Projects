using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    class Article : IEnumerable
    {
        private Author[] _authors;
        public Article(Author[] authors)
        {
            _authors = authors;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public AuthorEnumerator GetEnumerator()
        {
            return new AuthorEnumerator(_authors);
        }      
    }
}
