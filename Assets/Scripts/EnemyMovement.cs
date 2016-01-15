using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    private Vector3 goLeft = new Vector3(-0.1f,0);
    private Vector3 goRight = new Vector3(0.1f,0);
    private Vector3 direction;

	void Start () {
	    
	}
	
	
	void Update ()
	{
	    transform.position += direction;
	}

    public void setDirection(float side)
    {
        if (side == 0)
            direction = goRight;        
        else        
            direction = goLeft;
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
            SceneManager.LoadScene(2);
    }
}
