using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Goal : MonoBehaviour
{
    static public bool goalMet = false;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (PlayerController.count == 7)
            {
                goalMet = true;
            }
        }


    }

    void Update()
    {
        if (PlayerController.count == 7)
        {
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 0.5f;
            mat.color = c;
        }
        if (goalMet == true)
        {
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
        }
    }

}
