using AbstractFactory;
using AbstractFactory.Guitar;
using AbstractFactory.GuitarFactory;
using Builder.Builder;
using Builder.ConcreteBuilder;
using Builder.Director;
using Prototype;
using Prototype.RemoteServer;
using Singleton;
using System;
using System.Threading;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Singleton - Thread Safe
            new Thread(() =>
            {
                var c1 = SingletonClass.GetInstance();
                Console.WriteLine(c1.GetHashCode());
            }).Start();

            new Thread(() =>
            {
                var c2 = SingletonClass.GetInstance();
                Console.WriteLine(c2.GetHashCode());
            }).Start();


            //Prototype
            IGuitarInfo guitarInfo = new GuitarDetails("First Call");
            var copyOfGuitarInfo = guitarInfo.ShallowCopy();
            copyOfGuitarInfo.Print("Shallow Copy");


            //Builder
            ICustomerBuilder customBuilder = new CustomerBuilder();
            CustomerCreationConfiguration customerCreationConfiguration = new CustomerCreationConfiguration();
            customerCreationConfiguration.buildCustomer(customBuilder);


            //Abstract Factory
            IGuitarFactory guitarFactory = new IbanezFactory(7, GuitarType.Electric);
            IGuitar guitar = guitarFactory.GetGuitar(GuitarModels.RGX5);
            IStrings stringType = guitarFactory.GetStringType(StringType.Nylon);
            Console.WriteLine("Guitar Brand is : {0} Model is : {1} Type is : {2} and it has {3} no. of strings and string Type is : {4}",
                guitar.getBrand(), guitar.getGuitarModel(), guitar.getGuitarType(), guitar.getStrings(), stringType.GetStringType());
        }
    }
}
