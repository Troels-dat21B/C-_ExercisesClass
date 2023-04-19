using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class GoTCharacter : IWesterosi, IHumanoide
{
    private int age;
    private string? name;
    private string? house;
    private string? location;

    public void Age(int age)
    {
        this.age = age;
    }

    public void House(string house)
    {
        this.house = house;
    }

    public void Location(string location)
    {
        this.location = location;
    }

    public void Name(string name)
    {
        this.name = name;
    }

    void IHumanoide.talk(string message)
    {
        Console.WriteLine(message);
    }

    
    public override string ToString(){
        return "Name: " + name + "\nAge: " + age + "\nHouse: " + house + "\nLocation: " + location;
    }
}