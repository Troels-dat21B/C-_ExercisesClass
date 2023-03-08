using System;
using System.ComponentModel.DataAnnotations;
class Person
{   
    
    public string name { get; set; } =string.Empty;

    public int age { get; set; }

    public string occupation { get; set; } = string.Empty;
    public decimal salary { get; set; }



    public (string, int, string, decimal) getPersonInfo()
    {
        return (name, age, occupation, salary);
    }


}

class main
{
    static void Main(string[] args)
    {
        var person = new Person

        {

            name = "John",

            age = 30,

            occupation = "Software Engineer",

            salary = 75000.00m

        };
        var (name, age, occupation, salary) = person.getPersonInfo();
        Console.WriteLine($"{name} is {age} years old and works as a {occupation}, earning {salary:C} per year.");
    }
}
