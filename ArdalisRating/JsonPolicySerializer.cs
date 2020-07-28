using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{
    public class JsonPolicySerializer
    {
        public Policy GetPolicyFromJsonString(string policy)
        {
            return JsonConvert.DeserializeObject<Policy>(policy,
                new StringEnumConverter());
        }
    }
}
