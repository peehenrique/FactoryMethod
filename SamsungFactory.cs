namespace FactoryMethod;

public class SamsungFactory : ISmartPhoneFactory
{
    public ISmartPhone MakePhone(ModelYear modelYear)
    {
        if (modelYear is ModelYear.Model2022)
        {
            return new Galaxy2022();
        }

        return new Galaxy2021();
    }
}