namespace FactoryMethod;

public class AppleFactory : ISmartPhoneFactory
{
    public ISmartPhone MakePhone(ModelYear modelYear)
    {
        if (modelYear is ModelYear.Model2022)
        {
            return new Iphone13();
        }
        
        return new Iphone12();
    }
}