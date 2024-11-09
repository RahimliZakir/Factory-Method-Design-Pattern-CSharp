using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractProduct;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.Factory.ConcreteProduct
{
    // 2. Concrete Product.
    public class Cheeseburger : IBurger
    {
        public void Prepare() => Console.WriteLine("Preparing 'Cheeseburger'...");

        public void Cook() => Console.WriteLine("Cooking 'Cheeseburger'...");

        public void Box() => Console.WriteLine("Boxing 'Cheeseburger'...");
    }
}
