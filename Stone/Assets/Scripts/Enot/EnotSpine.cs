using Spine.Unity;
using UnityEngine;

namespace Levels
{
    public class EnotSpine : MonoBehaviour
    {
        [SerializeField] private GameObject _enot;
        [SerializeField] private SkeletonAnimation _myAnim;
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private float _enotSpeed;
        [SerializeField] private float _currentEnotSpeed;
        [SerializeField] private float _enotJumpForce;
        private bool _groundCheck;

        private void OnEnable()
        {
            SuperMushroom.OnPlayerWin += EnotWin;
            Muhomor.OnPlayerDefeat += EnotDefeat;
        }

        private void OnDisable()
        {
            SuperMushroom.OnPlayerWin -= EnotWin;
            Muhomor.OnPlayerDefeat -= EnotDefeat;
        }

        private void Start()
        {
            float timeAnime = _myAnim.skeleton.Data.FindAnimation("Idle").Duration;
            _myAnim.state.SetAnimation(0, "Idle", false);
            _myAnim.state.AddAnimation(0, "Applause", true, timeAnime);
        }

        private void FixedUpdate()
        {
            
            _rb.velocity = new Vector2(_currentEnotSpeed * Time.deltaTime, _rb.velocity.y);
        }

        public void RightMove()
        {
            _myAnim.state.SetAnimation(0, "walk", true);
            _currentEnotSpeed = _enotSpeed;
            _enot.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        public void LeftMove()
        {
            _myAnim.state.SetAnimation(0, "walk", true);
            _currentEnotSpeed = -_enotSpeed;
            _enot.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        public void StopMove()
        {
            _myAnim.state.SetAnimation(0, "Idle", true);
            _currentEnotSpeed = 0f;
        }

        public void Jump()
        {
            if (_groundCheck)
            {
                float timeAnimeJmpUp = _myAnim.skeleton.Data.FindAnimation("jump_up").Duration;
                float timeAnimeJmpIdle = _myAnim.skeleton.Data.FindAnimation("jump_idle").Duration;
                _myAnim.state.SetAnimation(0, "jump_up", false);
                _myAnim.state.AddAnimation(0, "jump_idle", false, timeAnimeJmpUp);
                _myAnim.state.AddAnimation(0, "jump_down", false, timeAnimeJmpIdle);
                _rb.velocity = new Vector2(_rb.velocity.x, _enotJumpForce);
                _groundCheck = false;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _groundCheck = true;
        }
        private void EnotWin()
        {
            _myAnim.state.SetAnimation(0, "joy_jump", true);
            Debug.Log("Win");
        }

        private void EnotDefeat()
        {
            _myAnim.state.SetAnimation(0, "joy", true);
            Debug.Log("Def");
        }
    }
}