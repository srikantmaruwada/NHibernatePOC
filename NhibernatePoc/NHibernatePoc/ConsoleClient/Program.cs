using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cybage.NhibernateRepository;
using Cybage.Domain;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var flagRepostory= new NHibernateRepository<Flag>();
            var langRepository = new NHibernateRepository<Language>();
            var langInfoRepository= new NHibernateRepository<LanguageInfo>();


            //var langInfo = langInfoRepository.GetAll();
            var flags = flagRepostory.GetAll();

            //var lang = langRepository.Get(2);
            //LanguageInfo langInfo = new LanguageInfo();
            //langInfo.LongPath = "test";
            //langInfo.ShortPath = "test1";
            //langInfo.AddLanguage(lang);
            //lang.AddLanguageIcon(langInfo);
            //langRepository.Save(lang);
            //langInfoRepository.Save(langInfo);


            Flag flag = new Flag();
            flag.Name = " Fucking programe";
            flag.Description = " Flag Descrption2";
            var lang = langRepository.Get(2);
            var languageInfo = new LanguageInfoNew { LongPath = "@C:Test1", ShortPath = "@d:tet2" };
            languageInfo.AddLanguage(lang);
            //lang.AddLanguageIcon(new LanguageInfo { LongPath = "Test1", ShortPath = "test1" });
            flag.AddLanguage(languageInfo);
            flagRepostory.Save(flag);

        }
    }
}
