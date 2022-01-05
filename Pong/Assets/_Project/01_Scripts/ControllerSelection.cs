using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CeltaGames._Project._01_Scripts
{
    [RequireComponent(typeof(ControllerSelectionVisuals))]
    public class ControllerSelection : MonoBehaviour
    {

        [SerializeField] Button _aiButton;
        [SerializeField] Button _wasdButton;
        [SerializeField] Button _arrowButton;

        [SerializeField] GameManager _gameManager;
        [SerializeField] HintManager _hints;
        
        ControllerSelectionVisuals _visuals;
        
        Paddle _currentSubmenuSide;

        Controls _leftControl = Controls.AiControl;
        Controls _rightControl = Controls.AiControl;
        
        readonly Dictionary<Controls, Button> _buttons = new Dictionary<Controls, Button>();

        void Awake() => _visuals = GetComponent<ControllerSelectionVisuals>();

        void Start() => InitializeDictionary();

        void InitializeDictionary()
        {
            _buttons.Add(Controls.Wasd,_wasdButton);
            _buttons.Add(Controls.Arrows,_arrowButton);
        }

        void OnEnable()
        {
            _aiButton.onClick.AddListener( ()=> HandleButtons(Controls.AiControl));
            _wasdButton.onClick.AddListener( ()=> HandleButtons(Controls.Wasd));
            _arrowButton.onClick.AddListener( ()=> HandleButtons(Controls.Arrows));
        }
        void OnDisable()
        {
            _aiButton.onClick.RemoveAllListeners();
            _wasdButton.onClick.RemoveAllListeners();
            _arrowButton.onClick.RemoveAllListeners();
        }

        void HandleButtons(Controls control)
        {
            if (_currentSubmenuSide == Paddle.Left)
                _leftControl = control;
            if (_currentSubmenuSide == Paddle.Right)
                _rightControl = control;
        }

        public void ApplyChanges()
        {
            _visuals.ShowOnlySelections(Paddle.Left, _leftControl);
            _visuals.ShowOnlySelections(Paddle.Right, _rightControl);
            _hints.DisableHints();
            SetGameManagerControls();
        }

        void SetGameManagerControls()
        {
            _gameManager.LetControl = _leftControl;
            _gameManager.RightControl = _rightControl;
        }

        public void SetCurrentSubmenuSide(bool isLeftSide)
        {
            _currentSubmenuSide = isLeftSide ? Paddle.Left : Paddle.Right;
            var control = isLeftSide ? _leftControl : _rightControl;
            EnableOnlyAvailableControls(isLeftSide);
            _visuals.SetArrow(isLeftSide, control);
        }

        void EnableOnlyAvailableControls(bool isLeftSide)
        {
            foreach (var button in _buttons)
                button.Value.interactable = true;
            
            if (isLeftSide && _buttons.TryGetValue(_rightControl, out var leftButton))
                    leftButton.interactable = false;
            if(!isLeftSide && _buttons.TryGetValue(_leftControl, out var rightButton))
                    rightButton.interactable = false;
        }
    }
}
