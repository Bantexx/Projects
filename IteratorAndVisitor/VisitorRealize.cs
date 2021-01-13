using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    class VisitorRealize : IVisitor
    {
        public void VisitCustomAuthor(object author)
        {
            var auth = author as Author;
            Console.WriteLine("Элемент маркирован с именем: "+auth.Name);
        }
        
    }
}
