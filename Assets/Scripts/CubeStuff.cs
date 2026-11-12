using UnityEngine;

public class CubeStuff : MonoBehaviour
{

    Animator myAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAnimator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            myAnimator.SetBool("isRot", true);
        }    
    }

    public void AnimationEvent()
    {
        print("Something Just Happened!");
    }
}
