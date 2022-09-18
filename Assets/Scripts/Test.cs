using UnityEngine;

namespace FreeProgrammer.DesignPatterns.ChainOfResponsibility
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private CustomerOrder _order;
        [SerializeField] private SpaceTanker _easton, _levis, _lantau;
        
        void Start()
        {
            _easton.SetNext(_levis).SetNext(_lantau);
            _easton.WeightLoad(_order);
        }
    }
}