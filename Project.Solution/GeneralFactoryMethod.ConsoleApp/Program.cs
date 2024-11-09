using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractFactory;
using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractProduct;
using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.ConcreteFactory;


// 1. Cheeseburger.
IBurgerCreatorFactory cheeseBurgerCreatorFactory = new CheeseburgerCreatorFactory();
IBurger cheeseBurger = cheeseBurgerCreatorFactory.CreateBurger();
cheeseBurger.Prepare();
cheeseBurger.Cook();
cheeseBurger.Box();

// 2. VeggieBurger.
IBurgerCreatorFactory veggieBurgerCreatorFactory = new VeggieBurgerCreatorFactory();
IBurger veggieBurger = veggieBurgerCreatorFactory.CreateBurger();
veggieBurger.Prepare();
veggieBurger.Cook();
veggieBurger.Box();

// 3. ChickenBurger.
IBurgerCreatorFactory chickenBurgerCreatorFactory = new ChickenBurgerCreatorFactory();
IBurger chickenBurger = chickenBurgerCreatorFactory.CreateBurger();
chickenBurger.Prepare();
chickenBurger.Cook();
chickenBurger.Box();

Console.ReadKey();