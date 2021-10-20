using UnityEngine.UI;
using ConteinerEnums;
using UnityEngine;

namespace MainMenu
{
    public class HUD : MonoBehaviour
    {
        [SerializeField] private Text _textCristal;
        [SerializeField] private ImageCristal[] _imageCristals;
        private void OnEnable()
        {
            ButtonCristal.OnClickButton += SetNameEnum;
            ButtonCristal.OnClickButton += SetImage;
        }

        private void OnDisable()
        {
            ButtonCristal.OnClickButton -= SetNameEnum;
            ButtonCristal.OnClickButton -= SetImage;
        }
        private void SetNameEnum(CristalType cristalType)
        {
            switch (cristalType)
            {
                case CristalType.Cristal_Rubin:
                    _textCristal.text = "кристал Рубин";
                    break;
                case CristalType.Cristal_Almaz:
                    _textCristal.text = "кристал Алмаз";
                    break;
                case CristalType.Cristal_Svor:
                    _textCristal.text = "кристал Своровски";
                    break;
            }
        }

        private void SetImage(CristalType cristalType)
        {
            HideAllImage();
            for (int i = 0; i < _imageCristals.Length; i++)
            {
                if (cristalType == _imageCristals[i].CristalT)
                {
                    _imageCristals[i].gameObject.SetActive(true);
                }
            }
        }

        private void HideAllImage()
        {
            for (int i = 0; i < _imageCristals.Length; i++)
            {
                _imageCristals[i].gameObject.SetActive(false);
            }
        }
    }
}

