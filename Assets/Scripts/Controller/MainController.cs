using UnityEngine;

public class MainController : Controller
{
    //Variables
    //dev/user need to assign key for each variable
    public KeyCode moveFowardKey;
    public KeyCode moveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;


    //Blueprints
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        //Looks for any Inpt at all times
        ProccessInput();
        
    }

    //Variables
    public override void ProccessInput()
    {
        if(Input.GetKey(moveFowardKey))
        {
            //not changing variables...just calling functionsw
            CHARACTER.MoveFoward();
        }
        if(Input.GetKey(moveBackwardKey))
        {
            CHARACTER.MoveBackwards();
        }
        if(Input.GetKey(rotateClockwiseKey))
        {
            CHARACTER.RotateClockwise();
        }
        if(Input.GetKey(rotateCounterClockwiseKey))
        {
            CHARACTER.RotateCounterClockwise();
        }
        

        

    }
}
