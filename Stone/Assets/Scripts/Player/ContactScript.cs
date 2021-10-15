using UnityEngine;

namespace Level1
{
    public class ContactScript : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D otherCol)
        {
            BaseFructs fruit = otherCol.gameObject.GetComponent<BaseFructs>();
            
            if (fruit != null)                                     //������� � �������� � �������
            {
                fruit.Contact();
                Destroy(otherCol.gameObject);
            }           
        }
    }
}

