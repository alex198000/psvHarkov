
namespace Levels
{
    public class Mushroom : BaseFructs
    {
        public override void Contact()
        {
            _particle.Play();
        }
        public override void UpdateScore()
        {
            _uiController.Score += bonus; 
        }        
    }
}

