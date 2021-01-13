using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    class AuthorEnumerator : IEnumerator
    {
        public Author[] _authors;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public AuthorEnumerator(Author[] authors)
        {
            _authors = authors;
        }
        
        public bool MoveNext()
        {
            position++;
            return (position < _authors.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Author Current
        {
            get
            {
                try
                {
                    return _authors[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
