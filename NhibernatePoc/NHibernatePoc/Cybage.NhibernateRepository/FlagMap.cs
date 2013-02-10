using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cybage.Domain;

namespace Cybage.NhibernateRepository
{
    public class FlagMap : ClassMap<Flag>
    {
        public FlagMap()
        {
            Table("Flag");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);            
            HasManyToMany<LanguageInfoNew>(x => x.Languages)
                .Access.CamelCaseField(Prefix.Underscore)                
                .Cascade.All()
                .Not.LazyLoad()
                .Component(c => {
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
                        c.References<Language>(r =>r.Language, "LangId").Not.LazyLoad();
                        })
                .Table("LanguageInfoNew")
                .FetchType.Join()
                .ChildKeyColumns.Add("LangId", mapping => mapping.Name("LangId")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable())
                .ParentKeyColumns.Add("FlagId", mapping => mapping.Name("FlagId")
                                                                     .SqlType("INTEGER"));
        }
    }
}
