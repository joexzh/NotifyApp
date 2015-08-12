namespace NotifyWebApi.Models
{
    public class UserProfileModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Email { get; set; }

        public string QQ { get; set; }

        public string MobilePhone { get; set; }
    }
}