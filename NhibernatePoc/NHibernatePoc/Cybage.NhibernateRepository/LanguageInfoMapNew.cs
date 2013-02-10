using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cybage.Domain;

namespace Cybage.NhibernateRepository
{
    public class LanguageInfoMapNew:ClassMap<LanguageInfoNew>
    {
        public LanguageInfoMapNew()
        {           
            CompositeId()
                .KeyReference(x => x.Language, "LangId")
                .KeyReference(x => x.Flag, "FlagId");
            Table("LanguageInfoNew");            
            Map(x => x.LongPath);
            Map(x => x.ShortPath);
            //References(x => x.Language)
            //    .Class<Language>()
            //    //.Access.Property()
            //    //.Cascade.None()
            //    .Not.LazyLoad()
            //    .Columns("LangId");
            //References<Language>(x => x.Language)
            //    .Access.CamelCaseField(Prefix.Underscore)
            //    .Cascade.All();
            //HasOne<Language>(x => x.Language).Cascade.All();
        }
    }
}
