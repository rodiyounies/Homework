using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SizeOfFileOrFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            //input -numele unui fisier/folder
            //output- dimensiunea fisierului /folderului 

            Console.Write("Enter File/Directory Name (Example: C:\\temp): ");
            string filename = Console.ReadLine();
            Console.WriteLine();

            Program p = new Program();


            FileAttributes fileAttributes = File.GetAttributes(filename);
            if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                p.printDirectoryInfo(filename);
            } else
            {
                p.printFileInfo(filename);
            }
                
            Console.ReadKey();
        }

        public void printDirectoryInfo(string filename)
        {
            Console.WriteLine("Directory Information For [" + filename + "]");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Size On Disk: " + GetDirectorySizeOnDisk(filename) + " bytes");
            Console.WriteLine("-----------------------------------------");
        }
        
        public long GetDirectorySizeOnDisk(string filename)
        {
            long totalSize = 0L;
            string[] files = Directory.GetFiles(filename);
            foreach (string file in files)
            {
                totalSize += GetFileSizeOnDisk(file);
            }

            string[] directories = Directory.GetDirectories(filename);
            foreach (string dir in directories)
            {
                totalSize += GetDirectorySizeOnDisk(dir);
            }

            return totalSize;
        }
        public void printFileInfo(string filename)
        {
            FileInfo fi = new FileInfo(filename);
            Console.WriteLine("File Information For [" + fi.FullName + "]");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Length: " + fi.Length + " bytes");
            Console.WriteLine("Size On Disk: " + GetFileSizeOnDisk(filename) + " bytes");
            Console.WriteLine("Read Only: " + fi.IsReadOnly);
            Console.WriteLine("Creation Time: " + fi.CreationTime);
            Console.WriteLine("-----------------------------------------");
        }

        public long GetFileSizeOnDisk(string file)
        {
            FileInfo info = new FileInfo(file);
            uint dummy, sectorsPerCluster, bytesPerSector;
            int result = GetDiskFreeSpaceW(info.Directory.Root.FullName, out sectorsPerCluster, out bytesPerSector, out dummy, out dummy);
            if (result == 0) throw new Win32Exception();

            uint clusterSize = sectorsPerCluster * bytesPerSector;
            uint hosize;
            uint losize = GetCompressedFileSizeW(file, out hosize);
            long size = (long)hosize << 32 | losize;
            return ((size + clusterSize - 1) / clusterSize) * clusterSize;
        }


        [DllImport("kernel32.dll")]
        static extern uint GetCompressedFileSizeW([System.Runtime.InteropServices.In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
       [Out, MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

       [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        static extern int GetDiskFreeSpaceW([In, MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName,
           out uint lpSectorsPerCluster, out uint lpBytesPerSector, out uint lpNumberOfFreeClusters,
           out uint lpTotalNumberOfClusters);
    }
}
