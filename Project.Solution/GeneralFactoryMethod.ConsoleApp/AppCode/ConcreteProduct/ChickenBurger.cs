using GeneralFactoryMethod.ConsoleApp.AppCode.Product;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.ConcreteProduct
{
    // 2. Concrete Product.
    public class ChickenBurger : IBurger
    {
        public void Prepare() => Console.WriteLine("Preparing 'ChickenBurger'...");

        public void Cook() => Console.WriteLine("Cooking 'ChickenBurger'...");

        public void Box() => Console.WriteLine("Boxing 'ChickenBurger'...");
    }
}
