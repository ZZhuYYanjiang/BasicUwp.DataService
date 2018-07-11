using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicUwp.DataService.Models
{
    /// <summary>
    /// 数据库上下文类
    /// </summary>
    public class DataContext:DbContext
    {
        ///<summary>
        ///联系人表
        ///</summary>
        public DbSet<Contact> Contacts { get; set; }

        /// <summary>
        /// 数据上下文类构造函数。
        /// </summary>
        /// <param name="options">数据上下文参数。</param>
        public DataContext(DbContextOptions<DataContext> options) : base(
            options)
        { }
    }
}
