using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class Gamemanagers : MonoBehaviour
{
    bool gameend = false;

    public GameObject CompleteUI;


    public void Complete()
    {
        CompleteUI.SetActive(true);  
    }
    public void GameOver()

    {
        if(gameend == false)
        {
            gameend = true;
            Debug.Log("Game Over");
            Invoke("restart", 1f);  
            /* invoke takes two parameters the first one is the name of the function and 
             * the second is the delay before activating the function */
        }
        
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    

  
}
