namespace Task2;

public abstract class Application
{
    protected string name;
    protected List<User> listUsers;
    protected int maxim;

    public Application(string name, List<User> listUsers, int maxim)
    {
        this.name = name;
        this.listUsers = new List<User>(listUsers);
        this.maxim = maxim;
    }

    public string GetName()
    {
        return name;
    }

    public int GetNumberOfUsers()
    {
        return listUsers.Count;
    }

    public override string ToString()
    {
        return name + ' ' + listUsers.Count;
    }

    public void AddUser(User user)
    {
        if (listUsers.Contains(user))
            Console.WriteLine("This user already exists!");
        else if (listUsers.Count < maxim)
            listUsers.Add(user);
        else
            Console.WriteLine("No more space for other users!");
    }

    public void RemoveUser(User user)
    {
        if (listUsers.Contains(user))
            listUsers.Remove(user);
        else
            Console.WriteLine("DATA ERROR");
    }
}