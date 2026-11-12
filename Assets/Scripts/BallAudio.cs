using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

public class ExampleClass : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject ball2;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();      
    }


    void Update()
    {
        if (Input.GetKeyDown("f") || Input.GetButtonDown("Jump")) 
        {
            GetComponent<Rigidbody>().useGravity = true;   
        }

       
    }


    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

  
    void OnTriggerEnter(Collider other)
    {
        print("Triggered by " + other.name);
        // Material otherMaterial = other.GetComponent<Renderer>().material;
        // otherMaterial.SetColor("_BaseColor", Color.red);
        other.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.cyan);
    }


     void OnTriggerExit(Collider other)
    {
         other.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.yellow);
    }


    void OnCollisionEnter(Collision collision)
    {
        ball2.GetComponent<Rigidbody>().useGravity = true;
        audioSource.Play();
    }

}