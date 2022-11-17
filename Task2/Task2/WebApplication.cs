namespace Task2;

public class WebApplication : Application
{
    public WebApplication(string name, List<User> listUsers, int maxim) : base(name, listUsers, maxim) {}

    public void HttpRequest(User user)
    {
        if (listUsers.Contains(user))
            Console.WriteLine("Ok Request");
        else
            Console.WriteLine("Bad Request");
    }
}