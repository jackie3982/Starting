using System;


namespace PA1
{
    abstract class Animal
{

    private string name { get; set; }
    private int age { get; set; }
    private string noise { get; set; }
    private double weight { get; set; }
    /*public Animal()
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
    }*/

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
        public string name
        {
            get { return name; }
            set { name = value; }
        }

        public int age
        {
            get { return age; }
            set { age = value; }
        }

        public string noise
        {
            get { return noise; }
            set { noise = value; }
        }

        public double weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string colour;

        public void printInfo()
        {

            printInfo();
            Console.WriteLine(/*name + "\n" + age + "\n" + noise + "\n" + weight + "\n" + */colour);

        }

        public void makeNoise()
        { makeNoise(); }

        public void ageUp()
        { age++; }
    }

        /*public Cat()
         {
             colour = "colour";
         }

         public Cat(string name, int age, string noise, double weight, string colour)
         {



         }*/
    }
    public class World
{
    static void main(string[] args)
    {
        //List ts = new Animal();
    }
}
}