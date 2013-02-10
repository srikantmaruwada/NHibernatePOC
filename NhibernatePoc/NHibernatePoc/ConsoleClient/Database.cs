using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Configuration;
using Cybage.Domain;

namespace Cybage.NhibernateRepository
{
    public class Database
    {         
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(ConfigurationManager.AppSettings["ConnectionString"]))
                .Mappings(m =>
                    m.FluentMappings
                    .AddFromAssemblyOf<Flag>()
                    )
                .BuildSessionFactory();
        }
    }
}
