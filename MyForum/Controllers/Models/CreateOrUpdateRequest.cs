using Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MyForum.Controllers.Models
{
    public class CreateOrUpdateRequest
    {
        [JsonProperty("id")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
