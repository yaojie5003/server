using AdministrationServer.Interface;
using AdministrationServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    public class CountyController : ApiController
    {
        private readonly ICountyRepository _county;
        public CountyController(ICountyRepository county) { _county = county; }
    }
}
