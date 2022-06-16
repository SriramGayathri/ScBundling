using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Feature.PageContent.Model
{
    public class FeedbackForm
    {
        
        [JsonProperty(PropertyName = "name")]
        [Required]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        [Required]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "type")]
        [Required]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "description")]
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }       

        [Required]
        [RegularExpression(@"^([0-9]{10})$",ErrorMessage ="Please enter valid Mobile number")]
        public string  MobileNumber { get; set; }

        public bool IsAgree { get; set; }
    }

    
}