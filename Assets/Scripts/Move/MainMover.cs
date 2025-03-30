using UnityEngine;

public class MainMover : Move // Child
{
    //Variables
    //Rigidbody: Physics are applied to this character
    //Transfrom: Location of Character

    // Holds Rigidbody and Transform into name variables(rb/tf)...
    // We want to change its position, when user wants to move character...
    private Rigidbody rb; 
    private Transform tf;

    //Blueprints
    public override void Start()
    {
        //Grabs and stores into name variables holder
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        
    }
    public override void Update()
    {
        
    }

    //Functions

    public override void Mover(Vector3 direction, float speed)
    {
        // Calculates the characters movement direction in one fram based on its speed
        //Direction.normalized = (x, y, z)
        //Speed = time
        //Time.deltatime = 0.016 ~60FPS
        Vector3 movedVector = direction.normalized * speed * Time.deltaTime;

        //Declares new position to move
        //current position + position to move = new position
        rb.MovePosition(rb.position + movedVector);

    }
    public override void Rotater(float turnSpeed)
    {
        //Declares new roation
        //Rotation: (x: up/down ,y:rotations, z:front/back)
        tf.Rotate(0, turnSpeed * Time.deltaTime, 0);

    }
}
