namespace BankAuthApi.Models;

public class User
{
    public int Id { get; private set; }
    public string FullName { get; private set; }
    public string NIC { get; private set; }
    public string Username { get; private set; }
    public string PasswordHash { get; private set; }

    private User() { }


    public User(string fullname, string nic, string username, string passwordHash)
    {
        FullName = fullname;
        NIC = nic;
        Username = username;
        PasswordHash = passwordHash;
    }

}