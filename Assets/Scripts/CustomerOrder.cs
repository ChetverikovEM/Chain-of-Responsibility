using UnityEngine;

namespace FreeProgrammer.DesignPatterns.ChainOfResponsibility
{
    public class CustomerOrder : MonoBehaviour
    {
        [SerializeField] private int _requiredCapacity = 1;
        public int RequiredCapacity => _requiredCapacity;
    }
}