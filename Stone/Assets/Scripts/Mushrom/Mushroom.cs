
namespace Levels
{
    public class Mushroom : BaseFructs
    {
        public override void Contact()
        {
            _particleMush.Play();
        }
        public override void UpdateScore()
        {
            _uiController.Score += bonus; 
        }
    }
}

