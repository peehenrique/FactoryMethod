namespace FactoryMethod;

public class Iphone12 : ISmartPhone
{
    public void ShowInfo()
    {
        Console.WriteLine("Marca: Apple\nModelo: Iphone 12");
    }
}