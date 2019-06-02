using AdministrationServer.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    public class ProvinceController : ApiController
    {
        public async Task< IHttpActionResult> Get()
        {
            using (ServerDbContext _context = new ServerDbContext())
            {               
                var ssd = _context.Province.ToList();
                return Json(ssd);
            }
        }
    }
}
