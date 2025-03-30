using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManagaer : MonoBehaviour
{
    //VARIABLES
    //Store a refence to our MapGenerator
    public static GameManagaer instance;
    public Map MAP;
    //array of spawn points
    
    public int mapSeed;

    //SPAWNING
    public GameObject playerControllerPrefab;
    public GameObject playerPrefab;
    public GameObject enemyControllerPrefab;
    public GameObject enemyPrefab;

    public GameObject healthPrefab;
    public GameObject coinPrefab;




    private PlayerSpawn[] PLAYER_SPAWN;
    private EnemySpawn[] ENEMY_SPAWN;
    private HealthSpawn[] HEALTH_SPAWN;
    private CoinSpawn[] COIN_SPAWN;


    public void Awake()
    {
        Random.InitState(mapSeed);
        

        //If there is no game instance..
        if(instance == null)
        {
            instance = this; //intance is this...

            //Prevent the empty game object in the world that holds
            //the game instance from being destroyed once it runs
            //if already placed
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);


        }
        

    }
    public void LoadScene(string world)
    {
        if (GameManagaer.instance == null)
        {
            Debug.LogError("GameManager was destroyed or not found in the new scene!");
        }

        SceneManager.LoadScene(world);

    }
    




    //BLUEPRINTS
    void Start()
    {
        if (MAP == null)
        {
            MAP = FindAnyObjectByType<Map>();
        }
        //Check if mapGenerator already exist in are world..Generatemap
        if(MAP != null)
        {
            MAP.GenerateMap();
        }
        else
        {
            Debug.LogError("MapGenerator not found in scene!");
        }


        PlayerSpawn();

        EnemySpawn();
        //EnemySpawn(); 
        //EnemySpawn(); 
        
        HealthSpawn();
        HealthSpawn(); 
        HealthSpawn(); 
        HealthSpawn(); 
        HealthSpawn(); 

        CoinSpawn();
        CoinSpawn();       
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();
        CoinSpawn();

        
        
    }


    void Update()
    {
        
    }

    //Variables

    public void PlayerSpawn()
    {
        //Finding multiple spawn points in map
        PLAYER_SPAWN = FindObjectsByType<PlayerSpawn>(FindObjectsSortMode.None);
        if (PLAYER_SPAWN != null)
        {
            if(PLAYER_SPAWN.Length > 0)
            {
                GameObject spawnPoint = PLAYER_SPAWN[Random.Range(0, PLAYER_SPAWN.Length)].gameObject;



                //Spawn(PlayerControllerPrefab, at vector(0,0,0), with zero rotation),
                //place it in newPlayerObj
                GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity);

                //Spawn(tankpawnprefab, at spawnpoint object, and spawnpoint object rotation)
                //place it in newPawnObj
                GameObject newPawnObj = Instantiate(playerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);

                //Retrieve player controller from our new player object
                Controller newController = newPlayerObj.GetComponent<Controller>();
                Character newCharacter = newPawnObj.GetComponent<Character>();

                //Hook it up
                newController.CHARACTER = newCharacter;


            }
        }
    }

    
    public void EnemySpawn()
    {
        // Finding multiple spawn points in the map
        ENEMY_SPAWN = FindObjectsByType<EnemySpawn>(FindObjectsSortMode.None);
        
        if (ENEMY_SPAWN.Length > 0) // No need for null check
        {
            // Select a random spawn point
            GameObject spawnPoint = ENEMY_SPAWN[Random.Range(0, ENEMY_SPAWN.Length)].gameObject;

            // Spawn enemy controller at the spawn point
            GameObject newControllerObj = Instantiate(enemyControllerPrefab, spawnPoint.transform.position, Quaternion.identity);

            // Spawn enemy pawn at the spawn point
            GameObject newPawnObj = Instantiate(enemyPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);

            // Retrieve player controller and character components
            Controller newController = newControllerObj.GetComponent<Controller>();
            Character newCharacter = newPawnObj.GetComponent<Character>();

           
        }
    }

    public void HealthSpawn()
    {
        HEALTH_SPAWN = FindObjectsByType<HealthSpawn>(FindObjectsSortMode.None);
        if (HEALTH_SPAWN != null)
        {
            if(HEALTH_SPAWN.Length > 0)
            {
                GameObject spawnPoint = HEALTH_SPAWN[Random.Range(0, HEALTH_SPAWN.Length)].gameObject;

                GameObject healthObj = Instantiate(healthPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);


            }

        }

    }
    public void CoinSpawn()
    {
        COIN_SPAWN = FindObjectsByType<CoinSpawn>(FindObjectsSortMode.None);
        if (COIN_SPAWN != null)
        {
            if(COIN_SPAWN.Length > 0)
            {
                GameObject spawnPoint = COIN_SPAWN[Random.Range(0, COIN_SPAWN.Length)].gameObject;

                GameObject healthObj = Instantiate(coinPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);


            }

        }

    }


    
    



        
    
}
