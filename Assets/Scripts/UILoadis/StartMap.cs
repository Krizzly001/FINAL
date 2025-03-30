using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMap : MonoBehaviour
{

    public void StartScene()
    {
        SceneManager.LoadScene("world");
        UnityEngine.SceneManagement.SceneManager.LoadScene("world");
    }
}
