using System;
using UnityEngine;

namespace Level1
{
    public class ContactScript : MonoBehaviour
    {
       public static Action ScorePlus;
       
        void OnTriggerEnter2D(Collider2D otherCol)
        {
            BaseFructs fruit = otherCol.gameObject.GetComponent<BaseFructs>();
            
            if (fruit != null)                                     //������� � �������� � �������
            {
                fruit.Contact();
                fruit.UpdateScore();
                Destroy(otherCol.gameObject);
                ScorePlus?.Invoke();
            }           
        }
    }
}

