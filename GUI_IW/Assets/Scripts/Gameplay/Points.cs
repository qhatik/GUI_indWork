using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameObject ships;

    private void Start()
    {
       
        Instantiate(ships, transform.position, Quaternion.identity);
    }
}
