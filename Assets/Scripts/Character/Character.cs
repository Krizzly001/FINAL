// What the Characters can do...

using UnityEngine;

public abstract class Character : MonoBehaviour //Parent
{
    public Move MOVER; // Character script and its children can use Move script variables/function/blueprints IF public
   
    

    //Variables

    public float moveSpeed;
    public float turnSpeed;

    //Attacking
    public GameObject SwordPrefab;
    public float damageDone;

    public float LifeSpan;

    public float hitRate;

    //Blueprints
    
    public virtual void Start()
    {
        MOVER = GetComponent<Move>();
        
    }
    public virtual void Update()
    {
        
    }

    //Functions

    //For Main Character

    public abstract void MoveFoward();
    public abstract void MoveBackwards();

    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();

    public abstract void RotateTowards(Vector3 targetPosition);
    public abstract void RotateAway(Vector3 targetPositiion);


   




    
    
}
