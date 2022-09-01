
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public Gamemanagers gmanager;
    public AudioSource win;
    
    void OnTriggerEnter()
    {
        win.GetComponent<AudioSource>();

        gmanager.Complete();
        win.Play();


    }
}

