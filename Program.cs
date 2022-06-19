using FactoryMethod;

var factory = new AppleFactory();

var phone = factory.MakePhone(ModelYear.Model2022);

phone.ShowInfo();