namespace Models.Users;

public class Users
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Users(int id, string name, int age, string city)
    {
        Id = id;
        Name = name;
        Age = age;
        City = city;
    }
}
