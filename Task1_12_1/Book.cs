using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_12_1
{
    internal class Book <T,U>
     
    {
        public T Code { get; set; }
        public string Title { get; set; }
        public U PublicationYear { get; set; }
        public string Author { get; set; }
        public Book(T code, string title, U publicationYear, string author)
        {
            Code = code;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        public override string ToString()
        {

            return $"{Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})" ;
        }
    }
}
