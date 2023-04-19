using System;

class Program
{
    static void Main(string[] args)
    {
        GoTCharacter character = new GoTCharacter();
        character.Name("Jon Snow");
        character.Age(25);
        character.House("Stark");
        character.Location("The Wall");
        ((IHumanoide)character).talk("I know nothing");
        Console.WriteLine(character.ToString());



    }

}


