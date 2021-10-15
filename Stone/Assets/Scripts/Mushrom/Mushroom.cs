using UnityEngine;

namespace Level1
{
    public class Mushroom : BaseFructs
    {
        public override void Contact()
        {
            GameObject bonusEffect = Instantiate(effect, transform.position, transform.rotation);
            Destroy(bonusEffect, 5f);
        }
    }
}

