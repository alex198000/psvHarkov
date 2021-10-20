using UnityEngine;
using ConteinerEnums;
using UnityEngine.UI;
using System;

namespace MainMenu
{
    [RequireComponent(typeof(Button))]
    public class ButtonCristal : MonoBehaviour
    {
        public static event Action<CristalType> OnClickButton;

        [SerializeField] private CristalType _cristalT;
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(ClickBTN);
        }
        private void ClickBTN()
        {
            OnClickButton?.Invoke(_cristalT);
        }
    }
   
}

