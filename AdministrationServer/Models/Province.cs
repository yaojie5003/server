﻿using AdministrationServer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationServer.Models
{
    public class Province: IEntity
    {
        public int Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Abbreviation { set; get; }
    }
}