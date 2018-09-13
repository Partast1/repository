using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_files
{
    public class Folder
    {
        private string folderName;

        public string FolderName
        {
            get
            {
                return folderName;
            }
            set
            {
                this.folderName = value;
            }
        }

       

        public Folder (String Confolder)
        {
            this.folderName = Confolder;
        }

        public Folder( )
        { 
            
        }
        //Method to Create a folder
        public string CreateFolder(string metFolder)
        {
            string Foldername = metFolder;
            Directory.CreateDirectory(@".\" + metFolder);

            return metFolder;   
        }
    }
}
