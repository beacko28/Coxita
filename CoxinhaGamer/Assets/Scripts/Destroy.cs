using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private float delay = 12.0f;

    void Start()
    {
        Destroy(gameObject, delay );
    }

 
}
