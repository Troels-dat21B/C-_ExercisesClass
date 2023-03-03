using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
public class Person
{
    [Required, MinLength(1), MaxLength(100)]
    string Name { get; set; } = string.Empty;

    [Required, Range(0, 120)]
    int Age { get; set; }

    [EmailAddress]
    string Email { get; set; } = string.Empty;


    public Person(string name, int age, [Optional] string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public bool Validate()
    {
        var context = new ValidationContext(this, null, null);
        var results = new List<ValidationResult>();
        return Validator.TryValidateObject(this, context, results, true);
    }

}

class main
{
    static void Main(string[] args)
    {
        var person1 = new Person("John", 30, "john@example.com");

        person1.Validate(); // no exception



        var person2 = new Person(null, 150);

        try

        {

            person2.Validate();

        }

        catch (ArgumentException ex)

        {

            Console.WriteLine(ex.Message); // "Name must be between 1 and 100 characters."

        }



        var person3 = new Person("Jane", -10, "jane@example.com");

        try

        {

            person3.Validate();

        }

        catch (ArgumentException ex)

        {

            Console.WriteLine(ex.Message); // "Age must be between 0 and 120."

        }



        var person4 = new Person("Bob", 40, "invalid-email");

        try

        {

            person4.Validate();

        }

        catch (ArgumentException ex)

        {

            Console.WriteLine(ex.Message); // "Email must be a valid email address format."

        }
    }
}