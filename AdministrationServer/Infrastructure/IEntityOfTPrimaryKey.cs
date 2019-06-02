using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationServer.Infrastructure
{
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        TPrimaryKey Id { get; set; }
    }
}