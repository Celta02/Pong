using System;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class AIController : GameController
    {
        Transform _ball;

        float _verticalRelativePosition;
        
        readonly float _controllerDeadZone = 0.5f;

        void Start() => _ball = GameObject.FindGameObjectWithTag("Ball").transform;

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
        void StopPaddle() => Mover.MovementInput = 0f;

    }
}
