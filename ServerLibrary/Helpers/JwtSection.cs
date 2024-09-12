namespace ServerLibrary.Helpers
{
    public class JwtSection
    {
        public const string SECTION_NAME = "JwtSection";
        public string? Key { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
        public int ExpireInMinutes { get; set; }
    }
}
