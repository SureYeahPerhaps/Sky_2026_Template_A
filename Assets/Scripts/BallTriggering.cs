using System;
using Unity.VisualScripting;
using UnityEngine;

public class BallTriggering : MonoBehaviour
{

    public GameObject ball2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision info)
    {
      ball2.GetComponent<Rigidbody>().useGravity = true;
        
    }

}
