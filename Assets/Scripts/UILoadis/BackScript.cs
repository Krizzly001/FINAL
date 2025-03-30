using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{
    public void MenuScene()
    {
        SceneManager.LoadScene("MainMenu");
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");

    }
    
}
