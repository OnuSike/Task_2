namespace Task2;

public class User
{
    private string username;
    private string password;
    private string email;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }
    
    public string GetMail()
    {
        return email;
    }

    public void ChangePassword(string newPassword)
    {
        password = newPassword;
    }

    public override string ToString()
    {
        return username + ' ' + email;
    }
}