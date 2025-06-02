namespace GSLW.Core.Models.Dtos
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; } // Avalie usar um hash no envio real
    }
}
