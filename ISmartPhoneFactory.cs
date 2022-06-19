namespace FactoryMethod;

public interface ISmartPhoneFactory
{
    ISmartPhone MakePhone(ModelYear modelYear);
}