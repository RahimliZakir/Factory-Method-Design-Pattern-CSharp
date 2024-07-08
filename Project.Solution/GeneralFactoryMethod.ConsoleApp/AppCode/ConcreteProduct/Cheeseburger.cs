using GeneralFactoryMethod.ConsoleApp.AppCode.Product;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.ConcreteProduct
{
    // 2. Concrete Product.
    public class Cheeseburger : IBurger
    {
        public void Prepare() => Console.WriteLine("Preparing 'Cheeseburger'...");

        public void Cook() => Console.WriteLine("Cooking 'Cheeseburger'...");

        public void Box() => Console.WriteLine("Boxing 'Cheeseburger'...");
    }
}
