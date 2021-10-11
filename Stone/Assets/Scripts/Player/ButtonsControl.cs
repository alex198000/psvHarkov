using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level1
{
    public class ButtonsControl : MonoBehaviour
    {
        [SerializeField] MyPlayerMovement myPlayerMovement;
        //[SerializeField] PlayerAttack playerAttack;
        void Update()
        {
            MooveBut();
        }
        public void MooveBut()
        {
            if (Input.GetButton("Jump"))
            {
                myPlayerMovement.Jump();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                myPlayerMovement.LeftMove();
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                myPlayerMovement.StopMove();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                myPlayerMovement.RightMove();
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                myPlayerMovement.StopMove();
            }

        }
    }

}
