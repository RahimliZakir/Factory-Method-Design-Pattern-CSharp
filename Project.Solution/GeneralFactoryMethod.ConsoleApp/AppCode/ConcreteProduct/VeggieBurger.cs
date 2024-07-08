using GeneralFactoryMethod.ConsoleApp.AppCode.Product;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.ConcreteProduct
{
    // 2. Concrete Product.
    public class VeggieBurger : IBurger
    {
        public void Prepare() => Console.WriteLine("Preparing 'VeggieBurger'...");

        public void Cook() => Console.WriteLine("Cooking 'VeggieBurger'...");

        public void Box() => Console.WriteLine("Boxing 'VeggieBurger'...");
    }
}
