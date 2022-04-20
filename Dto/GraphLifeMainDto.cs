using Newtonsoft.Json;

namespace AppAmalt.Dto
{
    [JsonObject]
    public class GraphLifeMainDto
    {
        [JsonProperty("family")]
        public double Family { get; set; }

        [JsonProperty("career_money")]
        public double CareerMoney { get; set; }
        [JsonProperty("fame_power")]
        public double FamePower { get; set; }
        [JsonProperty("entertainment")]
        public double Entertainment { get; set; }
        [JsonProperty("science")]
        public double Science { get; set; }
        [JsonProperty("Self_development")]
        public double SelfDevelopment { get; set; }
    }
}
