using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level1
{
    public class ContactScript : MonoBehaviour
    {

        [SerializeField] private GameObject danger;
        [SerializeField] private GameObject canvasPanel;
        [SerializeField] private GameObject winGame;
        [SerializeField] private GameObject defGame;
        [SerializeField] private GameObject winExp;
        [SerializeField] private GameObject eatFruit;
        [SerializeField] private PlayerHealth _playerHealth;


        //private void OnEnable()
        //{
        //    MenuScript.GameWin += coinsUpdate;
        //}
        //private void OnDisable()
        //{
        //    MenuScript.GameWin -= coinsUpdate;
        //}
        void OnTriggerEnter2D(Collider2D otherCol)
        {
            FruitScript fruitScript = otherCol.gameObject.GetComponent<FruitScript>();
            MushroomScript mushroomScript = otherCol.gameObject.GetComponent<MushroomScript>();

            MuhomorScript muhomorScript = otherCol.gameObject.GetComponent<MuhomorScript>();

            SuperMushroomScript superMushroomScript = otherCol.gameObject.GetComponent<SuperMushroomScript>();

            if (muhomorScript != null)                                     //контакт с мухомором, минус жизнь
            {
                GameObject dangerous = Instantiate(danger, transform.position, transform.rotation);
                Destroy(dangerous, 5f);
                defGame.SetActive(true);
                canvasPanel.SetActive(false);
                _playerHealth.Die();
                //gameObject.SetActive(false);
            }





            if (mushroomScript != null)                 //контакт с полезным грибом
            {
                GameObject fru = Instantiate(eatFruit, transform.position, transform.rotation);
                Destroy(fru, 5f);

                Destroy(otherCol.gameObject);
            }

            if (fruitScript != null)                  //контакт с фруктами
            {
                GameObject fru = Instantiate(eatFruit, transform.position, transform.rotation);
                Destroy(fru, 5f);

                Destroy(otherCol.gameObject);
            }

            if (superMushroomScript != null)                       // контакт с супер грибом для перехода к новому уровню
            {
                GameObject win = Instantiate(winExp, transform.position, transform.rotation);
                Destroy(win, 5f);
                winGame.SetActive(true);
                canvasPanel.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}

