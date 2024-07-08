using GeneralFactoryMethod.ConsoleApp.AppCode.Product;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.Creator
{
    // 3. Creator.
    public interface IBurgerCreatorFactory
    {
        IBurger CreateBurger();
    }
}
