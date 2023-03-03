using System;
using System.ComponentModel.DataAnnotations;

struct Date{
    [Range(1, 31)]
    public int day;
    [Range(1, 12)]
    public int month;

    public int year;

    public bool isValid(){
        if (day < 1 || day > 31) return false;
        if (month < 1 || month > 12) return false;
        if (year < 1) return false;
        return true;
    }


    public string toString(){
        return $"{year}-{month}-{day}";
    }
}

class main{
    static void Main(){
        Date date = new Date();
        date.day = 1;
        date.month = 1;
        date.year = 2020;
        Console.WriteLine(date.isValid());
        Console.WriteLine(date.toString());
    }
}
