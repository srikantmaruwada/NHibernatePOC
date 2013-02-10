using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cybage.Domain
{
    public class LanguageInfoNew
    { 
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

        private Flag _flag= new Flag();

        public Flag Flag
        {
            get { return _flag; }
        }

        public void AddFlag(Flag flag)
        {
            _flag= flag;
        }

        public override bool Equals(object obj)
        {
            LanguageInfoNew toCompare = obj as LanguageInfoNew;
            if (toCompare == null)
            {
                return false;
            }

            //if (!Object.Equals(this.LongPath, toCompare.LongPath))
            //    return false;

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 13;
            return hashCode;
        }

    }
}
