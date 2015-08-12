﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    /// <summary>
    /// 表示继承于该接口的类型是实体类
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// 实体类的全局唯一标识
        /// </summary>
        string Id { get; }
    }
}
