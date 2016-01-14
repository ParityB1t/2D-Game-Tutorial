using UnityEngine;
using System.Collections;
using UnityEditor;
using Random = System.Random;

public class SpawnEnemies : MonoBehaviour
{

    public GameObject Enemy;
    private int frameTimer;
    //about 3 seconds, tune as you like
    private int frameToSpawn = 180;

    private Random whichSide;

	/// <summary>
    /// This class is used to spawn enemies
    /// Its structure is very similar to the 'FiringAdvice' Script, except it has random point of spawn and a timer
    /// It will also include some calculation to position enemies to spawn at camera edge regardless of camera size
    /// </summary>                    
	void Start () {
	    whichSide = new Random();
	}
	
    	
	void Update ()
	{
	    frameTimer++;

	    if (frameTimer >= frameToSpawn)
	    {
            // Camera.main refers to the only camera in the scene, or whichever we designated as main, don't worry about this too much for now
            // The ViewportToWorldPoint converts a certain point on the camera viewport, ranging (0,0) to (1,1), to the world point that we usually work with
            // I'm using two Random classes, one from c# which is exactly like Java's, the other is Unity's which specialise in generating floating point random number
	        float side = (float) whichSide.Next(0, 2);
	        float vertPosition = UnityEngine.Random.value;

	        Vector3 worldPosition = Camera.main.ViewportToWorldPoint(new Vector3(side,vertPosition));
            //This is because otherwise our z will be -10 and the camera cannot see as they will have the same level
            worldPosition += new Vector3(0,0,-(Camera.main.transform.position.z));

	        GameObject newEnemy = Instantiate(Enemy);
	        newEnemy.transform.position = worldPosition;
	        EnemyMovement eMove = newEnemy.GetComponent<EnemyMovement>();
            

            // we need to flip the sprite because its originally facing the right
            if (side == 1)
                transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1, 1));

            //sets the direction the enemy will move in, depending on where they spawned	  
            eMove.setDirection(side);

	        frameTimer = 0;
	    }
	}
}
