using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractProduct;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractFactory
{
    // 3. Creator.
    public interface IBurgerCreatorFactory
    {
        IBurger CreateBurger();
    }
}
