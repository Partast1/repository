using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Methods_files
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder folder = new Folder();

            List<Folder> folderList = new List<Folder>();


            bool repeatBool = true;

            while (repeatBool == true)
            {
                //string[] folders = Directory.GetFiles(@".\", "*", SearchOption.TopDirectoryOnly);
                //for (int i = 0; i < folders.Length; i++)
                //{
                //    Console.WriteLine(folders[i]);
                //}

                //
                folder.DisplayFolders();
               
                FileInfo[] files = new DirectoryInfo(@".\").GetFiles("*.txt", SearchOption.AllDirectories);

                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.DirectoryName + file.Name);
                    //Console.WriteLine(file.FullName);
                    
                }

                //FileInfo file = Directory.GetFiles(("", SearchOption.AllDirectories);
                Console.WriteLine("File Manipulation");

                Console.WriteLine("1. Add file");
                Console.WriteLine("2. Delete file");
                Console.WriteLine("3. Display files");
                Console.WriteLine("4. Add folder");
                Console.WriteLine("5. Search file");
                Console.WriteLine("6. Other stuff ex JPEG");
                Console.WriteLine("7. Exit");

                Console.WriteLine();
                //foreach (Folder foldItem in folderList)
                //{
                //    Console.WriteLine("{0}", foldItem.FolderName);
                //}

                string fileInput = Console.ReadLine();

                switch (fileInput)
                {
                    case "1":

                    break;
                    case "2":
                    break;
                    case "3":
                    break;
                    case "4":
                    Console.WriteLine("Create folder");
                    string folderCreate = Console.ReadLine();
                    folder.CreateFolder(folderCreate);
                    Folder newList = new Folder(folderCreate);
                    folderList.Add(newList);
                    break;
                    case "5":
                    break;
                    case "6":
                    break;
                    case "7":
                    repeatBool = false;
                    break;
                }
            }

        }
    }
}
