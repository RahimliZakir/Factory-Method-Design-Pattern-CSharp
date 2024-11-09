using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractProduct;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.Factory.ConcreteProduct
{
    // 2. Concrete Product.
    public class VeggieBurger : IBurger
    {
        public void Prepare() => Console.WriteLine("Preparing 'VeggieBurger'...");

        public void Cook() => Console.WriteLine("Cooking 'VeggieBurger'...");

        public void Box() => Console.WriteLine("Boxing 'VeggieBurger'...");
    }
}
