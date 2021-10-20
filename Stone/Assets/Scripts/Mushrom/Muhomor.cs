using UnityEngine;

namespace Levels
{
    public class Muhomor : BaseFructs
    {
        [SerializeField] private Animator _animator;
        public override void Contact()
        {
            _animator.SetTrigger("Die");
            _particleDefeat.Play();
        }
        public override void UpdateScore()
        {
            _uiController.Score += bonus;
        }
    }
}

