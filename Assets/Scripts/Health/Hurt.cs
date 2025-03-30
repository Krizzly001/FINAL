using UnityEngine;

public class Hurt : MonoBehaviour
{
    //Variables
    public float damageDone;
    
    public Character owner;

    private float nextAttackTime;
    public float timeDelay;
    public float hitRate;
   


    //Blueprints
    void Start()
    {
        timeDelay = 1/hitRate;
        nextAttackTime = Time.time + nextAttackTime;
        
    }
    void Update()
    {
        
    }

    //Variables

    public void OnTriggerEnter(Collider other)
    {
        

        //Gets the targets health
        Health otherHealth = other.gameObject.GetComponent<Health>();


        if(otherHealth != null) //Chcks if think being hit had health
        {
            if(Time.time >= nextAttackTime)
            //Damaged the target being hit if it has health
            {
                otherHealth.TakeDamae(damageDone, owner);
                nextAttackTime = Time.time + timeDelay;
            }
        }
        else
        {
            Debug.Log("You Missed!");
        }

    }
}
