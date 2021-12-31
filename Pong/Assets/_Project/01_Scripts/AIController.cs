using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CeltaGames._Project._01_Scripts
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] Transform _ball;
        [SerializeField] float _controllerDeadZone = 0.5f;

        PaddleMover _mover;

        float _verticalRelativePosition;

        void Awake()
        {
            _mover = GetComponent<PaddleMover>();
        }

        void Update()
        {
            UpdateVerticalRelativePosition();
            if(!DeadZone())
                MovePaddle(_verticalRelativePosition);
            else
                StopPaddle();
        }
        
        void UpdateVerticalRelativePosition() => _verticalRelativePosition = (_ball.position.z - transform.position.z);
        bool DeadZone() => Mathf.Abs(_verticalRelativePosition) < _controllerDeadZone;
        void MovePaddle(float value) => _mover.MovementInput = Mathf.Clamp(value,-1f,1f);
        void StopPaddle() => _mover.MovementInput = 0f;
    }
}
