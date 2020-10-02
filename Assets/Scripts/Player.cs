using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Collections.Specialized;
=======
>>>>>>> parent of b345262... player movement
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
=======
    static private Player p;

    [Header("Set in Inspector")]
    public float velocityMult = 3f;

    [Header("Set Dynamically")]
    public GameObject launchPoint;
    public bool aimingMode;
>>>>>>> parent of b345262... player movement

    void OnMouseEnter()
    {
        print("Player:OnMouseEnter()");
<<<<<<< HEAD
=======
        launchPoint.SetActive(true);
>>>>>>> parent of b345262... player movement
    }

    void OnMouseExit()
    {
<<<<<<< HEAD
        print("Player:OnMouseExit()");       
    }

=======
        print("Player:OnMouseExit()");
        launchPoint.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
>>>>>>> parent of b345262... player movement
}
