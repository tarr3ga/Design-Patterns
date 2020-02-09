namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore myStore = new NYPizzaStore();
            myStore.orderPizza("Pepperoni");

            myStore = new ChicagoPizzaStore();
            myStore.orderPizza("Supreme");
        }
    }
}
