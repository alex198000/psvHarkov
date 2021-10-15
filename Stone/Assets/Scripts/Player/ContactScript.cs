using System;
using UnityEngine;

namespace Level1
{
    public class ContactScript : MonoBehaviour
    {
        public static event Action ScorePlus;
        void OnTriggerEnter2D(Collider2D otherCol)
        {
            BaseFructs fruit = otherCol.gameObject.GetComponent<BaseFructs>();
            
            if (fruit != null)                                     //контакт с фруктами и грибами
            {
                fruit.Contact();
                Destroy(otherCol.gameObject);
                ScorePlus?.Invoke();
            }           
        }
    }
}

