using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	// Use this for initialization
    private Vector3 flyRight = new Vector3(0.5f,0);
    private Vector3 flyLeft = new Vector3(-0.5f,0);
    private Vector3 currentDirection;

	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + currentDirection;
	}

    /// <summary>
    /// Changing the direciton the arrow will fly
    /// </summary>
    /// <param name="facingRight"></param>
    public void setCurrentDirection(bool facingRight)
    {
        if (facingRight)
            currentDirection = flyRight;
        else
            currentDirection = flyLeft;

    }
}
