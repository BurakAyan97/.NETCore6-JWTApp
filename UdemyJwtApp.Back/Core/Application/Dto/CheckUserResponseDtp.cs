namespace UdemyJwtApp.Back.Core.Application.Dto
{
    public class CheckUserResponseDtp
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Role { get; set; }
        public bool IsExist { get; set; }
    }
}
