using UnityEngine;

namespace Level1
{
    public class PlayerHealth : Alive
    {
        [SerializeField] private Animator _animator;
        public override void Die()
        {
            _animator.SetTrigger("Die");
        }
    }
}

