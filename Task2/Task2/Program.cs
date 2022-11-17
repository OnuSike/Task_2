using Task2;

User user1 = new User("OnuSike", "ParolaMea", "nu_am_email@email.com");
User user2 = new User("xPaul74", "123456", "distrugatorulDEvise@arad.china");
User user3 = new User("Robert", "Roby11", "roberteugen@gmail.com");
List<User> listUsers = new List<User>{user1, user2};
WebApplication webApplication = new WebApplication("Facebook", listUsers, 5);
MobileApplication mobileApplication = new MobileApplication("Pokemon Go!", listUsers, 5);



// VERIFICARE User
// listUsers[1].ChangePassword("Pancakes1");
// Console.WriteLine(listUsers[0].GetMail());
// Console.WriteLine(listUsers[0]);
// Console.WriteLine(listUsers[1]);



// VERIFICARE WebApplication
// webApplication.HttpRequest(user1);
// webApplication.HttpRequest(user2);
// webApplication.RemoveUser(user1);
// webApplication.HttpRequest(user1);
// webApplication.RemoveUser(user1);



// VERIFICARE MobileApplication
// Console.WriteLine(mobileApplication.RateApp());
// Console.WriteLine(mobileApplication.RateApp());
// Console.WriteLine(mobileApplication.RateApp());



// VERIFICARE Application
// Console.WriteLine(webApplication.GetName());
// Console.WriteLine(webApplication.GetNumberOfUsers());
// Console.WriteLine(webApplication.ToString());
// webApplication.AddUser(user3);
// webApplication.RemoveUser(user2);



// VERIFICARE ADMIN
// string name = Console.ReadLine();
// List<Application> listApplications = new List<Application>{webApplication, mobileApplication};
// Admin admin = new Admin(name, listApplications);
// admin.AddUser(user3, webApplication);
// webApplication.HttpRequest(user3);
