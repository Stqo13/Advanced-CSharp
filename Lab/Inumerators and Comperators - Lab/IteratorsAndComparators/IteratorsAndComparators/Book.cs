using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book:IComparable<Book>
    {
        public Book(string title, int year, params string[]authors)
        {
			Title = title;
			Year = year;
			Authors = authors.ToList();
        }
        private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}
		private List<string> authors;

		public List<string> Authors
		{
			get { return authors; }
			set { authors = value; }
		}
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }

        public int CompareTo(Book other)
        {
            int result = Year.CompareTo(other.Year);
			if (result==0)
			{
				return Title.CompareTo(other.Title);
			}
			return result;
        }
    }
}
