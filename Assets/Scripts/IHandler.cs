namespace FreeProgrammer.DesignPatterns.ChainOfResponsibility
{
    // Интерфейс Обработчика объявляет метод построения цепочки обработчиков. Он
    // также объявляет метод для выполнения запроса.
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void WeightLoad(CustomerOrder request);
    }
}
