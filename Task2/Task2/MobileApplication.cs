namespace Task2;

public class MobileApplication : Application
{
    private double rating;
    private int numberOfValues;

    public MobileApplication(string name, List<User> listUsers, int maxim) : base(name, listUsers, maxim) {}

    public double RateApp()
    {
        double newRating = Convert.ToDouble(Console.ReadLine());
        rating = (rating * numberOfValues + newRating) / (numberOfValues + 1);
        numberOfValues++;
        return rating;
    }
}