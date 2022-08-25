namespace FrondEnd.MangoApp.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; }
        public Object Result { get; set; }
        public String DispalayMessage { get; set; } = "";
        public List<string> ErrorMessage { get; set; }
    }
}
