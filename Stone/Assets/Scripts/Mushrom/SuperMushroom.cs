using System;

namespace Levels
{
    public class SuperMushroom : BaseFructs
    {
        public static event Action OnPlayerWin;
        public override void Contact()
        {
            _particle.Play();
            OnPlayerWin?.Invoke();
        }
        public override void UpdateScore()
        {
            _uiController.Score += bonus;
        }

        //public override void DeActiv()
        //{
        //    if (_particle.isStopped)
        //    {
        //        _objDeactiv.gameObject.SetActive(false);
        //    }
        //}
    }
}
