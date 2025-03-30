//Character has a Move...
//Controller will allow the Move to work on Character...
using UnityEngine;

public abstract class Controller : MonoBehaviour //Parent
{
    // Character script and its children can use Character script variables/function/blueprints IF public
    public Character CHARACTER;
    public Hurt HURT;

    public Health HEALTH;   
     //Variables


    //Blueprints
   
    public abstract void Start();
    public abstract void Update();

    //Variables
    //Listens for keys beign pressed
    public abstract void ProccessInput();
}
