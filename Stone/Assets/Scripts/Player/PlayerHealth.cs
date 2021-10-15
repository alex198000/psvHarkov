using System.Collections;
using UnityEngine;

namespace Level1
{
    public class PlayerHealth : Alive
    {
        [SerializeField] private Animator _animator;
        public override void Die()
        {
            
            StartCoroutine(Defeat());
        }

        IEnumerator Defeat()
        {
            _animator.SetTrigger("Die");
            yield return new WaitForSeconds(1.2f);
            gameObject.SetActive(false);
            //Time.timeScale = 0;

            yield break;
        }
    }
    
}

