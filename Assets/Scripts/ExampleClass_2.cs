using UnityEngine;

public class ExampleClass_2 : MonoBehaviour
{
   
   int number = 0;
   float myFloat = 3.14f;
   double myDouble = 3.14;
   bool myBool = true; //True
   int [] numbers = {0,5,3};
   

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("this should print once");
    }

    // Update is called once per frame
    void Update()
    {
        for(int x = 0; x < 10000; x++)
        {        
        number = number + 1;
        print (number);
    }
    }
}
