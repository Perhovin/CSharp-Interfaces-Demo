namespace InterfacesDemo.Classes;

using InterfacesDemo.Interfaces;

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}
