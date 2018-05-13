using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using NDbfReader;
using Read_DBF_File.Models;

namespace Read_DBF_File.DataAccess
{
    public class DbfConnector : IDbfDataConnection
    {
        
        public IEnumerable<Model> GetDbfDatas(string path)
        {
            var results = new List<Model>();
            using (var table = Table.Open(path))
            {
                var reader = table.OpenReader(Encoding.GetEncoding("TIS-620"));
                while (reader.Read())
                {
                    decimal? cuserid = 0;
                    if (reader.GetValue("CUSERID") != null)
                    {
                        cuserid = reader.GetDecimal("CUSERID");
                    }

                    var model = new Model()
                    {
                        CuserId = cuserid,
                        EmpId = reader.GetString("EMPID"),
                        EmpName = reader.GetString("EMPNAME"),
                        ChkTime = reader.GetDateTime("CHKTIME")
                    };

                    results.Add(model);
                }
            }
            return results;
        }
    }
}