namespace Task2;

public class Admin
{
    private string name;
    private List<Application> _listApplications;

    public Admin(string name, List<Application> listApplications)
    {
        this.name = name;
        this._listApplications = new List<Application>(listApplications);
    }
    
    public void AddUser(User user, Application application)
    {
        application.AddUser(user);
    }

    public void RemoveUser(User user, Application application)
    {
        application.RemoveUser(user);
    }
}