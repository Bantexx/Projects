using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    class Author
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Author(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void Visit(IVisitor visit)
        {
            visit.VisitCustomAuthor(this);
        }

    }
}
