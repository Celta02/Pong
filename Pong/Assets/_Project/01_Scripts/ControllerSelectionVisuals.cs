using System.Collections.Generic;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class ControllerSelectionVisuals : MonoBehaviour
    {
        [Header("Left Selection GameObjects"), Space]
        [SerializeField] GameObject _leftAISelection;
        [SerializeField] GameObject _leftWasdSelection;
        [SerializeField] GameObject _leftArrowsSelection; 
        
        [Header("Right Selection GameObjects"), Space]
        [SerializeField] GameObject _rightAISelection;
        [SerializeField] GameObject _rightWasdSelection;
        [SerializeField] GameObject _rightArrowsSelection;
        
        [Header("Submenu Controllers Arrows"), Space]
        [SerializeField] GameObject _aiArrow;
        [SerializeField] GameObject _wasdArrow;
        [SerializeField] GameObject _arrowsArrow;
        
        readonly Dictionary<Controls, GameObject> _leftSelections = new Dictionary<Controls, GameObject>();
        readonly Dictionary<Controls, GameObject> _rightSelections = new Dictionary<Controls, GameObject>();
        readonly Dictionary<Controls, GameObject> _arrows = new Dictionary<Controls, GameObject>();
        
        void Awake() => InitializeDictionaries();

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
        
        public void SetArrow(bool isLeftSide, Controls control)
        {
            foreach (var arrow in _arrows)
                arrow.Value.SetActive(false);
            
            if (isLeftSide)
                _arrows[control].SetActive(true);
            else
                _arrows[control].SetActive(true);
        }
        
        public void ShowOnlySelections(Paddle side, Controls control)
        {
            DisableAllSelections(side);

            if (side == Paddle.Left)
                _leftSelections[control].SetActive(true);
            
            if (side == Paddle.Right)
                _rightSelections[control].SetActive(true);
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