namespace ConsumeJWTTokenFromWebAPI.Models
{
    public class UserBE
    {
        public string UserID { get; set; }
        public string Password { get; set; }
    }
    public class ApiResponse
    {
        public string Token { get; set; }
        public UserResponse User { get; set; }
    }
    public class UserResponse
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
