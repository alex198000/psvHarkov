
namespace Levels
{
    public class Mushroom : BaseFructs
    {
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
        }
        public override void UpdateScore()
        {
            _uiController.Score += bonus; 
        }

        public override void DeActiv()
        {
            if (_particle.isStopped)
            {
                _objDeactiv.gameObject.SetActive(false);
            }
        }
    }
}

