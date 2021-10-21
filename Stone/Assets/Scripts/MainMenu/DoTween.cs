using DG.Tweening;
using UnityEngine;

namespace MainMenu
{
    public class DoTween : MonoBehaviour
    {
        [SerializeField] private GameObject _panelCristals;
        [SerializeField] private GameObject _panelLevels;
        [SerializeField] private GameObject _panelCanvas;
        private Tween _tween;

        public void CristalsButtonOpen()
        {
            _tween = _panelCristals.transform.DOMove(new Vector3(_panelCristals.transform.position.x, _panelCristals.transform.position.y + 12, _panelCristals.transform.position.z), 3f, true);
            _panelCanvas.SetActive(false);
        }

        public void LevelsButtonOpen()
        {
            _tween = _panelLevels.transform.DOMove(new Vector3(_panelLevels.transform.position.x, _panelLevels.transform.position.y - 12, _panelLevels.transform.position.z), 3f, true);
            _panelCanvas.SetActive(false);
        }

        public void CristalsButtonClosed()
        {
            _tween = _panelCristals.transform.DOMove(new Vector3(_panelCristals.transform.position.x, _panelCristals.transform.position.y - 12, _panelCristals.transform.position.z), 3f, true);
            _panelCanvas.SetActive(true);
        }

        public void LevelsButtonClosed()
        {
            _tween = _panelLevels.transform.DOMove(new Vector3(_panelLevels.transform.position.x, _panelLevels.transform.position.y + 12, _panelLevels.transform.position.z), 3f, true);
            _panelCanvas.SetActive(true);
        }
    }
}

