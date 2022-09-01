
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void restarts()
    {
        SceneManager.LoadScene("Level1");
    }
}
