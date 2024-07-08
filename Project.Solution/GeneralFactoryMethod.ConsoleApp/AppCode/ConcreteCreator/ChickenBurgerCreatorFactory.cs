using GeneralFactoryMethod.ConsoleApp.AppCode.ConcreteProduct;
using GeneralFactoryMethod.ConsoleApp.AppCode.Creator;
using GeneralFactoryMethod.ConsoleApp.AppCode.Product;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.ConcreteCreator
{
    // 4. Concrete Product.
    public class ChickenBurgerCreatorFactory : IBurgerCreatorFactory
    {
        public IBurger CreateBurger() => new ChickenBurger();
    }
}
