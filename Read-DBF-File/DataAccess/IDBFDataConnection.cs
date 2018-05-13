using Read_DBF_File.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Read_DBF_File.DataAccess
{
    public interface IDbfDataConnection
    {
        IEnumerable<Model> GetDbfDatas(string path);
    }
}