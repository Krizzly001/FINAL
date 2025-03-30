using UnityEngine;

public class Map : MonoBehaviour
{
    //VARIABLES

    public GameObject[] gridPrefabs; //Holds list of room prefabs objects

    //Number over rows and columns we want spawned
    public int rows;
    public int cols;

    //Hieght and Width or the rows
    public float roomWidth = 50.0f;
    public float roomHeight = 50.0f;

    private WALLS[,] grid;
    






    //BLUEPRINTS
    void Start()
    {
        
        
    }
    void Update()
    {
        
    }


    //FUNCTIONS

    //REASON: Grabs random room to place 
    public GameObject RandomRoomPrefab()
    { 
        //Places a random type of room from the gridPrefab array
        //(grabs random room, from 0 - max number of room gridprabs in the array)
        return gridPrefabs[Random.Range(0, gridPrefabs.Length)];
    }


    //Generaes Whole Map
    public void GenerateMap()
    {
        //Clears and makes a new grid
        //column is out x and row is are y, (X,Y)
        grid = new WALLS[cols, rows];
        
        //REASON: Generates the exact of rooms i want in the map
        // for each grid row...
        // (Current row # start as 0, if its lower then the amount of rows we want, add another row)
        // Keeps going untill I have the exact amount of rows I want in my map
    
        for (int currentRow = 0; currentRow < rows; currentRow++)
        {
            // for each column in that row
            for (int currentCol = 0; currentCol < cols; currentCol++)
            {
                //Figure out the location the room will be placed
                //LOOKING DOWN...
                // x also means width in unity (left and right)
                // y also means height in unity (up and down)

                //Each rooom position will be calculated
                float xPosition = roomWidth * currentCol; //ex. 50 * cols: 0, //ex. 50 * cols: 1 ...
                float yPosition = roomHeight * currentRow; //ex. 50 * row: 0, //ex. 50 * row: 1...
                //Position placed: Vector3( 0, 0.0f, 0), Vector3( 50, 0.0f, 50)...
                Vector3 newPosition = new Vector3(xPosition, 0.0f, yPosition);

                //spawns(that random room that was choosen, at its new position, with no rotation)
                GameObject tempRoomObj = Instantiate(RandomRoomPrefab(), newPosition, Quaternion.identity) as GameObject;

                //We assume there is an emty roomObj so we declare it to it self
                //Set its parent
                tempRoomObj.transform.parent = this.transform;

                //Give the room a meaningful name
                tempRoomObj.name = "Room: (" + currentCol + ", " + currentRow + ")";

                //Grab the new named room...
                WALLS tempRoom = tempRoomObj.GetComponent<WALLS>();
                


                //DEPENDING WHICH ROW LOWEST, MIDDLE, or HIGHEST, DESIDES DOORS
                //open up and down doors
                if (currentRow == 0)
                {
                    tempRoom.WallNorth.SetActive(false);
                }
                else if(currentRow == rows -1)
                {
                    tempRoom.WallSouth.SetActive(false);
                }
                else
                {
                    tempRoom.WallNorth.SetActive(false);
                    tempRoom.WallSouth.SetActive(false);

                }
                //open left and right doors
                if (currentCol == 0)
                {
                    tempRoom.WallEast.SetActive(false);
                }
                else if(currentCol == cols -1)
                {
                    tempRoom.WallWest.SetActive(false);
                }
                else
                {
                    tempRoom.WallEast.SetActive(false);
                    tempRoom.WallWest.SetActive(false);

                }
                //------
            


                //... save into a grid array
                grid[currentCol, currentRow] = tempRoom;

            }
        }

    }
}




