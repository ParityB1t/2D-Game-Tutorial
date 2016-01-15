using UnityEngine;
using System.Collections;

public class AdviceFiring : MonoBehaviour
{

    public GameObject advice;
    private PlayerMovement pMove;
    private float colliderSize;

	// Use this for initialization
	void Start ()
	{
	    colliderSize = gameObject.GetComponent<BoxCollider2D>().size.x;
	    pMove = gameObject.GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
            GameObject newAdvice = Instantiate(advice);
            //this is a hacky way of simulating 'localPosition' as in tutorial, some of you may have already discovered this and well done to those
	        newAdvice.transform.position = gameObject.transform.position + new Vector3(colliderSize, 0.1f);

            //if Mark is facing left, we need to flip the arrow so the image is appropriate
	        if (!pMove.isFacingRight())
	        {
                newAdvice.transform.position = gameObject.transform.position - new Vector3(colliderSize, 0.1f);
                newAdvice.transform.localScale = Vector3.Scale(newAdvice.transform.localScale, new Vector3(-1, 1));
            }
	           

            //setting the direction of the arrow to go left instead of right, initially it only went right
	        newAdvice.GetComponent<BulletMovement>().setCurrentDirection(pMove.isFacingRight());
	        
	    }
	        
	}
}
