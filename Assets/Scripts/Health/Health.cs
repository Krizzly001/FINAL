using UnityEngine;

public class Health : MonoBehaviour
{
    //Variables
    public float currentHealth;
    public float maxHeath;

    //Blueprints
    void Start()
    {
        currentHealth = maxHeath;
        
    }
    void Update()
    {
        
    }

    //Functions
    public void TakeDamae(float amount, Character source)
    {
        currentHealth = currentHealth - amount;
        Debug.Log(source.name + " attacked " + gameObject.name + amount + " of health ;(");

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHeath); // sets the min and max health a character can have
        if(currentHealth <= 0)
        {
            Die(source);
        }
    }

    public void Heal(float amount, Character source)
    {
        
        currentHealth = currentHealth + amount;
        Debug.Log(source.name + " healed " + gameObject.name + amount + " health :)");
        currentHealth = Mathf.Clamp(currentHealth, 0, 200); // sets the min and max health a character can have


    }public void Die(Character source)
    {
        Destroy(gameObject);
    }


}
