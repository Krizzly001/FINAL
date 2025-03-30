//Enemy behaveiors...
using JetBrains.Annotations;
using UnityEngine;
using System.Collections;
using UnityEditor.Timeline;

public class EnemyController : Controller
{
    //Variables

    public enum AIState {Guard, Looking, Chace, Flee, Attack};
    public AIState currentState;

    public GameObject target;

    public float StartLookingWhenDistance;
    public float StartChaceWhenDistance;
    public float StartFleeWhenHealth;
    public float StartAttackingDistance;

    private float nextAttackTime;
    public float timeDelay;

    





    //Blueprints
    public override void Start()
    {
        
    }
    public override void Update()    
    {
        if(HEALTH.currentHealth <= 20)
        {
            currentState = AIState.Flee;

        }
        
        ProccessInput();
        
    }

    //Functions
    public override void ProccessInput()
    {
        switch(currentState)
        {
            case AIState.Guard:

            break;
            case AIState.Chace:
            if(IsDistanceLessThan(target, StartChaceWhenDistance))
            {
                ChaceTarget(target);
            }
            if(IsDistanceLessThan(target, 3))
            {
                currentState = AIState.Attack;
            }
            
            break;
            case AIState.Looking:
            Looking();
            break;
            case AIState.Flee:
            if(IsDistanceLessThan(target, StartFleeWhenHealth))
            {
                FleeTarget(target);
                
            }
            break;
            case AIState.Attack:
            Attacking(target);
            
            
            break;


        }
       
    }
   
    public bool IsDistanceLessThan(GameObject target, float distance)
    {
        // if the targets distance is less then are distance == true, anything lese false
        if(Vector3.Distance(CHARACTER.transform.position, target.transform.position) < distance)
        {
            return true;

        }
        else
        {
            return false;
        }

    }

    public void ChaceTarget(GameObject target)
    {
        //Rotate Towards the target
        CHARACTER.RotateTowards(target.transform.position);

        //Moves Foward that rotation it looks at
        CHARACTER.MoveFoward();
        


    }
    public void Looking()
    {
        CHARACTER.transform.Rotate(0, 50 * Time.deltaTime,0);
        Debug.Log("AI is Lokking...");

    }
    public void FleeTarget(GameObject target)
    {
        //Rotate Away From target
        CHARACTER.RotateAway(target.transform.position);

        //Move towards the direction this enemy is looking at
        CHARACTER.MoveFoward();

    }

    public void Attacking(GameObject target)
    {

        //Gets the targets health
        Health otherHealth = target.gameObject.GetComponent<Health>();


        if(otherHealth != null) //Chcks if think being hit had health
        {
            if(Time.time >= nextAttackTime)
            //Damaged the target being hit if it has health
            {
                otherHealth.TakeDamae(10, CHARACTER);
                nextAttackTime = Time.time + timeDelay;
            }
        }
        else
        {
            Debug.Log("You Missed!");
        }
        currentState = AIState.Chace;
          
    }
    


}
