using System;
using UnityEngine;

namespace Levels
{
    public class ContactScript : MonoBehaviour
    {
       public static event Action OnScorePlus;
       
        void OnTriggerEnter2D(Collider2D otherCol)
        {
            BaseFructs fruit = otherCol.gameObject.GetComponent<BaseFructs>();
            
            if (fruit != null)                                     //контакт с фруктами и грибами
            {
                fruit.Contact();
                fruit.UpdateScore();
                otherCol.gameObject.SetActive(false);
                OnScorePlus?.Invoke();
            }           
        }
    }
}

