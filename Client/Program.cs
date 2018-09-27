using Service_dll;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FolderContents client = new FolderContents();
                Console.WriteLine($"Enter directory\n(example: C:\\Windows ):\n\tor enter exit:");
                string path = Console.ReadLine();
                while (path != "exit")
                {
                    var res = client.GetFolderContents(path);
                    foreach (var item in res)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine($"\nEnter directory\n(example: C:\\Windows ):\n\tor enter exit:");
                    path = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
