using Flurl;
using Flurl.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnricoApi
{
    public static class Enrico
    {
        private const string EnricoUrl = "http://www.kayaposoft.com/enrico/json/v1.0/";

        private const string ActionTag = "action";
        private const string MonthTag = "month";
        private const string YearTag = "year";
        private const string CountryTag = "country";
        private const string RegionTag = "region";
        private const string FromDateTag = "fromDate";
        private const string ToDateTag = "toDate";
        private const string DateTag = "date";
        private const string DateFormat = "dd-MM-yyyy";

        public static async Task<IList<Holiday>> GetPublicHolidaysForMonthAsync(int year, int month, Country country, Region? region = null, CancellationToken token = default(CancellationToken))
        {
            string action = "getPublicHolidaysForMonth";
            return await EnricoUrl
                .SetQueryParam(ActionTag, action)
                .SetQueryParam(YearTag, year)
                .SetQueryParam(MonthTag, month)
                .SetQueryParam(CountryTag, country.Name())
                .SetQueryParam(RegionTag, region?.Name())
                .GetAsync(token)
                .ReceiveJsonOrThrowExceptionIfError<IList<Holiday>>()
                .ConfigureAwait(false);
        }

        public static async Task<IList<Holiday>> GetPublicHolidaysForYearAsync(int year, Country country, Region? region = null, CancellationToken token = default(CancellationToken))
        {
            string action = "getPublicHolidaysForYear";
            return await EnricoUrl
                .SetQueryParam(ActionTag, action)
                .SetQueryParam(YearTag, year)
                .SetQueryParam(CountryTag, country.Name())
                .SetQueryParam(RegionTag, region?.Name())
                .GetAsync(token)
                .ReceiveJsonOrThrowExceptionIfError<IList<Holiday>>()
                .ConfigureAwait(false);
        }

        public static async Task<IList<Holiday>> GetPublicHolidaysForDateRangeAsync(DateTime? fromDate, DateTime? toDate, Country country, Region? region = null, CancellationToken token = default(CancellationToken))
        {
            string action = "getPublicHolidaysForDateRange";
            return await EnricoUrl
                .SetQueryParam(ActionTag, action)
                .SetQueryParam(FromDateTag, fromDate?.ToString(DateFormat))
                .SetQueryParam(ToDateTag, toDate?.ToString(DateFormat))
                .SetQueryParam(CountryTag, country.Name())
                .SetQueryParam(RegionTag, region?.Name())
                .GetAsync(token)
                .ReceiveJsonOrThrowExceptionIfError<IList<Holiday>>()
                .ConfigureAwait(false);
        }

        public static async Task<bool> IsPublicHolidayAsync(DateTime? date, Country country, Region? region = null, CancellationToken token = default(CancellationToken))
        {
            string action = "isPublicHoliday";
            var isPublicHolidayResponse = await EnricoUrl
                .SetQueryParam(ActionTag, action)
                .SetQueryParam(DateTag, date?.ToString(DateFormat))
                .SetQueryParam(CountryTag, country.Name())
                .SetQueryParam(RegionTag, region?.Name())
                .GetAsync(token)
                .ReceiveJson()
                .ConfigureAwait(false);
            return Convert.ToBoolean(isPublicHolidayResponse.isPublicHoliday);
        }
    }
}
