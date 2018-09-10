using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string titel;
        private int pageCount;
        private string author;
        private bool hardCover;
        private bool lentOut;

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
        public bool HardCover
        {
            get
            {
                return this.hardCover;
            }
            set
            {
                this.hardCover = value;
            }
        }
        public bool LentOut
        {
            get
            {
                return this.lentOut;
            }
            set
            {
                this.lentOut = value;
            }
        }

        public Book(string titelCon, int pageCountCon, string authorCon, bool hardCoverCon, bool lentOutCon)
        {
            this.titel = titelCon;
            this.pageCount = pageCountCon;
            this.author = authorCon;
            this.hardCover = hardCoverCon;
            this.lentOut = lentOutCon;

        }
        public Book()
        {
           

        }

    }
}
