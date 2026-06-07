using BuilderPattern;

class Program
{
    static void Main()
    {
        User user = new UserBuilder()
                    .SetFirstName("Aman")
                    .SetLastName("Agrawal")
                    .SetEmail("aman007agg@gmail.com")
                    .SetCountry("India")
                    .Build();
        Console.WriteLine(
        $"First Name: {user.FirstName}, " +
        $"Last Name: {user.LastName}, " +
        $"Email: {user.Email}, " +
        $"Country: {user.Country}"
        );
    }
}