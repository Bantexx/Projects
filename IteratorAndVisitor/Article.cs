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
        private string name;
        private Author[] authors;
        public Article(Author[] _authors,string _name)
        {
            authors =_authors;
            name = _name;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public AuthorEnumerator GetEnumerator()
        {
            return new AuthorEnumerator(authors);
        }      
    }
}
