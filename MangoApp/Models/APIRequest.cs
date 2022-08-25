using static MangoApp.SD;

namespace MangoApp.Models
{
    public class APIRequest
    {
        public APIType APIType { get; set; } = APIType.GET;
        public string? Image { get; set; }
        public string? URL { get; set; }
        public Object? Data { get; set; }
        public string? AccessToken { get; set; }
    }
}
 