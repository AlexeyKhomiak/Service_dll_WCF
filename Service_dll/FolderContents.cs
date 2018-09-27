using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service_dll
{
    public class FolderContents : IFolderContents
    {
        public List<string> GetFolderContents(string path)
        {
            List<string> contents = new List<string>();
            foreach (var item in Directory.GetDirectories(path))
            {
                contents.Add(item);
            }
            return contents;
        }
    }
}
