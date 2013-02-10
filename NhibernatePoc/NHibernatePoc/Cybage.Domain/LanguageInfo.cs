using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cybage.Domain
{
    public class LanguageInfo
    {
        public int Id { get; private set; }

        public string ShortPath { get; set; }

        public string LongPath { get; set; }

        private Language _language = new Language();

        public Language Language
        {
            get { return _language; }         
        }

        public void AddLanguage(Language language)
        {
            _language = language;
        }
    }
}
