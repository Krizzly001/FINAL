// Functions to move characters...
using Unity.VisualScripting;
using UnityEngine;

public abstract class Move : MonoBehaviour //Parent
{
    //Variables

    


    //Blueprints
    public abstract void Start();

    public abstract void Update();
    

    //Functions
    //We want user/dev to decide the speeds for Move and Rotate

    public abstract void Mover(Vector3 direction, float speed);
    public abstract void Rotater(float turnSpeed);

}
