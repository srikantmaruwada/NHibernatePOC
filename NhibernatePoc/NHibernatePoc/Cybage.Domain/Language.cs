using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cybage.Domain
{
    public class Language
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        private IList<Flag> _flags = new List<Flag>();

        public IEnumerable<Flag> Flags
        {
            get
            {
                return _flags.ToList().AsEnumerable();
            }
        }

        public void AddFlag(Flag flag)
        {
            _flags.Add(flag);
        }

        //private IList<LanguageInfo> _languageInfos = new List<LanguageInfo>();

        //public IEnumerable<LanguageInfo> LanguageInfos
        //{
        //    get
        //    {
        //        return _languageInfos.ToList().AsEnumerable();
        //    }
        //}
        //public void AddLanguageIcon(LanguageInfo languageInfo)
        //{
        //    _languageInfos.Add(languageInfo);            
        //}

        public override bool Equals(object obj)
        {
            Language toCompare = obj as Language;
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
