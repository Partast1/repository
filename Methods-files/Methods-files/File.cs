using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_files
{
    class File
    {
        private string fileName;

        public string Filename
        {
            get
            {
                return fileName;
            }
            set
            {
                this.fileName = value;
            }
        }
    }
}
