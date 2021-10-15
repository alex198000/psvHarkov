using UnityEngine;

namespace MainMenu
{
    public class AnimatorController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        void Start()
        {
            _animator.SetTrigger("Nasos");
        }

        
    }
}

