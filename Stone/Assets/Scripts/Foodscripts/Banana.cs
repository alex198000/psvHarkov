
namespace Level1
{
    public class Banana : BaseFructs
    {       
        public override void Contact()
        {
            Instantiate(_effect, transform.position, transform.rotation);
        }
        public override void UpdateScore()
        {
            _uiController.score += bonus;
        }
    }
}

