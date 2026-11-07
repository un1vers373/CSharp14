using System;
class Program
{
    static void Main()
    {
        string name = GetName();
        Console.WriteLine(name);

        int age = GetAge(20);
        Console.WriteLine(age);

        double height = GetHeight();
        Console.WriteLine(height);

        bool adult = IsAdult(age);
        Console.WriteLine(adult);     
}
    static string GetName()
    {
        return "Yan";
    }
    static int GetAge(int age)
    {
        return age;
    }
    static double GetHeight()
    {
        return 1.81;
    }
    static bool IsAdult(int age)
    {
        return age >= 18;
    }
}
