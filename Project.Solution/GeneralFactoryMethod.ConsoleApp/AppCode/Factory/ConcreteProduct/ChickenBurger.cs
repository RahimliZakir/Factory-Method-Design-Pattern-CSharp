using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractProduct;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.Factory.ConcreteProduct
{
    // 2. Concrete Product.
    public class ChickenBurger : IBurger
    {
        public void Prepare() => Console.WriteLine("Preparing 'ChickenBurger'...");

        public void Cook() => Console.WriteLine("Cooking 'ChickenBurger'...");

        public void Box() => Console.WriteLine("Boxing 'ChickenBurger'...");
    }
}
