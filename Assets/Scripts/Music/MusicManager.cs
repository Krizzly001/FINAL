using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private MusicManager instance;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instance
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
