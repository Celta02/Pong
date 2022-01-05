using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CeltaGames._Project._01_Scripts
{
    public class HintComponent : MonoBehaviour, ISelectHandler
    {
        [SerializeField] Controls _controllerType;
        public event Action<Controls> Selected = delegate{};
            
        public void OnSelect(BaseEventData eventData) => Selected.Invoke(_controllerType);
    }
}