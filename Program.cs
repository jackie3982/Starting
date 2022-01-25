using System;


namespace PA1
{
    abstract class Animal
{

    private string name; // { get; set; }
    private int age; // { get; set; }
    private string noise; // { get; set; }
    private double weight; //{ get; set; }
    public Animal()
    {
        name = "name";
        age = 0;
        noise = "noise";
        weight = 0;
    }
    public Animal(string name, int age, string noise, double weight)
    {
        this.name = name;
        this.age = age;
        this.noise = noise;
        this.weight = weight;
    }

    public void printInfo()
    {
        Console.WriteLine(name + "\n" + age + "\n" + noise + "\n" + weight);
    }
    public void makeNoise()
    {
        Console.WriteLine(noise);
    }
    public void ageUp()
    {
        age++;
    }
}

class Cat : Animal
{
    private string colour;
    public Cat()
    {
        colour = "colour";
    }

    public Cat(string name, int age, string noise, double weight, string colour)
    {



    }
}
public class World
{
    static void main(string[] args)
    {

    }
}
}