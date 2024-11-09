namespace GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractProduct
{
    // 1. Product.
    public interface IBurger
    {
        void Prepare();
        void Cook();
        void Box();
    }
}
