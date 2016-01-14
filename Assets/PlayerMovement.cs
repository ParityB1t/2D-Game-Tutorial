using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization

    private Transform trans;
    private bool facingRight = true;

	void Start ()
	{
	    trans = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            trans.position += new Vector3(0,.1f);
        else if (Input.GetKey(KeyCode.S))
            trans.position += new Vector3(0,-.1f);

	    if (Input.GetKey(KeyCode.A) && facingRight)
	    {
            flipSprite();            
	        facingRight = false;
	    }
        else if (Input.GetKey(KeyCode.D) && !facingRight)
        {            
            flipSprite();
            facingRight = true;
        }	        
	}

    void flipSprite()
    {
        trans.localScale = Vector3.Scale(trans.localScale, new Vector3(-1f, 1));
    }
}
