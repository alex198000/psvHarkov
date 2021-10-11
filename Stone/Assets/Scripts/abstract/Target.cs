using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level1
{
    public abstract class Target : MonoBehaviour
    {
        [SerializeField] protected int bonus;
        [SerializeField] protected GameObject effect;
    }
}

