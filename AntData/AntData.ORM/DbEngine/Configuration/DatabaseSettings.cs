﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntData.ORM.Enums;

namespace AntData.ORM.DbEngine.Configuration
{
    /// <summary>
    /// 自定义的db配置
    /// </summary>
    public class DatabaseSettings
    {
        /// <summary>
        /// 连接字符串配置
        /// </summary>
        public List<ConnectionStringItem> ConnectionItemList { get; set; }

        /// <summary>
        /// 同一个DataBaseSet下的配置的db对应的Provider只有一个
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// DataBaseSet名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分片的类
        /// </summary>
        public string ShardingStrategy { get; set; }
    }

    /// <summary>
    /// 连接字符串
    /// </summary>
    public class ConnectionStringItem
    {
        public ConnectionStringItem()
        {
            DatabaseType = DatabaseType.Master;
        }
        /// <summary>
        /// db连接字符串
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// 逻辑名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 对应的db类型(主or从)
        /// </summary>

        public DatabaseType DatabaseType { get; set; }

        /// <summary>
        /// 分片值
        /// </summary>
        public string Sharding { get; set; }

        /// <summary>
        /// 分片权重
        /// </summary>
        public int Ratio { get; set; }
    }
}
