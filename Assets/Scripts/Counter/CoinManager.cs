using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinManager : MonoBehaviour
{
    
    public int CurrentCoins;

    public int MaxCoins;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins()
    {
      CurrentCoins = CurrentCoins + 1;
      if(CurrentCoins == 10)
      {
        SceneManager.LoadScene("MainMenu");
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");

      }
    }
}
