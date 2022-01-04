using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CeltaGames._Project._01_Scripts
{
    public class ControllerSelection : MonoBehaviour
    {
        [SerializeField] GameObject _leftAISelection;
        [SerializeField] GameObject _leftWasdSelection;
        [SerializeField] GameObject _leftArrowsSelection; 
        
        [SerializeField] GameObject _rightAISelection;
        [SerializeField] GameObject _rightWasdSelection;
        [SerializeField] GameObject _rightArrowsSelection;
        
        [SerializeField] Button _aiButton;
        [SerializeField] Button _wasdButton;
        [SerializeField] Button _arrowButton;

        [SerializeField] GameObject _aiArrow;
        [SerializeField] GameObject _wasdArrow;
        [SerializeField] GameObject _arrowsArrow;

        [SerializeField] GameManager _gameManager;
        
        Paddle _currentSubmenuSide;

        readonly Dictionary<Controls, GameObject> _leftSelections = new Dictionary<Controls, GameObject>();
        readonly Dictionary<Controls, GameObject> _rightSelections = new Dictionary<Controls, GameObject>();
        readonly Dictionary<Controls, GameObject> _arrows = new Dictionary<Controls, GameObject>();

        Controls _leftControl = Controls.AiControl;
        Controls _rightControl = Controls.AiControl;

        void Awake() => InitializeDictionaries();

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
        
        
        void InitializeDictionaries()
        {
            _leftSelections.Add(Controls.AiControl, _leftAISelection);
            _leftSelections.Add(Controls.Wasd, _leftWasdSelection);
            _leftSelections.Add(Controls.Arrows, _leftArrowsSelection);

            _rightSelections.Add(Controls.AiControl, _rightAISelection);
            _rightSelections.Add(Controls.Wasd, _rightWasdSelection);
            _rightSelections.Add(Controls.Arrows, _rightArrowsSelection);
            
            _arrows.Add(Controls.AiControl,_aiArrow);
            _arrows.Add(Controls.Wasd,_wasdArrow);
            _arrows.Add(Controls.Arrows,_arrowsArrow);
        }

        public void ApplyChanges()
        {
            EnableOnlySelections(Paddle.Left);
            EnableOnlySelections(Paddle.Right);
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
            EnableOnlyAvailableControls(isLeftSide);
            SetArrow(isLeftSide);
        }
        void EnableOnlyAvailableControls(bool isLeftSide)
        {
            _wasdButton.interactable = true;
            _arrowButton.interactable = true;
            
            if (isLeftSide)
            {
                if (_rightControl == Controls.Wasd)
                    _wasdButton.interactable = false;

                if (_rightControl == Controls.Arrows)
                    _arrowButton.interactable = false;
            }
            else
            {
                if (_leftControl == Controls.Wasd)
                    _wasdButton.interactable = false;

                if (_leftControl == Controls.Arrows)
                    _arrowButton.interactable = false;
            }
        }

        void SetArrow(bool isLeftSide)
        {
            foreach (var arrow in _arrows)
                arrow.Value.SetActive(false);
            
            if (isLeftSide)
                _arrows[_leftControl].SetActive(true);
            else
                _arrows[_rightControl].SetActive(true);
        }
        void EnableOnlySelections(Paddle side)
        {
            DisableAllSelections(side);

            if (side == Paddle.Left)
                _leftSelections[_leftControl].SetActive(true);
            
            if (side == Paddle.Right)
                _rightSelections[_rightControl].SetActive(true);
        }
        void DisableAllSelections(Paddle side)
        {
            if (side == Paddle.Left)
            {
                foreach (var selection in _leftSelections)
                    selection.Value.SetActive(false);
            }
            else
            {
                foreach (var selection in _rightSelections)
                    selection.Value.SetActive(false);
            }
        }
    }
}
