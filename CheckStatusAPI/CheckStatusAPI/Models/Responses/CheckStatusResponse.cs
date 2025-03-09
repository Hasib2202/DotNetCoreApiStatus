namespace CheckStatusAPI.Models.Responses
{
    public class CheckStatusResponse
    {
        // "status" can be string/int/bool as per your requirement.
        public string Status { get; set; } = "0";

        // "message" is a descriptive text.
        public string Message { get; set; } = string.Empty;
    }
}
