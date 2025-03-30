using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionScript : MonoBehaviour
{
    public void OptionScene()
    {
        SceneManager.LoadScene("OptionMenu");
        UnityEngine.SceneManagement.SceneManager.LoadScene("OptionMenu");

    }
}
