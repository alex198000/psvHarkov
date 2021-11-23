using DG.Tweening;
using UnityEngine;

namespace MainMenu
{
    public class DoTween : MonoBehaviour
    {
        [SerializeField] private GameObject _panelCristals;
        [SerializeField] private GameObject _panelLevels;
        [SerializeField] private GameObject _panelCanvas;
        private Tween _tween = null;

        public void CristalsButtonOpen()
        {
            _tween = _panelCristals.transform.DOMove(new Vector3(0, 0, 0), 1f, true).SetEase(Ease.InOutBack).SetUpdate(true);
            _panelCanvas.SetActive(false);
        }

        public void LevelsButtonOpen()
        {
            _tween = _panelLevels.transform.DOMove(new Vector3(0, 0, 0), 1f, true).SetEase(Ease.InOutBack).SetUpdate(true);
            _panelCanvas.SetActive(false);
        }

        public void CristalsButtonClosed()
        {
            _tween = _panelCristals.transform.DOMove(new Vector3(0, -11, 0), 1f, true).SetEase(Ease.InBack).SetUpdate(true);
            _panelCanvas.SetActive(true);
        }

        public void LevelsButtonClosed()
        {
            _tween = _panelLevels.transform.DOMove(new Vector3(0, +11, 0), 1f, true).SetEase(Ease.InBack).SetUpdate(true);
            _panelCanvas.SetActive(true);
        }

        private void OnDisable()
        {
            if (DOTween.instance != null)
            {
                _tween?.Kill();
            }
        }
    }
}

