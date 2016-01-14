using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	// Use this for initialization
    private Vector3 flyRight = new Vector3(0.5f,0);

	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + flyRight;
	}
}
