using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[]books)
        {
            this.books = books.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            books.OrderBy(b => b, new BookComparator()).ToList();
            return this.books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index = -1;
            public LibraryIterator()
            {
                books = new List<Book>();
            }
            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                index++;
                return index < books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
