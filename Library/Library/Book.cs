using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libaryfree
{
    class Book
    {
        private string author;
        private int pageCount;
        private string titel;
        private int id;

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
            }
        }
        public int PageCount
        {
            get
            {
                return this.pageCount;
            }
            set
            {
                this.pageCount = value;
            }
        }
        public string Titel
        {
            get
            {
                return this.titel;
            }
            set
            {
                this.titel = value;
            }

        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public Book(string conAuthor, int conPageCount, string conTitel, int conId)
        {
            this.author = conAuthor;
            this.pageCount = conPageCount;
            this.titel = conTitel;
            this.id = conId;
        }

    }
}
