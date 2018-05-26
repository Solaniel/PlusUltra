﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusUltra.DataAccess
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public class MyConfig : DbConfiguration
    {
        public MyConfig()
        {
            SetDefaultConnectionFactory(
                new LocalDbConnectionFactory("MSSQLLocalDB")
            );
        }
    }
}
