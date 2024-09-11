namespace BaseLibrary.DTOs
{
    public class Register : AccountBase
    {
        public string? FullName { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
