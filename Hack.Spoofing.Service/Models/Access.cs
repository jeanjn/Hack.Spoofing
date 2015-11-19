namespace Hack.Spoofing.Service.Models
{
    public class Access
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
        public string Origin { get; set; }
    }
}
