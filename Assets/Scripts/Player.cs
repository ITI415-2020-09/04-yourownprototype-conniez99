using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static private Player p;

    [Header("Set in Inspector")]
    public float velocityMult = 3f;

    [Header("Set Dynamically")]
    public GameObject launchPoint;
    public bool aimingMode;

    void OnMouseEnter()
    {
        print("Player:OnMouseEnter()");
        launchPoint.SetActive(true);
    }

    void OnMouseExit()
    {
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
}
