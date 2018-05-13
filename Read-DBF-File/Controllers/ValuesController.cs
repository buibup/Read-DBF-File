using NDbfReader;
using Read_DBF_File.DataAccess;
using Read_DBF_File.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Read_DBF_File.Controllers
{
    public class ValuesController : ApiController
    {
        readonly IDbfDataConnection dbfDataConnection;
        readonly string dbfFile = GlobalConfig.AppConfig("dbfFile");

        public ValuesController()
        {
            dbfDataConnection = new DbfConnector();
        }

        // GET api/values
        public IHttpActionResult Get()
        {
            string path = HttpContext.Current.Server.MapPath($"~/App_Data/{dbfFile}");
            var results = dbfDataConnection.GetDbfDatas(path);

            return Ok(results);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
