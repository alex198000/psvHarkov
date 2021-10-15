
namespace Level1
{
    public class Banana : BaseFructs
    {
        public override void Contact()
        {
            Instantiate(effect, transform.position, transform.rotation);
        }
    }
}

