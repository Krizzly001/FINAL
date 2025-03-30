using UnityEngine;
using UnityEngine.Rendering;

public class CoinPack : MonoBehaviour
{
    public Collider other;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {

    }

    //Functions

    public void OnTriggerEnter(Collider other)
    {
        
        CoinManager addC = other.GetComponent<CoinManager>();
        addC.AddCoins();
        Destroy(gameObject);
        

    }
}
