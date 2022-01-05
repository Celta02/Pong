using System.Collections.Generic;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class HintManager : MonoBehaviour
    {
        [SerializeField] HintComponent _aiButton;
        [SerializeField] HintComponent _wasdButton;
        [SerializeField] HintComponent _arrowButton;

        [SerializeField] GameObject _hintContainer;
        [SerializeField] GameObject _aiHint;
        [SerializeField] GameObject _wasdHint;
        [SerializeField] GameObject _arrowHint;

        readonly Dictionary<Controls, GameObject> _hints = new Dictionary<Controls, GameObject>(); 
        void OnEnable()
        {
            _aiButton.Selected += ShowHint;
            _wasdButton.Selected += ShowHint;
            _arrowButton.Selected += ShowHint;
        }
        void OnDisable()
        {
            _aiButton.Selected -= ShowHint;
            _wasdButton.Selected -= ShowHint;
            _arrowButton.Selected -= ShowHint;
        }
        void Awake() => InitializeDictionary();
        void InitializeDictionary()
        {
            _hints.Add(Controls.AiControl, _aiHint);
            _hints.Add(Controls.Wasd, _wasdHint);
            _hints.Add(Controls.Arrows, _arrowHint);
        }

        void ShowHint(Controls control)
        {
            _hintContainer.SetActive(true);
            foreach (var hint in _hints)
                hint.Value.SetActive(false);
            
            _hints[control].SetActive(true);
        }
        public void DisableHints() => _hintContainer.SetActive(false);
    }
}