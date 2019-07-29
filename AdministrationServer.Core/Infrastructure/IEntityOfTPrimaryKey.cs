using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationServer.Core.Infrastructure
{
    /// <summary>
    /// 有主键的实体
    /// </summary>
    /// <typeparam name="TPrimaryKey">主键</typeparam>
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        TPrimaryKey Id { get; set; }
    }
}