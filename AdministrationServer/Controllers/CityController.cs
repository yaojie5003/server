using AdministrationServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    public class CityController : ApiController
    {
        private readonly CityRepository _city;
        public CityController(CityRepository city) { _city = city; }
    }
}
