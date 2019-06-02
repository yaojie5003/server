using AdministrationServer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationServer.Models
{
    public class County:IEntity
    {
        public int ProvinceId { set; get; }
        public int CityId { set; get; }
        public int Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Abbreviation { set; get; }
    }
}