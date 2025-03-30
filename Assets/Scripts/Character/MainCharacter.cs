// The Main Character can Move...
using UnityEngine;

public class MainCharacter : Character
{

    //Variables
    private float nextAttackTime;
    public float timeDelay;
    

    //Blueprints
    
    public override void Start()
    {
        timeDelay = 1/hitRate;
        nextAttackTime = Time.time + nextAttackTime;
        
        base.Start();
        
    }
    public override void Update()
    {
        base.Update();
        
    }

    //Functions
    public override void MoveFoward()
    {
        //calls script to(move foward, moveSpeed)
        MOVER.Mover(transform.forward, moveSpeed);
        
    }
    public override void MoveBackwards()
    {

        //calls script to(move foward, -moveSpeed)
        MOVER.Mover(transform.forward, -moveSpeed);

    }
    public override void RotateClockwise()
    {
        MOVER.Rotater(turnSpeed);

    }
    public override void RotateCounterClockwise()
    {
        MOVER.Rotater(-turnSpeed);

    }
    public override void RotateTowards(Vector3 targetPosition)
    {
        // this is a Displacment Vector: Moving one location to another
        // Main Charcters position - enemy ai  = vector to my target
        Vector3 vectorToTarget = targetPosition - transform.position;

        //Makes enemy roatate to target...
        //Quaternion represents rotation
        // Q.LR: calculates a rotation to face a direction
        // vectorToTarget: Target I wanna look at and walk to
        // Vector3.up: keeps the object upright to prevent tilting
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);


        //Rotate by FPS my computer handles...
        //target I want to go to is(enemy rotation, to targets rotation, at a certain speed and direction)
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

    }
    public override void RotateAway(Vector3 targetPosition)
    {
        // this is a Displacment Vector: Moving one location to another
        // Main Charcters position - enemy ai  = vector to my target
        Vector3 vectorToTarget = targetPosition - transform.position;

        //Makes enemy roatate to target...
        //Quaternion represents rotation
        // Q.LR: calculates a rotation to face a direction
        // vectorToTarget: Target I wanna look at and walk to
        // Vector3.up: keeps the object upright to prevent tilting
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);


        //Rotate by FPS my computer handles...
        //target I want to go to is(enemy rotation, to targets rotation, at a certain speed and direction)
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, -turnSpeed * Time.deltaTime);

    }

}