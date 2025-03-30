using UnityEngine;

public class HealthPack : MonoBehaviour
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
        Health CharacterHealth = other.GetComponent<Health>();
        if(CharacterHealth != null)
        {
            CharacterHealth.Heal(25, other.GetComponent<Character>());
            Destroy(gameObject);
        }
        else
        {
            Debug.LogWarning("This has no health component");
        }

    }
        
}
