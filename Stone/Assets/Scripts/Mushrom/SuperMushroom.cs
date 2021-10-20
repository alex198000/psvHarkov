using UnityEngine;

namespace Levels
{
    public class SuperMushroom : BaseFructs
    {
        [SerializeField] private Animator _animator;
        public override void Contact()
        {
            _animator.SetTrigger("Win");
            _particleWin.Play();
        }
        public override void UpdateScore()
        {
            _uiController.Score += bonus;
        }
    }
}
