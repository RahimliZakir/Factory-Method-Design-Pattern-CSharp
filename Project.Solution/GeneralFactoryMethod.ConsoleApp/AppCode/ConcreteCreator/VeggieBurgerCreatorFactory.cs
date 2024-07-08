using GeneralFactoryMethod.ConsoleApp.AppCode.ConcreteProduct;
using GeneralFactoryMethod.ConsoleApp.AppCode.Creator;
using GeneralFactoryMethod.ConsoleApp.AppCode.Product;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.ConcreteCreator
{
    // 4. Concrete Product.
    public class VeggieBurgerCreatorFactory : IBurgerCreatorFactory
    {
        public IBurger CreateBurger() => new VeggieBurger();
    }
}
