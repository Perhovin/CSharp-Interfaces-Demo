namespace InterfacesDemo.Classes;

using InterfacesDemo.Interfaces;

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}
