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
    public class ProvinceController : ApiController
    {
        private readonly IProvinceRepository _repository;
        public ProvinceController(ProvinceRepository repository) { _repository = repository; }

    }
}
