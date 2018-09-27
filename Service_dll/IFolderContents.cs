using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service_dll
{
    [ServiceContract]
    public interface IFolderContents
    {
        [OperationContract]
        List<string>GetFolderContents(string path);
    }

}
