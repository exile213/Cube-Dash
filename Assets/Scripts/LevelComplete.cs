
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public void Nextlevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 

    }
}
