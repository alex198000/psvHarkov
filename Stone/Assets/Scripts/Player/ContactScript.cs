using System;
using UnityEngine;

namespace Levels
{
    public class ContactScript : MonoBehaviour
    {
       public static event Action OnScorePlus;
       
        void OnTriggerEnter2D(Collider2D otherCol)     //контакт с фруктами и грибами
        {
            BaseFructs fruit = otherCol.gameObject.GetComponent<BaseFructs>();
            
            if (fruit != null)                                     
            {
                fruit.Contact();
                fruit.UpdateScore();
                //otherCol.gameObject.SetActive(false);
                OnScorePlus?.Invoke();
            }           
        }
    }
}

