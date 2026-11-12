using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class UIController : MonoBehaviour
{
    public GameObject quitDialogue;
    public UnityEvent myEvent;
   
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            quitDialogue.SetActive(true);
            myEvent.Invoke();
        }
    
    }


public void QuitApp()
    {
        print("You quit the app");
        Application.Quit();
    }


}


