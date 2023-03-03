class Person
{
    public string Name { get; set; }

    //Age needs to be between 10 and 90
    public int Age { get; set; }
    public string Email { get; set; }

    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
        public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

}