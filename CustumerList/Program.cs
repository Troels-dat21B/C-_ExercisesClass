// See https://aka.ms/new-console-template for more information
class main
{
    static void Main(string[] args)
    {
        //Creating 10 new Person objects
        Person person = new Person("John", 25, "John@example.something");
        Person person2 = new Person("Jane", 30, "Jane@example.something");
        Person person3 = new Person("Jack", 35, "Jack@example.something");
        Person person4 = new Person("Jill", 40, "Jill@example.something");
        Person person5 = new Person("Jenny", 45, "Jenny@example.something");
        Person person6 = new Person("Jen", 50, "Jen@example.something");
        Person person7 = new Person("Jenifer", 55, "Jenifer@example.something");
        Person person8 = new Person("Jeniffer", 60, "Jeniffer@example.something");
        Person person9 = new Person("Martha", 65, "Martha@example.something");
        Person person10 = new Person("Laura", 70, "Laura@example.something");

        //Creating a list of Person objects
        List<Person> people = new List<Person>();
        people.Add(person);
        people.Add(person2);
        people.Add(person3);
        people.Add(person4);
        people.Add(person5);
        people.Add(person6);
        people.Add(person7);
        people.Add(person8);
        people.Add(person9);
        people.Add(person10);

        string ageIsUnder30;
        string ageIsBetween30And40;
        string ageIsOver40;
        int age;
        for (int i = 0; i < people.Count; i++)
        {  

            // switch(age = people[i].Age){
            //     case age < 30:
            //         ageIsUnder30 = "Personen er under 30 år";
            //         break;
            //     case age > 30 && age < 40:
            //         ageIsBetween30And40 = "Personen er mellem 30 og 40 år";
            //         break;
            //     case age > 40:
            //         ageIsOver40 = "Personen er over 40 år";
            //         break;
            // }
            Console.WriteLine($"Personenes navn er: {people[i].Name}. Personens alder er: {people[i].Age}. Personens email er: {people[i].Email}");
        }


    }
}



