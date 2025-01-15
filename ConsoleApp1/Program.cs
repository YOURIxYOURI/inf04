
//var animal = new Animal(); nie poprawne utworzenie obiektu

var dog = new Dog();
dog.methodOne();


public abstract class Animal
{
    public int age { get; set; }
    public abstract string name { get; set; }

    public Animal() { }
    public Animal(int age)
    {
        this.age = age;
    }

    public abstract void methodOne();
}

public class Dog : Animal
{
    public override string name { get; set; }
    public string something { get; set; }
    public Dog() { }
    public Dog(string something, int age, string name) : base(age)
    {
        this.something = something;
        this.name = name;
    }

    public override void methodOne()
    {
        Console.WriteLine("nadpisana metoda klasy abstrakcyjnej");
    }
}

