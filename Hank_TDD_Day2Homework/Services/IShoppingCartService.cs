namespace Hank_TDD_Day2Homework.Services
{
    public interface IShoppingCartService<T>
    {
        void OrderProduct(T product);

        int Bill();
    }
}