using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Lesson.Files
{
    internal class WorkingWithFiles
    {
        public static void Start()
        {
             DirectoryInfo directory = new DirectoryInfo("D:\\folder");
            if(directory.Exists && directory.GetFiles().Length > 0)
            {
                Console.WriteLine("Papka  va fayllar bor");
            }
            else if (directory.GetFiles().Length > 0)
            {
                Console.WriteLine("Fayllar bor");
            }
            else if(directory.Exists)
            {
                Console.WriteLine("Papkalar bor");
            }
            else
                Console.WriteLine("Papka bo'sh");
            
        }
        public static void AllLines()
        {
            var lineCount = File.ReadAllLines("D:\\New folder\\mystr.txt").Length;
            Console.WriteLine(lineCount);
        }
        public static void CopyFile()
        {
            FileInfo fileInfo = new FileInfo("D:\\New folder\\mystr.txt");
            fileInfo.CopyTo("D:\\New folder\\all11.txt");

        }
        public static void CombineMultipleFilesIntoSingleFile()
        {
            string path1 = "D:\\New folder\\all.txt";
            string path2 = "D:\\New folder\\all11.txt";
            string path3 = "D:\\New folder\\mystr.txt";

            File.AppendAllText(path3, File.ReadAllText(path1));
            File.AppendAllText(path3, File.ReadAllText(path2));

        }


        }


    }




}

