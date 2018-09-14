using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_files
{
    public class Filehandel
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
        public Filehandel(string conFile)
        {
            this.fileName = conFile;
        }
        public Filehandel( )
        {
         
        }
        public void DisplayFile()
        {
            FileInfo[] files = new DirectoryInfo(@".\").GetFiles("*.txt", SearchOption.AllDirectories);

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.DirectoryName + file.Name);
                //Console.WriteLine(file.FullName);

            }
        }
    }
}
