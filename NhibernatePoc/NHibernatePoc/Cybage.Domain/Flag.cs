using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cybage.Domain
{
    public class Flag
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //private IList<Language> _languages = new List<Language>();

        //public IEnumerable<Language> Languages
        //{
        //    get
        //    {
        //        return _languages.ToList().AsEnumerable();
        //    }
        //}

        //public void AddLanguage(Language language)
        //{
        //    _languages.Add(language);                        
        //}


        private IList<LanguageInfoNew> _languages = new List<LanguageInfoNew>();

        public IEnumerable<LanguageInfoNew> Languages
        {
            get
            {
                return _languages.ToList().AsEnumerable();
            }
        }

        public void AddLanguage(LanguageInfoNew language)
        {
            _languages.Add(language);
        }

        public override bool Equals(object obj)
        {
            Flag toCompare = obj as Flag;
            if (toCompare == null)
            {
                return false;
            }

            if (!Object.Equals(this.Id, toCompare.Id))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 13;
            hashCode = (hashCode * 7) + Id.GetHashCode();
            return hashCode;
        }

    }
}
