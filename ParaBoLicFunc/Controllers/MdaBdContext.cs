using ParaBoLicFunc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParaBoLicFunc.Controllers
{
    public class MdaBdContext:DbContext
    {
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<Point> Points { get; set; }
    }
}