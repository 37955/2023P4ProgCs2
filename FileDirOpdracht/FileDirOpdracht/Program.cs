using System;
using System.IO;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pjotr\OneDrive - Mediacollege Amsterdam\ma\bewijzenmap\1.4\2023P4ProgCs2";
 
            DirectoryInfo dir = new DirectoryInfo(path);

            FileInfo[] files = dir.GetFiles();
            
            Console.WriteLine("Files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            
            DirectoryInfo[] directories = dir.GetDirectories();
            
            Console.WriteLine("\nDirectories:");
            foreach (DirectoryInfo directory in directories)
            {
                Console.WriteLine(directory.Name);
            }
        }
    }
}
