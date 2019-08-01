using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataApi.Models;

namespace DataApi.Controllers
{
    public class ValuesController : ApiController
    {

        //http://localhost:51886/api/values
        //{
        //"Value" : "test title"
        //}
        // POST api/values
        public IHttpActionResult Post(CommandCenterModel cmdModel)
        {
            try
            {
                var FileData = FileStreamers.GetDatFileData(cmdModel);
                FileStreamers.CreateDatFile(FileData);

                return Ok(FileData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}
