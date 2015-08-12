using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    /// <summary>
    /// 继承于此接口的类型为聚合根
    /// </summary>
    public interface IAggregateRoot : IEntity
    {
    }
}
