using System;

namespace Levels
{
    public class Muhomor : BaseFructs
    {
        public static event Action OnPlayerDefeat;

        private void OnEnable()
        {
            ContactScript.OnScorePlus += DeActiv;
        }
        private void OnDisable()
        {
            ContactScript.OnScorePlus -= DeActiv;
        }
        public override void Contact()
        {
            _particle.Play();
            OnPlayerDefeat?.Invoke();
        }       

        public override void UpdateScore()
        {
            _uiController.Score += bonus;
        }

        public override void DeActiv()
        {
            if (_particle.isStopped)
            {
                gameObject.SetActive(false);
            }
        }
    }
}

