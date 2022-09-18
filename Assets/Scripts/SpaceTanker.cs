using UnityEngine;

namespace FreeProgrammer.DesignPatterns.ChainOfResponsibility
{
    public class SpaceTanker : MonoBehaviour, IHandler
    {
        // Грузоподъемность корабля 
        [SerializeField] private int _carryingСapacity;
        // Хранит следующий обработчик в цепочке
        private IHandler _nextHandler;

        // Метод установливает следующий обработчик в цепочке
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            // Возврат обработчика отсюда позволит связать обработчики простым
            // способом, вот так:
            // _easton.SetNext(_levis).SetNext(_lantau);
            return handler;
        }

        // Установим поведение в случае наличия или отсутствия
        // следующего обработчика в цепочке, а также обработаем входящий запрос
        public void WeightLoad(CustomerOrder request)
        {
            if (request.RequiredCapacity <= _carryingСapacity)
            {
                print($"Космический танкер \"{gameObject.name}\" - готов принять груз к перевозке");
            }
            else 
            {
                if (_nextHandler != null)
                {
                    _nextHandler.WeightLoad(request);
                }
                else
                {
                    print("В доке нет космического танкера с нужной грузоподьемностью");
                }
            }
        }
    }
}
