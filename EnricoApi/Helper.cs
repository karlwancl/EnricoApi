using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Runtime.Serialization;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Flurl.Http;

namespace EnricoApi
{
    public static class Helper
    {
        public static string Name(this Enum @enum)
        {
            string name = @enum.ToString();
            if (typeof(Country).GetMember(name).First().GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute attr && attr.IsValueSetExplicitly)
                name = attr.Value;
            return name;
        }

        public static async Task<T> ReceiveJsonOrThrowExceptionIfError<T>(this Task<HttpResponseMessage> responseTask)
        {
            var json = await responseTask.ReceiveString().ConfigureAwait(false);
            if (json.Contains("\"error\""))
                throw new EnricoException(JObject.Parse(json).Value<string>("error"));
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
