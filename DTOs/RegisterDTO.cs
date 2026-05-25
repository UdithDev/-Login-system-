

namespace BankAuthApi.DTOs;

public class RegisterDTO

{
    public string FullName { get; set; }

    public string NIC { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string ConfirmPassword {get ; set;}
}