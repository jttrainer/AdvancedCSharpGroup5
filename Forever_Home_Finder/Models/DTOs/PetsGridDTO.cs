using Newtonsoft.Json;

namespace Forever_Home_Finder.Models
{
    public class PetsGridDTO : GridDTO
    {
        [JsonIgnore]
        public const string DefaultFilter = "all";

        public string PetType { get; set; } = DefaultFilter;
    }
}
