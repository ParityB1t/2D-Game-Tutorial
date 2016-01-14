using UnityEngine;
using System.Collections;

public class AdviceFiring : MonoBehaviour
{

    public GameObject advice;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
            GameObject newAdvice = Instantiate(advice);
            newAdvice.transform.SetParent(gameObject.transform);
	        newAdvice.transform.localPosition = new Vector3(0,0.1f);
	    }
	        
	}
}
