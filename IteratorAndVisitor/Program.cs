using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Author[] authors = { new Author("Alex", 25), new Author("Ivan", 17) };
            var TestArticle = new Article(authors, "Mars");

            IVisitor visitor = new VisitorRealize();
            foreach (var item in TestArticle)
            {
                item.Visit(visitor);
            }

        }
    }
}
