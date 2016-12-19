using System;
using System.Collections.Generic;
using System.Text;

namespace EnricoApi
{
    public class Holiday
    {
        private Date _date;

        public Holiday(Date date, string localName, string englishName)
        {
            _date = date;
            LocalName = localName;
            EnglishName = englishName;
        }

        public DateTime DateTime => new DateTime(_date.Year, _date.Month, _date.Day);

        public string LocalName { get; private set; }

        public string EnglishName { get; private set; }
    }
}
