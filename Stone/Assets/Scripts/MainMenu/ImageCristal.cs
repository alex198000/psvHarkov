using ConteinerEnums;
using UnityEngine;

namespace MainMenu
{
    public class ImageCristal : MonoBehaviour
    {
        [SerializeField] private CristalType _cristalT;

        public CristalType CristalT { get => _cristalT; }
    }
}