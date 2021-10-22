
namespace Levels
{
    public class Banana : BaseFructs
    {
        public override void Contact()
        {           
          _particle.Play();
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

