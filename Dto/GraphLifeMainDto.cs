using Newtonsoft.Json;

namespace AppAmalt.Dto
{
    [JsonObject]
    public class GraphLifeMainDto
    {
        [JsonProperty("family")]
        public int Family { get; set; }

        [JsonProperty("career_money")]
        public int CareerMoney { get; set; }
        [JsonProperty("fame_power")]
        public int FamePower { get; set; }
        [JsonProperty("entertainment")]
        public int Entertainment { get; set; }
        [JsonProperty("science")]
        public int Science { get; set; }
        [JsonProperty("Self_development")]
        public int SelfDevelopment { get; set; }
    }
}
