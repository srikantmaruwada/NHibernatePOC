using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cybage.Domain;

namespace Cybage.NhibernateRepository
{
    public class LangMap:ClassMap<Language>
    {
        public LangMap()
        {
            Table("Language");
            Id(x => x.Id);
            Map(x => x.Name);            
            HasManyToMany<LanguageInfoNew>(x => x.Flags)
                .Access.CamelCaseField(Prefix.Underscore)                                
                .Not.LazyLoad()
                .Inverse()                
                .Component(c =>
                {
                    c.Map(x => x.LongPath)
                        .Column("LongPath")
                        .CustomType("String")                        
                        .CustomSqlType("VARCHAR")
                        .Length(50);
                    c.Map(x => x.ShortPath)
                        .Column("ShortPath")
                        .CustomType("String")                        
                        .CustomSqlType("VARCHAR")
                        .Length(50);
                    c.References<Flag>(r => r.Flag, "FlagId").Not.LazyLoad();
                })
                .Table("LanguageInfoNew")
                .FetchType.Join()
                .ChildKeyColumns.Add("FlagId", mapping => mapping.Name("FlagId")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable())
                .ParentKeyColumns.Add("LangId", mapping => mapping.Name("LangId")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable());

        }
    }
}
